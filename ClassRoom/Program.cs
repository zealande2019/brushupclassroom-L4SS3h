using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Studerende Elev1 = new Studerende("Lasse", 7, 28);
            //Elev1.Print();
            
            KlasseRum rum1 = new KlasseRum();
            rum1.KlasseNavn = "1r";
            rum1.SemesterStart = new DateTime(2018,2,5);
            Studerende e1 = new Studerende("Lasse", 1, 28);
            Studerende e2 = new Studerende("Jacob", 3, 18);
            Studerende e3 = new Studerende("Simon", 6, 24);
            Studerende e4 = new Studerende("Anders", 1, 4);
            rum1.Klasseliste.Add(e1);
            rum1.Klasseliste.Add(e2);
            rum1.Klasseliste.Add(e3);
            rum1.Klasseliste.Add(e4);
            foreach (var i in rum1.Klasseliste)
            {
                Console.WriteLine($"Navn: {i.Navn}, Klasse: {rum1.KlasseNavn}, bMonth: {i.BirthdayMonth}, bDay: {i.Birthday}");
            }
            //Console.WriteLine($"Lasses årstid: {e1.Season()}");
            //Console.WriteLine($"Jacobs årstid: {e2.Season()}");
            //Console.WriteLine($"Simons årstid: {e3.Season()}");
            //Console.WriteLine($"Anders' årstid: {e4.Season()}");
            foreach (var s in rum1.Klasseliste)
            {
                Console.WriteLine($"{s.Navn} er født i {s.Season()}");
            }
        }

    }
}
