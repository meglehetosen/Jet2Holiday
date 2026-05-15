using kliens_alkalmazas_api.Services;

namespace kliens_alkalmazas_api
{
    public partial class FormOrderBvin : Form
    {
        private readonly Jet2HolidayApiClient apiClient = new();
        private List<Models.HccOrder> allOrders = new();
        public Models.HccOrder SelectedOrder = new();

        public FormOrderBvin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.DialogResult = DialogResult.None;
            dataGridView1.CellDoubleClick += (_, _) => SelectCurrentOrder();
        }

        private async void FormOrderBvin_Load(object sender, EventArgs e)
        {
            allOrders = await apiClient.GetOrdersAsync();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var filter = textBoxOrderBvinSzuro.Text.Trim();
            if (string.IsNullOrWhiteSpace(filter))
            {
                hccOrderBindingSource.DataSource = allOrders;
                return;
            }

            hccOrderBindingSource.DataSource = allOrders
                .Where(order => order.Bvin.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                    order.OrderNumber.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                    order.UserEmail.Contains(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        private void textBoxOrderBvinSzuro_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCurrentOrder();
        }

        private void SelectCurrentOrder()
        {
            if (hccOrderBindingSource.Current is Models.HccOrder selectedOrder)
            {
                SelectedOrder = selectedOrder;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
