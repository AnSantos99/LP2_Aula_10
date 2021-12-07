using System;
using System.Threading;

namespace Threads
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Thread thread1 = new Thread(CountTo250);
            //thread1.Start();
            //Thread thread2 = new Thread(CountTo250);
            //thread2.Start();
            //thread1.Join();
            //thread2.Join();

            Thread thread = new Thread(CountToNumber);
            thread.Start(50);

            
        }

        public static void CountToNumber(object input) 
        {
            int n = (int)input;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(n + 1);
            }
        }

        private static void CountTo250()
        {
            
            for (int index = 0; index < 250; index++) 
            {
                Console.WriteLine(index + 1);

                Console.WriteLine("{0} : ", Thread.CurrentThread.Name);
            }
                
        }
    }
}
