using kliens_alkalmazas_api.Services;

namespace kliens_alkalmazas_api
{
    public partial class FormProductBvin : Form
    {
        private readonly Jet2HolidayApiClient apiClient = new();
        private List<Models.HccProduct> allProducts = new();
        public Models.HccProduct SelectedProduct = new();

        public FormProductBvin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.DialogResult = DialogResult.None;
            dataGridView1.CellDoubleClick += (_, _) => SelectCurrentProduct();
        }

        private async void FormProductBvin_Load(object sender, EventArgs e)
        {
            allProducts = await apiClient.GetProductsAsync();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var filter = textBoxProductBvinSzuro.Text.Trim();
            if (string.IsNullOrWhiteSpace(filter))
            {
                hccProductBindingSource.DataSource = allProducts;
                return;
            }

            hccProductBindingSource.DataSource = allProducts
                .Where(product => product.Bvin.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                    product.Sku.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                    product.ProductName.Contains(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        private void textBoxProductBvinSzuro_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCurrentProduct();
        }

        private void SelectCurrentProduct()
        {
            if (hccProductBindingSource.Current is Models.HccProduct selectedProduct)
            {
                SelectedProduct = selectedProduct;
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
