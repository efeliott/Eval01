using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {
            Utilitaire u1 = new Utilitaire(80, 60, 150, "EV-505-HK", "diesel", 50);
            int expected = 20;
            Assert.AreEqual(expected, u1.ChargeUtile());
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            Utilitaire u1 = new Utilitaire(80, 60, 150, "EV-505-HK", "diesel", 50);
            u1.AjouterEntretien(new Entretien(new DateTime(2022, 08, 08), 2500, "RAS"));
            Assert.AreEqual(true, u1.PrevoirEntretien());

            Utilitaire u2 = new Utilitaire(80, 60, 150, "EV-505-HK", "diesel", 50);
            u2.AjouterEntretien(new Entretien(new DateTime(2020, 08, 08), 2500, "Prévoir un entretien du vehicule"));
            Assert.AreEqual(false, u2.PrevoirEntretien());
        }
    }
}