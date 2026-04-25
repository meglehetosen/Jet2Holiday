using kliens_alkalmazas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kliens_alkalmazas
{
    public partial class FormAdd : Form
    {
        Models.Jet2HolidaySqldbContext jet2HolidayContext = new Models.Jet2HolidaySqldbContext();

        public FoglalasClass ujFoglalas = new();

        public FormAdd(FoglalasClass uj)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ujFoglalas;
        }

        // REGEXEK ÉS VALIDÁLÁSOK

        private bool CheckEmpty(string Nev, string Telefon, string Email, string Lokacio)
        {
            if (string.IsNullOrWhiteSpace(Nev) || string.IsNullOrWhiteSpace(Telefon) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Lokacio))
            {
                MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckEmail(string Email)
        {
            Regex r = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
            return r.IsMatch(Email);
        }

        private bool CheckDate(string ErkezesDatum, string TavozasDatum)
        {
            Regex r = new Regex(@"^\d{4}\.\s?\d{2}\.\s?\d{2}\.\s?$");
            return r.IsMatch(ErkezesDatum) && r.IsMatch(TavozasDatum);
        }

        private bool CheckPhoneNumber(string Telefon)
        {
            Regex r = new Regex(@"^\+36\d{9}$");
            return r.IsMatch(Telefon);
        }

        private bool CheckEjszakak(string input)
        {
            Regex r = new Regex(@"^(de|du|egesznap)$");
            return r.IsMatch(input);
        }

        private bool CheckBookingReference(string BookingReference)
        {
            Regex r = new Regex(@"^JH-\d{4}-\d{6}$");
            return r.IsMatch(BookingReference);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
