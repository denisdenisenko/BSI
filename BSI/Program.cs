using System;
using System.Linq;

namespace BSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("x", "x");

            Woman w1 = new Woman("y", "y", 5);

            Man m1 = new Man("z", "z", 100);

            Singletone s1 = new Singletone();
            s1.getInstance();
            Console.WriteLine(p1.ToString());
            Console.WriteLine(w1.ToString());
            Console.WriteLine(m1.ToString());

           // triangle();
            //triangle2();

            Woman w2 = new Woman("2", "2", 2);
            Woman w3 = new Woman("3", "3", 2);

            Console.WriteLine(w2.Equals(w3));



        }

        static void triangle() 
        {
            int numberOfStars = 5;
            String spaces = " ";
            for (int i = numberOfStars; i > 0; i--) 
            {
                Console.WriteLine( spaces + (String.Concat(Enumerable.Repeat("*", numberOfStars))) + spaces);
                numberOfStars--;
                spaces = spaces + " ";
            }

        }
        static void triangle2() 
        {
           
                int val = 5;
                int i, j, k;
                for (i = 1; i <= val; i++)
                {
                    for (j = 1; j <= val - i; j++)
                    {
                        // Console.Write(" ");  
                    }
                    for (k = 1; k <= j; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.ReadLine();
            

        }
    }
}
