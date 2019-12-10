using System;

namespace Projekt10
{
    class Program
    {
        static void Main(string[] args)
        {


            Diary diary = new Diary();
            diary.AddRating(3);
            diary.AddRating(5);
            diary.AddRating(3.3f);
            diary.AddRating(5.9f);

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
            Diary d1 = new Diary();
            Diary d2 = d1;
             d1 = new Diary();
            d1.Name = "Dziennik Marcina";
            Console.WriteLine(d2.Name);

            int x1 = 4;
            int x2 = x1;
            x1 = 100;
            Console.WriteLine(x2);


        }
    }
}
