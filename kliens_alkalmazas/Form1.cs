namespace kliens_alkalmazas
{
    public partial class Form1 : Form
    {
        Models.Jet2HolidaySqldbContext jet2HolidayContext = new Models.Jet2HolidaySqldbContext();
        public Form1()
        {
            InitializeComponent();

            LoadDefaultUsers();

            foglalaBindingSource.DataSource = jet2HolidayContext.Foglalas.ToList();
            userBindingSource.DataSource = jet2HolidayContext.Users.ToList();
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
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("Pending");

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
        }

        private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFoglalasGridBySelectedUser();
        }

        private void RefreshFoglalasGridBySelectedUser()
        {
            if (listBoxUser.SelectedItem is Models.User selectedUser)
            {
                var foglalasok = jet2HolidayContext.Foglalas
                    .Where(f => f.UserId == selectedUser.UserId)
                    .ToList();

                foglalaBindingSource.DataSource = foglalasok;
            }
            else
            {
                foglalaBindingSource.DataSource = new List<Models.Foglala>();
            }
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
    }
}
