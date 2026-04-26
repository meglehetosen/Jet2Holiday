using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kliens_alkalmazas
{
    public partial class FormOrderBvin : Form
    {
        Models.Jet2HolidaySqldbContext jet2HolidayContext = new Models.Jet2HolidaySqldbContext();
        public Models.HccOrder SelectedOrder = new Models.HccOrder();
        public FormOrderBvin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormOrderBvin_Load(object sender, EventArgs e)
        {
            jet2HolidayContext.HccOrders.Load();
            hccOrderBindingSource.DataSource = jet2HolidayContext.HccOrders.Local.ToBindingList();
        }

        private void Adatbetoltes()
        {
            var filter = textBoxOrderBvinSzuro.Text.Trim();
            if (string.IsNullOrWhiteSpace(filter))
            {
                hccOrderBindingSource.DataSource = jet2HolidayContext.HccOrders
                    .ToList();
                return;
            }
            if (Guid.TryParse(filter, out var guidFilter))
            {
                hccOrderBindingSource.DataSource = jet2HolidayContext.HccOrders
                    .Where(o => o.Bvin == guidFilter)
                    .ToList();
            }
            else
            {
                hccOrderBindingSource.DataSource = jet2HolidayContext.HccOrders
                    .AsEnumerable()
                    .Where(o => o.Bvin.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
        }

        private void textBoxOrderBvinSzuro_TextChanged(object sender, EventArgs e)
        {
            Adatbetoltes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedOrder = (Models.HccOrder)hccOrderBindingSource.Current;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
