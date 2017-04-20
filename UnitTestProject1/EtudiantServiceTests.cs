using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjInjectionDep.Interface;

namespace UnitTestProject1
{
    [TestClass]
    public class EtudiantServiceTests
    {
        private readonly IEtudiantService etudiantService;

        public EtudiantServiceTests(IEtudiantService etudiantService)
        {
            this.etudiantService = etudiantService;
        }

        public EtudiantServiceTests()
        {
            
        }


        [TestMethod]
        public void GetDouble_AvecValeur3_Retourne6()
        {
            int valeur = 3;
            int resultat = etudiantService.GetDouble(valeur);
            Assert.AreEqual(6, resultat);
        }
    }
}
