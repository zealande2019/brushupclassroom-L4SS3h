using System;

namespace ClassRoom
{
    public class Studerende
    {
        public Studerende(string navn, int birthdayMonth, int birthday)
        {
            Navn = navn;
            BirthdayMonth = birthdayMonth;
            Birthday = birthday;
            if (birthdayMonth <= 0 || birthdayMonth > 12)
            {
                throw new ArgumentException();
            }
        }

        public string Navn { get; }

        public int BirthdayMonth { get; }

        public int Birthday { get; }

        public string Season()
        {
            if (BirthdayMonth == 1 || BirthdayMonth == 2 || BirthdayMonth == 12)
            {
                Console.WriteLine("Vinter");
            }
            if (BirthdayMonth == 3 || BirthdayMonth == 4 || BirthdayMonth == 5)
            {
                Console.WriteLine("Forår");
            }
            if (BirthdayMonth == 6 || BirthdayMonth == 7 || BirthdayMonth == 8)
            {
                Console.WriteLine("Sommer");
            }
            else
            {
                Console.WriteLine("Efterår");
            }
            //return null da metode ikke længere er void.
            return null;



        }
        //public void Print()
        //{
        //    Console.WriteLine($"{Navn}, {Birthday}, {BirthdayMonth}");
        //}
    }
}