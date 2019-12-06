using System;

namespace Construktors
{
    class Program
    {
        static void Main(string[] args)
        {
            // konstruktory przeciążone ilością parametrów przekazanych w konstruktorze
            Person person = new Person();
            Person person2 = new Person(1, "Tomek");
            Person person3 = new Person(2, "BlaBla", "OLO");
            Person person4 = new Person(3, "OLA", "Tola", "Warszawa", 16, "women");

        }
    }
}
