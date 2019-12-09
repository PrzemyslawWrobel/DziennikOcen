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

            DiaryStatistics stats = diary.ComputeStatistics();
            //var avg = stats.Av
            Console.WriteLine("średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("MAX ocena: "  + stats.MaxGrade);
            Console.WriteLine("Min ocena: " + stats.MinGrade);

        }
    }
}
