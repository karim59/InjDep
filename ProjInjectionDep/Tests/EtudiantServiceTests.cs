using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjInjectionDep.Interface;

namespace UnitTestProject1
{
    [TestClass]
    public class EtudiantServiceTests
    {      
        [TestMethod]
        public void GetDouble_AvecValeur3_Retourne6()
        {
            Mock<IEtudiantService> chk = new Mock<IEtudiantService>();
            IEtudiantService foo = chk.Object;

            chk.Setup(x => x.GetDouble(51)).Returns(10);
            var etudiantService = new Moq.Mock<IEtudiantService>();
            etudiantService.Setup(m => m.GetDouble(6)).Returns(6);
            
          //  Assert.AreEqual(obje.insertEmployee(chk.Object), true);
        }
    }
}
