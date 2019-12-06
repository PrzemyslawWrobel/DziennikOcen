using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook
{
    class Diary
    {
        /// <summary>
        /// konstruktor ma taką samą nazwę jak nazwa klasy, może być ich wiele ale muszą się różnić przekazanymi argumentami lub typami
        /// </summary>
        public Diary()
        {
            ratings = new List<float>();
        }
        //stan (zmienne - pola)
        List<float> ratings;

        //zachowania

        /// <summary>
        /// Dodaje ocenę rating do listy ocen ratings
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        /// <summary>
        /// Oblicza średnią z ocen z listy
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0;
            float avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();
            return avg;
        }

        /// <summary>
        /// Metoda zwraca najwyższą ocenę z listy
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {

            return ratings.Max();
        }

        /// <summary>
        /// Metoda zwraca najniższą ocenę z listy
        /// </summary>
        /// <returns></returns>
        public float GiveMinRatin()
        {
            return ratings.Min();
        }
    }
}
