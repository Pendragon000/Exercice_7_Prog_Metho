
using Exercice_7_Lib;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestExercice_7_Prog_Metho
{
    [TestClass]
    public sealed class Test
    {
        [TestMethod]
        public void TestMethod()
        {
            List<Courriel> couriels = [];
            couriels.Add(new Courriel("patate", DateTime.Now, false));
            couriels.Add(new Courriel("", DateTime.Now, true));
            couriels.Add(new Courriel("", DateTime.Now, false));
            couriels.Add(new Courriel("", DateTime.Today, true));
            couriels.Add(new Courriel("test", DateTime.Now, true));
            couriels.Add(new Courriel("", DateTime.Today, true));
            string test = "patate OR has:document AND after:2026/4/13 AND before:2026/4/28 AND test";
            List<Courriel> passCouriel = [];
            Filtre filtre = new(test);
            foreach (var courriel in couriels)
            {
                if (filtre.Filtrer(courriel))
                {
                    passCouriel.Add(courriel);
                }
            }
            Assert.AreEqual(2, passCouriel.Count);
        }
        [TestMethod]
        public void TestMethod1()
        {
            List<Courriel> couriels = [];
            Courriel cour0 = new Courriel("patate", DateTime.Now, false);
            couriels.Add(cour0);
            couriels.Add(new Courriel("", DateTime.Now, true));
            couriels.Add(new Courriel("", DateTime.Now, false));
            couriels.Add(new Courriel("", DateTime.Today, true));
            couriels.Add(new Courriel("", DateTime.Today, true));
            couriels.Add(new Courriel("", DateTime.Today, true));
            string test = "patate OR has:document AND after:2026/4/13 AND before:2026/4/28 AND test";
            List<Courriel> passCouriel = [];
            Filtre filtre = new(test);
            foreach (var courriel in couriels)
            {
                if (filtre.Filtrer(courriel))
                {
                    passCouriel.Add(courriel);
                }
            }
            Assert.AreEqual(1, passCouriel.Count);
            Assert.IsTrue(passCouriel.Contains(cour0));
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<Courriel> couriels = [];
            Courriel cour0 = new Courriel("patate", DateTime.Parse("2024/4/20"), false);
            Courriel cour1 = new Courriel("test", DateTime.Now, true);
            couriels.Add(cour0);
            couriels.Add(cour1);
            couriels.Add(new Courriel("", DateTime.Now, false));
            couriels.Add(new Courriel("", DateTime.Today, true));
            couriels.Add(new Courriel("", DateTime.Today, true));
            couriels.Add(new Courriel("", DateTime.Today, true));
            string test = "before:2025/12/25 OR after:2026/4/13 AND before:2026/4/28 AND test";
            List<Courriel> passCouriel = [];
            Filtre filtre = new(test);
            foreach (var courriel in couriels)
            {
                if (filtre.Filtrer(courriel))
                {
                    passCouriel.Add(courriel);
                }
            }
            Assert.AreEqual(2, passCouriel.Count);
            Assert.IsTrue(passCouriel.Contains(cour0));
            Assert.IsTrue(passCouriel.Contains(cour1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<Courriel> couriels = [];
            Courriel cour0 = new Courriel("patate", DateTime.Parse("2024/4/20"), false);
            Courriel cour1 = new Courriel("patate", DateTime.Now, true);
            couriels.Add(cour0);
            couriels.Add(cour1);
            couriels.Add(new Courriel("", DateTime.Now, false));
            couriels.Add(new Courriel("", DateTime.Today, true));
            couriels.Add(new Courriel("", DateTime.Today, true));
            couriels.Add(new Courriel("", DateTime.Today, true));
            string test = "patate";
            List<Courriel> passCouriel = [];
            Filtre filtre = new(test);
            foreach (var courriel in couriels)
            {
                if (filtre.Filtrer(courriel))
                {
                    passCouriel.Add(courriel);
                }
            }
            Assert.AreEqual(2, passCouriel.Count);
            Assert.IsTrue(passCouriel.Contains(cour0));
            Assert.IsTrue(passCouriel.Contains(cour1));
        }
    }
}
