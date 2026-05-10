namespace kliens_alkalmazas
{
    public partial class Form1 : Form
    {
        private const string AllStatus = "All";
        private readonly Models.Jet2HolidaySqldbContext jet2HolidayContext = new Models.Jet2HolidaySqldbContext();
        public Models.Foglala? kivalasztottFoglalas;

        public Form1()
        {
            InitializeComponent();

            LoadDefaultUsers();

            hccOrderBindingSource.DataSource = jet2HolidayContext.HccOrders.ToList();
            hccProductBindingSource.DataSource = jet2HolidayContext.HccProducts.ToList();

            listBoxUser.SelectedIndexChanged += listBoxUser_SelectedIndexChanged;

            if (listBoxUser.Items.Count > 0)
            {
                listBoxUser.SelectedIndex = 0;
            }

            RefreshFoglalasGridBySelectedUser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add(AllStatus);
            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("Confirmed");
            comboBox1.Items.Add("Cancelled");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
        }

        private void textBoxUserFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserFilter.Text))
            {
                LoadDefaultUsers();
            }
            else
            {
                var userFilter = from f in jet2HolidayContext.Users
                                 where f.DisplayName.Contains(textBoxUserFilter.Text)
                                 select f;

                userBindingSource.DataSource = userFilter.ToList();
            }

            if (listBoxUser.Items.Count > 0)
            {
                listBoxUser.SelectedIndex = 0;
            }
            else
            {
                foglalaBindingSource.DataSource = new List<Models.Foglala>();
            }

            RefreshFoglalasGridBySelectedUser();
        }

        private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFoglalasGridBySelectedUser();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFoglalasGridBySelectedUser();
        }

        private void RefreshFoglalasGridBySelectedUser()
        {
            if (listBoxUser.SelectedItem is not Models.User selectedUser)
            {
                foglalaBindingSource.DataSource = new List<Models.Foglala>();
                return;
            }

            var selectedStatus = comboBox1.SelectedItem?.ToString() ?? AllStatus;

            IQueryable<Models.Foglala> query = jet2HolidayContext.Foglalas
                .Where(f => f.UserId == selectedUser.UserId);

            if (!string.Equals(selectedStatus, AllStatus, StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(f => f.Status == selectedStatus);
            }

            query = query.OrderBy(f => f.FoglalasId);

            foglalaBindingSource.DataSource = query.ToList();
        }

        private void LoadDefaultUsers()
        {
            var defaultUsers = jet2HolidayContext.Users
                .Where(u => jet2HolidayContext.Foglalas.Any(f => f.UserId == u.UserId))
                .OrderBy(u => u.DisplayName)
                .ToList();

            userBindingSource.DataSource = defaultUsers;
        }

        private void buttonAddNewBooking_Click(object sender, EventArgs e)
        {
            var uj = new Models.Foglala
            {
                Status = "Pending",
                LetrehozasDatuma = DateTime.Now
            };

            if (listBoxUser.SelectedItem is Models.User selectedUser)
            {
                uj.UserId = selectedUser.UserId;
                uj.Nev = selectedUser.DisplayName;
                uj.Email = selectedUser.Email;
                uj.Telefon = GetPhoneNumberForUser(selectedUser);
            }

            using var fan = new FormAdd(uj);

            if (fan.ShowDialog() == DialogResult.OK)
            {
                jet2HolidayContext.Foglalas.Add(fan.ujFoglalas);

                try
                {
                    jet2HolidayContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    var details = ex.InnerException?.Message ?? ex.Message;
                    MessageBox.Show(details, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshFoglalasGridBySelectedUser();
            }

            this.Show();
        }

        private void buttonEditBooking_Click(object sender, EventArgs e)
        {
            if (foglalaBindingSource.Current is not Models.Foglala aktualis)
            {
                MessageBox.Show("Nincs kiválasztott foglalás.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var szerkesztendo = new Models.Foglala
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

            using var formEdit = new FormEdit(szerkesztendo);

            if (formEdit.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var modositott = formEdit.ujFoglalas;

            var entity = jet2HolidayContext.Foglalas.FirstOrDefault(f => f.FoglalasId == modositott.FoglalasId);
            if (entity == null)
            {
                MessageBox.Show("A módosítandó rekord nem található.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            jet2HolidayContext.Entry(entity).CurrentValues.SetValues(modositott);
            entity.LastModifiedDate = DateTime.Now;

            try
            {
                jet2HolidayContext.SaveChanges();
                RefreshFoglalasGridBySelectedUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string? GetPhoneNumberForUser(Models.User selectedUser)
        {
            if (string.IsNullOrWhiteSpace(selectedUser.Email))
            {
                return null;
            }

            var hccUserBvin = jet2HolidayContext.HccUsers
                .Where(user => user.Email == selectedUser.Email)
                .Select(user => user.Bvin)
                .FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(hccUserBvin))
            {
                var addressPhone = jet2HolidayContext.HccAddresses
                    .Where(address => address.UserBvin == hccUserBvin && address.Phone != "")
                    .OrderByDescending(address => address.LastUpdated)
                    .Select(address => address.Phone)
                    .FirstOrDefault();

                if (!string.IsNullOrWhiteSpace(addressPhone))
                {
                    return addressPhone;
                }

                var hccUserPhone = jet2HolidayContext.HccUsers
                    .Where(user => user.Bvin == hccUserBvin && user.Phones != "")
                    .Select(user => user.Phones)
                    .FirstOrDefault();

                if (!string.IsNullOrWhiteSpace(hccUserPhone))
                {
                    return hccUserPhone;
                }
            }

            var latestOrderUserBvin = jet2HolidayContext.HccOrders
                .Where(order => order.UserEmail == selectedUser.Email)
                .OrderByDescending(order => order.TimeOfOrder)
                .Select(order => order.UserId)
                .FirstOrDefault();

            if (string.IsNullOrWhiteSpace(latestOrderUserBvin))
            {
                return null;
            }

            return jet2HolidayContext.HccAddresses
                .Where(address => address.UserBvin == latestOrderUserBvin && address.Phone != "")
                .OrderByDescending(address => address.LastUpdated)
                .Select(address => address.Phone)
                .FirstOrDefault();
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (foglalaBindingSource.Current is not Models.Foglala kijelolt)
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

            var entity = jet2HolidayContext.Foglalas.FirstOrDefault(f => f.FoglalasId == kijelolt.FoglalasId);
            if (entity == null)
            {
                MessageBox.Show("A törlendő rekord nem található.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            jet2HolidayContext.Foglalas.Remove(entity);

            try
            {
                jet2HolidayContext.SaveChanges();
                RefreshFoglalasGridBySelectedUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
