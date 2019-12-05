using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            //inicjalizacja nowej listy ocen 
            //Diary - to jest typ listy szablon do tworzenia nowych obiektów
            //diary - to jest nazwa tworzonej listy
            Diary diary = new Diary();
            //diary.AddRating(5.0f);
            //diary.AddRating(8.5f);

            //diary.AddRating(4.5f);

            //diary.AddRating(3.7f);
            //diary.AddRating(1.5f);
            //diary.AddRating(5.9f);

            //float avg =  diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRatin();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu od 1 do 10");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);


                if (rating == 11)
                {
                    break;
                }
                if (result)
                {
                    diary.AddRating(rating);
                }
            }
            Console.WriteLine("średnia twoich ocen to :" + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to :" + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to :" + diary.GiveMinRatin());
            Console.ReadKey();
        }
    }
}
