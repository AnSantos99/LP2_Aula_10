using System;

namespace OperatorOverload
{
    public class Program
    {
        private static void Main()
        {
            // Declare and instantiate two vectors
            Vector3 v1 = new Vector3(5, 2, -1);
            Vector3 v2 = new Vector3(-1, 0, 1);

            // Show the vector values
            Console.WriteLine($"v1 = {v1.ToString()}");
            Console.WriteLine($"v2 = {v2.ToString()}");

            Console.WriteLine();

            // Show the vector magnitudes
            Console.WriteLine($"v1.Magnitude = {v1.Magnitude}");
            Console.WriteLine($"v2.Magnitude = {v2.Magnitude}");

            Console.WriteLine();

            // Sum two vectors
            Console.WriteLine($"v1 + v2 = {v1 + v2}");

            Console.WriteLine();

            // Subtract two vectors
            Console.WriteLine($"v1 - v2 = {v1 - v2}");

            Console.WriteLine();

            // Negate a vector
            Console.WriteLine($"-v1 = {-v1}");

            Console.WriteLine();

            // Multiply a vector with a scalar
            Console.WriteLine($"v1 * 3 = {v1 * 3}");

            Console.WriteLine();

            //Divide a vector with a scalar
            Console.WriteLine($"v1 / 2 = {v1 / 2}");

            Console.WriteLine();

            // Check if two vectors are equal
            Console.WriteLine($"v1 == v2? {v1 == v2}");

            Console.WriteLine();

            // Check if two vectors are different
            Console.WriteLine($"v1 != v2? {v1 != v2}");

            Console.WriteLine();

            // Relational comparison between vectors
            Console.WriteLine($"v1 >  v2? {v1 > v2}");
            Console.WriteLine($"v1 >= v2? {v1 >= v2}");
            Console.WriteLine($"v1 <  v2? {v1 < v2}");
            Console.WriteLine($"v1 <= v2? {v1 <= v2}");
        }
    }
}
