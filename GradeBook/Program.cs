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
            
            //pętla do pobierania ocen wpisywanych w konsoli przez użytkownika
            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu od 1 do 10. Liczba 11 kończy działanie programu.");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);


                if (rating == 11)
                {
                    break;
                }
                if (result)
                {
                    if(rating >= 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba. Podaj liczbę z zakresu 0,0 - 10,0");
                    }
                    
                }
            }
            Console.WriteLine("średnia twoich ocen to :" + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to :" + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to :" + diary.GiveMinRatin());
            Console.ReadKey();
        }
    }
}
