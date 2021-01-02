using System;

namespace BSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Denis", "Denisenko");

            Woman w1 = new Woman("Nadia", "Housysy", 5);

            Man m1 = new Man("Denis", "Denisenko", 100);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(w1.ToString());
            Console.WriteLine(m1.ToString());
        }
    }
}
