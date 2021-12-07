using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector m1 = new MyVector(1.5f, 2);

            MyVector v2 = new MyVector()
            {
                [0] = 1.3f,
                [1] = -10
            };

            Console.WriteLine($"X= {m1[0]} | Y= {m1[1]}");

            Console.WriteLine($"X= {v2["A"]} | Y= {v2["y"]}");



            
        }
    }
}
