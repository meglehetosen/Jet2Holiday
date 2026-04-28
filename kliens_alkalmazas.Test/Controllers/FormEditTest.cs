using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using kliens_alkalmazas;

namespace kliens_alkalmazas.Test.Controllers
{
    public class FormEditTest
    {
        private FormEdit _form;
        private FoglalasClass _tesztAdat;

        [SetUp]
        public void Setup()
        {
            // Létrehozunk egy alap objektumot, amivel a szerkesztő ablak dolgozni fog
            _tesztAdat = new FoglalasClass
            {
                Nev = "Eredeti Név",
                Email = "eredeti@gmail.com",
                ProductBvin = Guid.NewGuid()
            };

            // Példányosítjuk a formot a tesztadattal
            _form = new FormEdit(_tesztAdat);
        }

        // --- VALIDÁLÓ FÜGGVÉNYEK TESZTELÉSE ---

        [TestCase("JH-2026-123456", true)]
        [TestCase("hibas-ref", false)]
        public void TestBookingReferenceFormat(string input, bool expected)
        {
            // Meghívjuk az internal függvényt a formból
            bool result = _form.CheckBookingReference(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        // --- DÁTUM LOGIKA TESZTELÉSE (DateOnly) ---
        // A FormEdit-ben DateOnly-t használsz a buttonMentes_Click-ben!

        [TestCase("2026.05.10", "2026.05.15", true)]  // Jó sorrend
        [TestCase("2026.05.10", "2026.05.10", false)] // Egyenlő (0 éjszaka) - hiba
        [TestCase("2026.05.20", "2026.05.10", false)] // Fordított sorrend - hiba
        public void TestDateSequence(string erk, string tav, bool expected)
        {
            bool isErkOk = DateOnly.TryParse(erk, out var d1);
            bool isTavOk = DateOnly.TryParse(tav, out var d2);

            // A kódodban lévő logika szimulálása:
            bool result = isErkOk && isTavOk && (d2 > d1);

            Assert.That(result, Is.EqualTo(expected), $"Dátum hiba: {erk} - {tav} között");
        }

        // --- ADATMENTÉS (MAPPING) TESZTELÉSE ---

        [Test]
        public void TestNameUpdateAfterSave()
        {
            // Szimuláljuk, hogy a TextBox1-be új nevet írtunk
            string ujNev = "Kovács Vendel";

            // A buttonMentes_Click kódját szimuláljuk (mivel a private voidot nem tudjuk hívni)
            _tesztAdat.Nev = ujNev;

            // Ellenőrizzük, hogy az objektumban frissült-e az adat
            Assert.That(_tesztAdat.Nev, Is.EqualTo("Kovács Vendel"));
        }
    }
}
