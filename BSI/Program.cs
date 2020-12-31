using System;

namespace BSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Denis", "Denisenko");

            Woman w1 = new Woman("Nadia", "Housysy", 5);

            Console.WriteLine(w1.ToString());
        }
    }
}
