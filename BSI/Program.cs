using System;
using System.Collections;
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
            triangle2();

            Woman w2 = new Woman("2", "2", 2);
            Woman w3 = new Woman("3", "3", 2);

            Console.WriteLine(w2.Equals(w3));
            ArrayList arr = new ArrayList();
            arr.Add(w1);
            arr.Add(m1);
            arr.Add(w3);
            arr.Add(w2);

            foreach (Person p in arr) 
            {
                if (p.Equals(w2)) 
                {
                    Console.WriteLine("Yes");
                }
                else 
                {
                    Console.WriteLine("No");
                }
            }



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
                int star = 5;
                int i, k;
                for (i = 1; i < val; i++)
                {
                    for (k = 1; k < star; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                star--;
                     
                }
                Console.ReadLine();
            

        }
    }
}
