using kliens_alkalmazas.Models;
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

namespace kliens_alkalmazas
{
    public partial class FormEdit : Form
    {
        Models.Jet2HolidaySqldbContext jet2HolidayContext = new Models.Jet2HolidaySqldbContext();

        public FoglalasClass ujFoglalas = new();

        public FormEdit(FoglalasClass uj)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            ujFoglalas = uj ?? new FoglalasClass();

            Load += FormAdd_Load;

            buttonMentes.DialogResult = DialogResult.None;
            buttonMentes.Click += buttonMentes_Click;
            buttonSearchProductbvin.Click += buttonSearchProductbvin_Click;
            buttonSearchOrderbvin.Click += buttonSearchOrderbvin_Click;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            textBox1.Text = ujFoglalas.Nev ?? string.Empty;
            textBox2.Text = ujFoglalas.Email ?? string.Empty;
            textBox3.Text = ujFoglalas.Telefon ?? string.Empty;
            textBox4.Text = ujFoglalas.Lokacio ?? string.Empty;
            textBox5.Text = ujFoglalas.ErkezesDatum == default ? string.Empty : ujFoglalas.ErkezesDatum.ToString("yyyy.MM.dd");
            textBox6.Text = ujFoglalas.TavozasDatum == default ? string.Empty : ujFoglalas.TavozasDatum.ToString("yyyy.MM.dd");
            textBox7.Text = ujFoglalas.VendegSzam?.ToString() ?? string.Empty;
            textBox8.Text = ujFoglalas.LetrehozasDatuma?.ToString("yyyy.MM.dd") ?? string.Empty;
            textBox9.Text = ujFoglalas.Status ?? string.Empty;
            textBox10.Text = ujFoglalas.ProductBvin == Guid.Empty ? string.Empty : ujFoglalas.ProductBvin.ToString();
            textBox11.Text = ujFoglalas.OrderBvin?.ToString() ?? string.Empty;
            textBox12.Text = ujFoglalas.CancellationReason ?? string.Empty;
            textBox13.Text = ujFoglalas.BookingReference ?? string.Empty;
            textBox14.Text = ujFoglalas.EjszakakSzama?.ToString() ?? string.Empty;
            checkBox1.Checked = ujFoglalas.IsCancelled;
        }

        // REGEXEK ÉS VALIDÁLÁSOK

        private bool CheckEmpty(string név)
        {
            return !string.IsNullOrEmpty(név);
        }

        private bool CheckEmail(string Email)
        {
            Regex r = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
            return r.IsMatch(Email);
        }

        //private bool CheckDate(string ErkezesDatum, string TavozasDatum)
        //{
        //    Regex r = new Regex(@"^(0?[1-9]|1[0-2])/(0?[1-9]|[12][0-9]|3[01])/\d{4}$");
        //    return r.IsMatch(ErkezesDatum) && r.IsMatch(TavozasDatum);
        //}

        private bool CheckPhoneNumber(string Telefon)
        {
            Regex r = new Regex(@"^\+36\d{9}$");
            return r.IsMatch(Telefon);
        }

        private bool CheckEjszakak(string input)
        {
            return int.TryParse(input, out var ejszakak) && ejszakak > 0 && ejszakak < 20;
        }

        private bool CheckBookingReference(string BookingReference)
        {
            Regex r = new Regex(@"^JH-\d{4}-\d{6}$");
            return r.IsMatch(BookingReference);
        }

        private bool CheckVendegszam(string Vendegszam)
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

                bindingSource1.ResetBindings(false);
            }
        }

        private void buttonSearchOrderbvin_Click(object sender, EventArgs e)
        {
            using FormOrderBvin formOrderBvin = new FormOrderBvin();

            if (formOrderBvin.ShowDialog() == DialogResult.OK)
            {
                ujFoglalas.OrderBvin = formOrderBvin.SelectedOrder.Bvin;
                bindingSource1.ResetBindings(false);
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if (!Guid.TryParse(textBox10.Text.Trim(), out var productBvin))
            {
                MessageBox.Show("A Product bvin formátuma hibás!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateOnly.TryParse(textBox5.Text.Trim(), out var erkezes) ||
                !DateOnly.TryParse(textBox6.Text.Trim(), out var tavozas))
            {
                MessageBox.Show("Az érkezés vagy távozás dátuma hibás!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tavozas <= erkezes)
            {
                MessageBox.Show("A távozás dátuma legyen későbbi, mint az érkezés dátuma!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid? orderBvin = null;
            if (!string.IsNullOrWhiteSpace(textBox11.Text))
            {
                if (!Guid.TryParse(textBox11.Text.Trim(), out var parsedOrderBvin))
                {
                    MessageBox.Show("Az Order bvin formátuma hibás!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                orderBvin = parsedOrderBvin;
            }

            ujFoglalas.Nev = textBox1.Text.Trim();
            ujFoglalas.Email = textBox2.Text.Trim();
            ujFoglalas.Telefon = textBox3.Text.Trim();
            ujFoglalas.Lokacio = textBox4.Text.Trim();
            ujFoglalas.ErkezesDatum = erkezes;
            ujFoglalas.TavozasDatum = tavozas;
            ujFoglalas.VendegSzam = int.TryParse(textBox7.Text, out var vendeg) ? vendeg : null;
            ujFoglalas.LetrehozasDatuma = DateTime.TryParse(textBox8.Text, out var letrehozas) ? letrehozas : null;
            ujFoglalas.Status = textBox9.Text.Trim();
            ujFoglalas.ProductBvin = productBvin;
            ujFoglalas.OrderBvin = orderBvin;
            ujFoglalas.CancellationReason = textBox12.Text.Trim();
            ujFoglalas.BookingReference = textBox13.Text.Trim();
            ujFoglalas.EjszakakSzama = int.TryParse(textBox14.Text, out var ejszakak) ? ejszakak : null;
            ujFoglalas.IsCancelled = checkBox1.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
