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

         
            diary = new Diary();
            diary.AddRating(8);
        }
    }
}
