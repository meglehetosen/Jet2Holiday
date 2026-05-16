using kliens_alkalmazas_api.Models;
using kliens_alkalmazas_api.Services;

namespace kliens_alkalmazas_api
{
    public partial class Form1 : Form
    {
        private const string AllStatus = "All";
        private readonly Jet2HolidayApiClient apiClient = new();
        private Dictionary<Guid, string> productNamesByBvin = new();
        private List<User> allUsers = new();
        private List<Foglala> allFoglalas = new();
        public Foglala? kivalasztottFoglalas;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            productBvinDataGridViewTextBoxColumn.HeaderText = "Szállás";
            productBvinDataGridViewTextBoxColumn.Width = 220;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add(AllStatus);
                comboBox1.Items.Add("Pending");
                comboBox1.Items.Add("Confirmed");
                comboBox1.Items.Add("Cancelled");

                comboBox1.SelectedIndexChanged += async (_, _) => await RefreshFoglalasGridBySelectedUserAsync();
                comboBox1.SelectedIndex = 0;

                await LoadInitialDataAsync();
                if (listBoxUser.Items.Count > 0)
                {
                    listBoxUser.SelectedIndex = 0;
                }

                RefreshFoglalasGridBySelectedUser();
                _ = LoadProductNamesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Nem sikerult betolteni az adatokat.\n\n" + ex.Message,
                    "API hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void textBoxUserFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyUserFilter();

            if (listBoxUser.Items.Count > 0)
            {
                listBoxUser.SelectedIndex = 0;
            }
            else
            {
                foglalaBindingSource.DataSource = new List<Foglala>();
            }

            RefreshFoglalasGridBySelectedUser();
            await Task.CompletedTask;
        }

