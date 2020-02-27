using System;

namespace FlowControl
{
    class Program
    {
        public static int Age;

        

        static void Main(string[] args)
        {

            Console.WriteLine("Podaj swój wiek: ");
            Age = int.Parse(Console.ReadLine());
            string test = Age > 18 ? "pełnoletni" : "Dziecko";
            Console.WriteLine(test);

            //Console.WriteLine("Podaj swój wiek: ");
            //Age= int.Parse(Console.ReadLine());

            //if (Age <=10)
            //{
            //    Method1();
            //}
            //else if (Age < 18)
            //{
            //    Method2();
            //}
            //else if (Age < 30)
            //{
            //    Method3();
            //}
            //else
            //{
            //    Method4();
            //}

            Console.ReadKey();
                }

        private static void Method4()
        {
            Console.WriteLine($"Jesteś starym koniem masz {Age}");
        }

        private static void Method3()
        {
            Console.WriteLine($"Już jesteś pełnoletni masz {Age}");
        }

        private static void Method2()
        {
            Console.WriteLine($"Jeszcze jesteś niepełnoletni masz{Age}");
        }

        private static void Method1()
        {
            Console.WriteLine($"Masz tylko 10 lub mniej lat {Age}");
        }

        
    }
}
