using kliens_alkalmazas_api.Models;
using kliens_alkalmazas_api.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kliens_alkalmazas_api
{
    public partial class FormAdd : Form
    {
        private readonly Jet2HolidayApiClient apiClient = new();

        public Models.Foglala ujFoglalas = new();

        public FormAdd(Models.Foglala uj)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            ujFoglalas = uj ?? new Models.Foglala();
            buttonMentes.DialogResult = DialogResult.None;
            textBox10.Leave += ProductBvin_Leave;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ujFoglalas.BookingReference))
            {
                ujFoglalas.BookingReference = GenerateNextBookingReference();
            }

            SetLocationFromProductBvin();
            bindingSource1.DataSource = ujFoglalas;
            SetProductTextBoxFromCurrentProduct();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("Confirmed");
            comboBox1.Items.Add("Cancelled");
            if (!string.IsNullOrEmpty(ujFoglalas.Status))
            {
                comboBox1.SelectedItem = ujFoglalas.Status;
            }
            else
            {
                comboBox1.SelectedIndex = 0; // Alapértelmezett státusz: Pending
            }
        }

        // REGEXEK ÉS VALIDÁLÁSOK

        internal bool CheckEmpty(string név)
        {
            return !string.IsNullOrEmpty(név);
        }

        internal bool CheckEmail(string Email)
        {
            Regex r = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
            return r.IsMatch(Email);
        }

        //private bool CheckDate(string ErkezesDatum, string TavozasDatum)
        //{
        //    Regex r = new Regex(@"^(0?[1-9]|1[0-2])/(0?[1-9]|[12][0-9]|3[01])/\d{4}$");
        //    return r.IsMatch(ErkezesDatum) && r.IsMatch(TavozasDatum);
        //}

        internal bool CheckPhoneNumber(string Telefon)
        {
            Regex r = new Regex(@"^\+36\d{9}$");
            return r.IsMatch(Telefon);
        }

        internal bool CheckEjszakak(string input)
        {
            return int.TryParse(input, out var ejszakak) && ejszakak > 0 && ejszakak < 20;
        }

        internal bool CheckBookingReference(string BookingReference)
        {
            Regex r = new Regex(@"^JH-\d{4}-\d{6}$");
            return r.IsMatch(BookingReference);
        }

        internal bool CheckVendegszam(string Vendegszam)
        {
            Regex r = new Regex(@"^\d+$");
            return r.IsMatch(Vendegszam);
        }

        // VALIDÁLÁSOK

        //Név, email, telefon, lokáció, érkezés és távozás dátuma, foglalási referencia, éjszakák száma, vendégszám validálása

        //Név, email, telefon, lokáció validálása: nem lehet üres, email cím formátuma, telefon formátuma (+36XXXXXXXXX)

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "A név nem lehet üres!");
            }
            else { errorProvider1.SetError(textBox1, string.Empty); }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Az email megadása kötelező!");
            }
            else { errorProvider1.SetError(textBox2, string.Empty); }

            if (!CheckEmail(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Az email cím formátuma nem megfelelő!");
            }
            else { errorProvider1.SetError(textBox2, string.Empty); }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "A telefon megadása kötelező!");
            }
            else { errorProvider1.SetError(textBox3, string.Empty); }
            if (!CheckPhoneNumber(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "A telefon formátuma nem megfelelő! (+36XXXXXXXXX)");
            }
            else { errorProvider1.SetError(textBox3, string.Empty); }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox4.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox4, "A lokáció megadása kötelező!");
            }
            else { errorProvider1.SetError(textBox4, string.Empty); }
        }

        //Érkezés és távozás dátuma validálása: formátum ellenőrzése (YYYY. MM. DD.)

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            //if (!CheckDate(textBox5.Text, textBox6.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(textBox5, "A dátum formátuma nem megfelelő! (M/DD/YYYY)");
            //}
            //else { errorProvider1.SetError(textBox5, string.Empty); }

            if (DateTime.TryParse(textBox5.Text, out DateTime erkezes) && DateTime.TryParse(textBox6.Text, out DateTime tavozas))
            {
                if (erkezes >= tavozas)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(textBox5, "Az érkezés dátuma nem lehet később vagy egyenlő a távozás dátumával!");
                }
                else
                {
                    errorProvider1.SetError(textBox5, string.Empty);
                }
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            //if (!CheckDate(textBox5.Text, textBox6.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(textBox6, "A dátum formátuma nem megfelelő! (M/DD/YYYY)");
            //}
            //else { errorProvider1.SetError(textBox6, string.Empty); }

            if (DateTime.TryParse(textBox5.Text, out DateTime erkezes) && DateTime.TryParse(textBox6.Text, out DateTime tavozas))
            {
                if (tavozas <= erkezes)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(textBox6, "A távozás dátuma nem lehet korábbi vagy egyenlő az érkezés dátumával!");
                }
                else
                {
                    errorProvider1.SetError(textBox6, string.Empty);
                }
            }
        }

        //Foglalási referencia validálása: formátum ellenőrzése (JH-XXXX-XXXXXX)

        private void textBox13_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckBookingReference(textBox13.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox13, "A foglalási referencia formátuma nem megfelelő! (JH-XXXX-XXXXXX)");
            }
            else { errorProvider1.SetError(textBox13, string.Empty); }
        }

        //Éjszakák száma validálása: csak szám lehet, nem lehet 20 vagy annál többet egy szállásnál eltölteni

        private void textBox14_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEjszakak(textBox14.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox14, "Az éjszakák száma 1 és 19 közötti egész szám lehet!");
            }
            else
            {
                errorProvider1.SetError(textBox14, string.Empty);
            }
        }

        //Vendégszám validálása: csak szám lehet, nem lehet 6 vagy annál több egy szobában

        private void textBox15_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckVendegszam(textBox7.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox7, "A vendégszám csak szám lehet!");
            }
            else { errorProvider1.SetError(textBox7, string.Empty); }

            if (int.TryParse(textBox7.Text, out int vendegszam) && vendegszam >= 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox7, "A vendégszám nem lehet 6 vagy annál több!");
            }
            else { errorProvider1.SetError(textBox7, string.Empty); }
        }



        private void buttonSearchProductbvin_Click(object sender, EventArgs e)
        {
            using FormProductBvin formProductBvin = new FormProductBvin();

            if (formProductBvin.ShowDialog() == DialogResult.OK)
            {
                ujFoglalas.ProductBvin = formProductBvin.SelectedProduct.Bvin;
                SetLocationFromProductBvin();

                bindingSource1.ResetBindings(false);
                SetProductTextBoxFromCurrentProduct();
            }
        }

        private async void buttonSearchOrderbvin_Click(object sender, EventArgs e)
        {
            using FormOrderBvin formOrderBvin = new FormOrderBvin();

            if (formOrderBvin.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ujFoglalas.OrderBvin = formOrderBvin.SelectedOrder.Bvin;
                    textBox11.Text = ujFoglalas.OrderBvin?.ToString() ?? string.Empty;
                    await FillBookingFieldsFromOrderAsync(formOrderBvin.SelectedOrder);
                    bindingSource1.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Az Order részleteinek betöltése nem sikerült.\n\n" + ex.Message,
                        "Order adatok",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private async Task FillBookingFieldsFromOrderAsync(Models.HccOrder order)
        {
            Models.BookingOrderDetails? orderData;
            try
            {
                UseWaitCursor = true;
                orderData = await apiClient.GetBookingOrderDetailsAsync(order.Bvin);
            }
            finally
            {
                UseWaitCursor = false;
            }

            if (orderData == null)
            {
                MessageBox.Show(
                    "A kiválasztott Order részleteiből nem sikerült kiolvasni a foglalási adatokat.",
                    "Order adatok",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (orderData.ProductBvin != Guid.Empty)
            {
                ujFoglalas.ProductBvin = orderData.ProductBvin;
                textBox10.Text = string.IsNullOrWhiteSpace(orderData.ProductName)
                    ? orderData.ProductBvin.ToString()
                    : orderData.ProductName;
            }

            if (!string.IsNullOrWhiteSpace(orderData.Lokacio))
            {
                ujFoglalas.Lokacio = orderData.Lokacio;
                textBox4.Text = orderData.Lokacio;
            }

            if (orderData.ErkezesDatum.HasValue)
            {
                ujFoglalas.ErkezesDatum = orderData.ErkezesDatum.Value;
                textBox5.Text = orderData.ErkezesDatum.Value.ToString("yyyy.MM.dd", CultureInfo.InvariantCulture);
            }

            if (orderData.TavozasDatum.HasValue)
            {
                ujFoglalas.TavozasDatum = orderData.TavozasDatum.Value;
                textBox6.Text = orderData.TavozasDatum.Value.ToString("yyyy.MM.dd", CultureInfo.InvariantCulture);
            }

            if (orderData.VendegSzam.HasValue)
            {
                ujFoglalas.VendegSzam = orderData.VendegSzam.Value;
                textBox7.Text = orderData.VendegSzam.Value.ToString(CultureInfo.InvariantCulture);
            }

            if (orderData.EjszakakSzama.HasValue)
            {
                ujFoglalas.EjszakakSzama = orderData.EjszakakSzama.Value;
                textBox14.Text = orderData.EjszakakSzama.Value.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void SetProductTextBoxFromCurrentProduct()
        {
            if (ujFoglalas.ProductBvin == Guid.Empty)
            {
                textBox10.Text = string.Empty;
                return;
            }

            var productName = apiClient.GetLineItemsByProductIdsAsync(new[] { ujFoglalas.ProductBvin })
                .GetAwaiter()
                .GetResult()
                .OrderByDescending(lineItem => lineItem.LastUpdated)
                .Select(lineItem => lineItem.ProductName)
                .FirstOrDefault();

            textBox10.Text = string.IsNullOrWhiteSpace(productName)
                ? ujFoglalas.ProductBvin.ToString()
                : productName;
        }

        private string GenerateNextBookingReference()
        {
            return apiClient.GetNextBookingReferenceAsync().GetAwaiter().GetResult();
        }

        private void SetLocationFromProductBvin()
        {
            var location = GetLocationByProductBvin(ujFoglalas.ProductBvin);
            if (location == null)
            {
                return;
            }

            ujFoglalas.Lokacio = location;
            textBox4.Text = location;
        }

        private void ProductBvin_Leave(object? sender, EventArgs e)
        {
            if (Guid.TryParse(textBox10.Text.Trim(), out var productBvin))
            {
                ujFoglalas.ProductBvin = productBvin;
                SetLocationFromProductBvin();
                bindingSource1.ResetBindings(false);
                SetProductTextBoxFromCurrentProduct();
            }
        }

        private string? GetLocationByProductBvin(Guid productBvin)
        {
            if (productBvin == Guid.Empty)
            {
                return null;
            }

            var sku = apiClient.GetProductsAsync(productBvin.ToString())
                .GetAwaiter()
                .GetResult()
                .FirstOrDefault(product => product.Bvin == productBvin)
                ?.Sku;

            return GetLocationBySku(sku);
        }

        private static string? GetLocationBySku(string? sku)
        {
            if (string.IsNullOrWhiteSpace(sku))
            {
                return null;
            }

            sku = sku.Trim().ToUpperInvariant();

            var maldivMatch = Regex.Match(sku, @"^MALDIV-(\d{3})$");
            if (maldivMatch.Success &&
                int.TryParse(maldivMatch.Groups[1].Value, out var maldivNumber) &&
                maldivNumber >= 1 && maldivNumber <= 240)
            {
                return "Maldív-szigetek";
            }

            var milanoMatch = Regex.Match(sku, @"^MILANO(\d{2})$");
            if (milanoMatch.Success &&
                int.TryParse(milanoMatch.Groups[1].Value, out var milanoNumber) &&
                milanoNumber >= 1 && milanoNumber <= 7)
            {
                return "Milánó";
            }

            var isztambulMatch = Regex.Match(sku, @"^ISZTAMBUL(\d{2})$");
            if (isztambulMatch.Success &&
                int.TryParse(isztambulMatch.Groups[1].Value, out var isztambulNumber) &&
                isztambulNumber >= 1 && isztambulNumber <= 6)
            {
                return "Isztambul";
            }

            return null;
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();

            ujFoglalas.Status = checkBox1.Text.Trim();
            ujFoglalas.CancellationReason = textBox12.Text.Trim();
            ujFoglalas.IsCancelled = checkBox1.Checked;

            //if (!ValidateCancellationFields(out var cancellationValidationMessage))
            //{
            //    MessageBox.Show(cancellationValidationMessage, "Hiányzó törlési adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (ValidateChildren() && ujFoglalas.ProductBvin != Guid.Empty)
            {
                this.DialogResult = DialogResult.OK;

            }
        }

        //private bool ValidateCancellationFields(out string message)
        //{
        //    var statusIsCancelled = string.Equals(checkBox1.Text.Trim(), "Cancelled", StringComparison.OrdinalIgnoreCase);
        //    var isCancelledChecked = checkBox1.Checked;
        //    var hasCancellationReason = !string.IsNullOrWhiteSpace(textBox12.Text);

        //    if (!statusIsCancelled && (isCancelledChecked || hasCancellationReason))
        //    {
        //        message = "Ha törölt/lemondott foglalást rögzítesz, a státuszt Cancelled értékre kell állítani.";
        //        return false;
        //    }

        //    if (statusIsCancelled && !isCancelledChecked)
        //    {
        //        message = "Cancelled státusznál az IsCancelled jelölőnégyzetet be kell pipálni.";
        //        return false;
        //    }

        //    if (statusIsCancelled && !hasCancellationReason)
        //    {
        //        message = "Cancelled státusznál a Törlés oka mezőt ki kell tölteni.";
        //        return false;
        //    }

        //    message = string.Empty;
        //    return true;
        //}
    }
}



