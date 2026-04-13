namespace Exercice_7_Prog_Metho
{
    internal class Program
    {
        static string test = "patate OR has:document AND after:2026/4/10 AND before:2026/4/28 AND test";
        
        static void Main(string[] args)
        {
            List<Courriel> couriels = [];
            couriels.Add(new Courriel("patate", DateTime.Now, false));
            couriels.Add(new Courriel("", DateTime.Now, true));
            couriels.Add(new Courriel("", DateTime.Now, false));
            couriels.Add(new Courriel("test", DateTime.Today, true));
            couriels.Add(new Courriel("test", DateTime.Today, false));
            couriels.Add(new Courriel("test", DateTime.Today, false));
            Filtre filtre = new(test);
            List<Courriel> passFiltre = [];
            foreach (var couriel in couriels)
            {
                if (filtre.Filtrer(couriel))
                {
                    passFiltre.Add(couriel);
                }
            }
            Console.WriteLine(passFiltre.Count);
        }
    }
}
