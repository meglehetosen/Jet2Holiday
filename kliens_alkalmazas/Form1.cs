namespace kliens_alkalmazas
{
    public partial class Form1 : Form
    {
        private const string AllStatus = "All";
        private readonly Models.Jet2HolidaySqldbContext jet2HolidayContext = new Models.Jet2HolidaySqldbContext();

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
                foglalaBindingSource.DataSource = new List<FoglalasClass>();
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
                foglalaBindingSource.DataSource = new List<FoglalasClass>();
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

            if (string.Equals(selectedStatus, AllStatus, StringComparison.OrdinalIgnoreCase))
            {
                query = query.Take(10);
            }

            var foglalasok = (from f in query
                              join u in jet2HolidayContext.Users on f.UserId equals u.UserId
                              select new FoglalasClass
                              {
                                  FoglalasId = f.FoglalasId,
                                  UserId = f.UserId,
                                  ProductBvin = f.ProductBvin,
                                  Telefon = f.Telefon,
                                  Lokacio = f.Lokacio,
                                  ErkezesDatum = f.ErkezesDatum,
                                  TavozasDatum = f.TavozasDatum,
                                  VendegSzam = f.VendegSzam,
                                  LetrehozasDatuma = f.LetrehozasDatuma,
                                  Status = f.Status,
                                  IsCancelled = f.IsCancelled,
                                  CancellationReason = f.CancellationReason,
                                  LastModifiedDate = f.LastModifiedDate,
                                  HandledByUserId = f.HandledByUserId,
                                  BookingReference = f.BookingReference,
                                  EjszakakSzama = f.EjszakakSzama,
                                  OrderBvin = f.OrderBvin,
                                  Email = u.Email,
                                  Nev = u.DisplayName
                              }).ToList();

            foglalaBindingSource.DataSource = foglalasok;
        }

        private void LoadDefaultUsers()
        {
            var defaultUsers = jet2HolidayContext.Users
                .Where(u => jet2HolidayContext.Foglalas.Any(f => f.UserId == u.UserId))
                .OrderBy(u => u.DisplayName)
                .Take(10)
                .ToList();

            userBindingSource.DataSource = defaultUsers;
        }

        private void buttonAddNewBooking_Click(object sender, EventArgs e)
        {
            var uj = new FoglalasClass
            {
                Status = "Pending",
                LetrehozasDatuma = DateTime.Now
            };

            if (listBoxUser.SelectedItem is Models.User selectedUser)
            {
                uj.UserId = selectedUser.UserId;
                uj.Nev = selectedUser.DisplayName;
                uj.Email = selectedUser.Email;
            }

            using var fan = new FormAdd(uj);

            if (fan.ShowDialog() == DialogResult.OK)
            {
                var entity = new Models.Foglala
                {
                    FoglalasId = fan.ujFoglalas.FoglalasId,
                    UserId = fan.ujFoglalas.UserId,
                    ProductBvin = fan.ujFoglalas.ProductBvin,
                    Telefon = fan.ujFoglalas.Telefon,
                    Lokacio = fan.ujFoglalas.Lokacio,
                    ErkezesDatum = fan.ujFoglalas.ErkezesDatum,
                    TavozasDatum = fan.ujFoglalas.TavozasDatum,
                    VendegSzam = fan.ujFoglalas.VendegSzam,
                    LetrehozasDatuma = fan.ujFoglalas.LetrehozasDatuma,
                    Status = fan.ujFoglalas.Status,
                    IsCancelled = fan.ujFoglalas.IsCancelled,
                    CancellationReason = fan.ujFoglalas.CancellationReason,
                    LastModifiedDate = fan.ujFoglalas.LastModifiedDate,
                    HandledByUserId = fan.ujFoglalas.HandledByUserId,
                    BookingReference = fan.ujFoglalas.BookingReference,
                    EjszakakSzama = fan.ujFoglalas.EjszakakSzama,
                    OrderBvin = fan.ujFoglalas.OrderBvin
                };

                jet2HolidayContext.Foglalas.Add(entity);

                try
                { 
                    jet2HolidayContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshFoglalasGridBySelectedUser();
            }

            this.Show();
        }
    }
}