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
            DziałaniaNaTablicach();
            // PassyByValueAnnRef();

            //Immutable();
            //EqualStrings();
            //AddDaysToDate();


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

        private static void DziałaniaNaTablicach()
        {
            
            int[] scores = new int[5];

            AddRatings(scores);


            int totalscore = 0;

            foreach (var score in scores)
            {
                Console.WriteLine(score);
                totalscore += score;
            }

            //double average = ;
           Console.WriteLine(totalscore);
        }

        private static void AddRatings(int[] scores)
        {
            if (scores.Length >= 4)
            {
                scores[0] = 4;
                scores[1] = 2;
                scores[2] = 3;
                scores[3] = 5;
                scores[4] = 1;
            }
            //scores[5] = 1;
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
