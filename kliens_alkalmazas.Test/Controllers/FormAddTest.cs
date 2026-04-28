using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using kliens_alkalmazas;

namespace kliens_alkalmazas.Test.Controllers
{
    public class FormAddTest
    {
        private FormAdd _form;

        [SetUp]
        public void Setup()
        {
            _form = new FormAdd(null);
        }

        // 1. Üres név mező tesztelése
        [TestCase("Kovács János", true)]
        [TestCase("", false)]
        [TestCase(null, false)]
        public void TestCheckEmpty(string nev, bool expected)
        {
            bool result = _form.CheckEmpty(nev);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 2. Email validálás tesztelése
        [TestCase("teszt@gmail.com", true)]
        [TestCase("hibas.email.com", false)]
        [TestCase("valami@", false)]
        [TestCase("@domain.hu", false)]
        public void TestCheckEmail(string email, bool expected)
        {
            bool result = _form.CheckEmail(email);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 3. Telefonszám tesztelése (+36XXXXXXXXX)
        [TestCase("+36301234567", true)]
        [TestCase("06301234567", false)]
        [TestCase("+3630123", false)]    
        [TestCase("abc123456789", false)]
        public void TestCheckPhoneNumber(string telefon, bool expected)
        {
            bool result = _form.CheckPhoneNumber(telefon);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 4. Éjszakák száma tesztelése (1-19 között)
        [TestCase("1", true)]
        [TestCase("10", true)]
        [TestCase("19", true)]
        [TestCase("0", false)]
        [TestCase("20", false)]
        [TestCase("alma", false)]
        public void TestCheckEjszakak(string input, bool expected)
        {
            bool result = _form.CheckEjszakak(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 5. Foglalási referencia tesztelése (JH-XXXX-XXXXXX)
        [TestCase("JH-2024-123456", true)]
        [TestCase("JH-24-12345", false)]      
        [TestCase("ABC-2024-123456", false)] 
        [TestCase("JH-asdf-asdfgh", false)]
        public void TestCheckBookingReference(string refNum, bool expected)
        {
            bool result = _form.CheckBookingReference(refNum);
            Assert.That(result, Is.EqualTo(expected));
        }

        // 6. Vendégszám csak szám tesztelése
        [TestCase("1", true)]
        [TestCase("5", true)]
        [TestCase("99", true)]
        [TestCase("a", false)]
        [TestCase("", false)]
        public void TestCheckVendegszam(string vendeg, bool expected)
        {
            bool result = _form.CheckVendegszam(vendeg);
            Assert.That(result, Is.EqualTo(expected));
        }

        // textBox5 és textBox6 (érkezés és távozás dátuma) összehasonlításának tesztelése
        [TestCase("2024.05.01", "2024.05.05", true)]  // Normál eset
        [TestCase("2024.05.05", "2024.05.01", false)] // Fordított dátumok - HIBA
        [TestCase("2024.05.01", "2024.05.01", false)] // Egynapos (0 éjszaka) - HIBA (a kódod szerint)
        [TestCase("nem_dátum", "2024.05.01", false)]  // Hibás formátum
        public void TestDateComparisonLogic(string erk, string tav, bool expected)
        {
            // A FormAdd-ban lévő DateTime.TryParse és az if (erkezes >= tavozas) logikát szimuláljuk
            bool isValid = DateTime.TryParse(erk, out DateTime erkezes) &&
                           DateTime.TryParse(tav, out DateTime tavozas) &&
                           erkezes < tavozas;

            Assert.That(isValid, Is.EqualTo(expected));
        }
    }
}

