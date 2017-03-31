using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProjectThomas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            homme UnHomme1 = new homme(1, "courtine", "jerome", new DateTime(1968, 1, 18));
            homme UnHomme2 = new homme(1, "correge", "thomas", new DateTime(2015, 1, 18));
            femme UneFemme1 = new femme(3, "mothe", "josianne", new DateTime(1967, 4, 1), 100);
            Assert.AreEqual(UnHomme1.EstMajeur(), true);
            Assert.AreEqual(UnHomme2.EstMajeur(), false);
            tribu Matribu = new tribu();
            Matribu.AjouterMembre(UnHomme1);
            Matribu.AjouterMembre(UnHomme2);
            Matribu.AjouterMembre(UneFemme1);
            Assert.AreEqual(Matribu.NBFemmes(), 1);
        }
    }
}