        private async void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFoglalasGridBySelectedUser();
            await Task.CompletedTask;
        }

        private async Task RefreshFoglalasGridBySelectedUserAsync()
        {
            RefreshFoglalasGridBySelectedUser();
            await Task.CompletedTask;
        }

        private void RefreshFoglalasGridBySelectedUser()
        {
            try
            {
                if (listBoxUser.SelectedItem is not User selectedUser)
                {
                    productNamesByBvin = new Dictionary<Guid, string>();
                    foglalaBindingSource.DataSource = new List<Foglala>();
                    return;
                }

                var selectedStatus = comboBox1.SelectedItem?.ToString() ?? AllStatus;
                var foglalasok = allFoglalas
                    .Where(foglalas => foglalas.UserId == selectedUser.UserId)
                    .Where(foglalas => string.Equals(selectedStatus, AllStatus, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(foglalas.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(foglalas => foglalas.FoglalasId)
                    .ToList();

                foglalaBindingSource.DataSource = foglalasok;
                _ = LoadProductNamesAsync(foglalasok);
            }
            catch (Exception ex)
            {
                foglalaBindingSource.DataSource = new List<Foglala>();
                MessageBox.Show(
                    "Nem sikerult frissiteni a foglalasokat.\n\n" + ex.Message,
                    "API hiba",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private async Task LoadProductNamesAsync(IEnumerable<Foglala>? source = null)
        {
            var productBvins = (source ?? allFoglalas)
                .Select(f => f.ProductBvin)
                .Where(productBvin => productBvin != Guid.Empty)
                .Where(productBvin => !productNamesByBvin.ContainsKey(productBvin))
                .Distinct()
                .ToList();

            if (productBvins.Count == 0)
            {
                return;
            }

            try
            {
                var loadedNames = await apiClient.GetProductNamesAsync(productBvins);
                foreach (var pair in loadedNames)
                {
                    productNamesByBvin[pair.Key] = pair.Value;
                }

                dataGridView1.Invoke(() => dataGridView1.Refresh());
            }
            catch
            {
            }
        }

        private void dataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] == productBvinDataGridViewTextBoxColumn &&
                e.Value is Guid productBvin &&
                productNamesByBvin.TryGetValue(productBvin, out var productName))
            {
                e.Value = productName;
                e.FormattingApplied = true;
                return;
            }

            if (dataGridView1.Columns[e.ColumnIndex] == lokacioDataGridViewTextBoxColumn &&
                e.Value is string location)
            {
                e.Value = NormalizeLocation(location);
                e.FormattingApplied = true;
            }
        }

        private static string NormalizeLocation(string location)
        {
            return location.Trim().ToUpperInvariant() switch
            {
                "MILANO" or "MILÁNÓ" => "Milánó",
                "ISZTAMBUL" => "Isztambul",
                "MALDIV-SZIGETEK" or "MALDÍV-SZIGETEK" => "Maldív-szigetek",
                _ => location
            };
        }

        private static void NormalizeFoglalasLocation(Foglala foglalas)
        {
            if (!string.IsNullOrWhiteSpace(foglalas.Lokacio))
            {
                foglalas.Lokacio = NormalizeLocation(foglalas.Lokacio);
            }
        }

        private async Task LoadInitialDataAsync()
        {
            var usersTask = apiClient.GetUsersAsync();
            var foglalasTask = apiClient.GetAllFoglalasAsync();

            allUsers = await usersTask;
            allFoglalas = await foglalasTask;
            allFoglalas.ForEach(NormalizeFoglalasLocation);
            ApplyUserFilter();
        }

        private void ApplyUserFilter()
        {
            var filter = textBoxUserFilter.Text?.Trim();
            var userIdsWithFoglalas = allFoglalas
                .Select(foglalas => foglalas.UserId)
                .ToHashSet();

            userBindingSource.DataSource = allUsers
                .Where(user => userIdsWithFoglalas.Contains(user.UserId))
                .Where(user => string.IsNullOrWhiteSpace(filter) ||
                    user.DisplayName.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                    (user.Email?.Contains(filter, StringComparison.OrdinalIgnoreCase) ?? false))
                .OrderBy(user => user.DisplayName)
                .ToList();
        }

        private async void buttonAddNewBooking_Click(object sender, EventArgs e)
        {
            var uj = new Foglala
            {
                Status = "Pending",
                LetrehozasDatuma = DateTime.Now,
                BookingReference = await apiClient.GetNextBookingReferenceAsync()
            };

            if (listBoxUser.SelectedItem is User selectedUser)
            {
                uj.UserId = selectedUser.UserId;
                uj.Nev = selectedUser.DisplayName;
                uj.Email = selectedUser.Email ?? string.Empty;
                uj.Telefon = await apiClient.GetPhoneNumberForUserAsync(selectedUser);
            }

            using var fan = new FormAdd(uj);

            if (fan.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var created = await apiClient.CreateFoglalasAsync(fan.ujFoglalas);
                    NormalizeFoglalasLocation(created);
                    allFoglalas.Add(created);
                    ApplyUserFilter();
                    RefreshFoglalasGridBySelectedUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Show();
        }

        private async void buttonEditBooking_Click(object sender, EventArgs e)
        {
            if (foglalaBindingSource.Current is not Foglala aktualis)
            {
                MessageBox.Show("Nincs kiválasztott foglalás.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var szerkesztendo = new Foglala
            {
                FoglalasId = aktualis.FoglalasId,
                UserId = aktualis.UserId,
                ProductBvin = aktualis.ProductBvin,
                Telefon = aktualis.Telefon,
                Lokacio = aktualis.Lokacio,
                ErkezesDatum = aktualis.ErkezesDatum,
                TavozasDatum = aktualis.TavozasDatum,
                VendegSzam = aktualis.VendegSzam,
                LetrehozasDatuma = aktualis.LetrehozasDatuma,
                Status = aktualis.Status,
                IsCancelled = aktualis.IsCancelled,
                CancellationReason = aktualis.CancellationReason,
                LastModifiedDate = aktualis.LastModifiedDate,
                HandledByUserId = aktualis.HandledByUserId,
                BookingReference = aktualis.BookingReference,
                EjszakakSzama = aktualis.EjszakakSzama,
                OrderBvin = aktualis.OrderBvin,
                Email = aktualis.Email,
                Nev = aktualis.Nev
            };
            NormalizeFoglalasLocation(szerkesztendo);

            using var formEdit = new FormEdit(szerkesztendo);

            if (formEdit.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            formEdit.ujFoglalas.LastModifiedDate = DateTime.Now;

            try
            {
                await apiClient.UpdateFoglalasAsync(formEdit.ujFoglalas);
                NormalizeFoglalasLocation(formEdit.ujFoglalas);
                var index = allFoglalas.FindIndex(foglalas => foglalas.FoglalasId == formEdit.ujFoglalas.FoglalasId);
                if (index >= 0)
                {
                    allFoglalas[index] = formEdit.ujFoglalas;
                }

                RefreshFoglalasGridBySelectedUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (foglalaBindingSource.Current is not Foglala kijelolt)
            {
                MessageBox.Show("Nincs kiválasztott foglalás.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var megerosites = MessageBox.Show(
                $"Biztosan törlöd ezt a foglalást? (ID: {kijelolt.FoglalasId})",
                "Megerősítés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (megerosites != DialogResult.Yes)
            {
                return;
            }

            try
            {
                await apiClient.DeleteFoglalasAsync(kijelolt.FoglalasId);
                allFoglalas.RemoveAll(foglalas => foglalas.FoglalasId == kijelolt.FoglalasId);
                ApplyUserFilter();
                RefreshFoglalasGridBySelectedUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
