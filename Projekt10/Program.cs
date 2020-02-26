using System;

namespace Projekt10
{
    class Program
    {
        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "Nowy Dziennik Babuni";

           
        }

        static int IncrementNumber( int number)
        {
            number = number + 42;
            return number;
        }
        static void Main(string[] args)
        {
            // PassyByValueAnnRef();

            Immutable();
            EqualStrings();
            AddDaysToDate();


            //Diary diary = new Diary();
            //diary.AddRating(3);
            //diary.AddRating(5);
            //diary.AddRating(3.3f);
            //diary.AddRating(5.9f);

            //Console.WriteLine(Diary.MaxGrade);
            //Diary diary1 = new Diary();
            //Diary diary11 = new Diary();
            //Diary diary111 = new Diary();
            //Diary diary2 = new Diary();

            //Diary diary22 = new Diary();

            //Console.WriteLine(Diary.Count);

            //DiaryStatistics stats = diary.ComputeStatistics();
            ////var avg = stats.Av
            //Console.WriteLine("średnia ocena: " + stats.AverageGrade);
            //Console.WriteLine("MAX ocena: "  + stats.MaxGrade);
            //Console.WriteLine("Min ocena: " + stats.MinGrade);



            Console.ReadLine();
        }

        private static void AddDaysToDate()
        {
            DateTime date = new DateTime(2020, 2,26);
            DateTime newDate = date.AddHours(45);
            Console.WriteLine(newDate);
        }

        private static void EqualStrings()
        {
            string name1 = "Marcin";
            string name2 = "marcin";
            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);
            
        }

        private static void Immutable()
        {
            string name = " Marcin ";
            string newName = name.Trim();
            Console.WriteLine(newName);
        }

        private static void PassyByValueAnnRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);
            // d1 = new Diary();
            //d1.Name = "Dziennik Marcina";
            Console.WriteLine(d2.Name);

            int x1 = 6;
            Console.WriteLine(x1);
            int x2;
            x2 = IncrementNumber(x1);

            Console.WriteLine(x2);
        }
    }
}
