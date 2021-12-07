using System;
using System.Threading;
using System.Collections.Concurrent;

namespace InputSystem
{
    public class Program
    {
        // Coleção thread-safe, usa internamente uma Queue (primeira tecla a
        // entrar é a primeira a sair)
        //--> Declarar coleção thread-safe aqui
        private static BlockingCollection<ConsoleKey> blockingCollection;

        private static void Main()
        {
            Thread producer = new Thread(ReadKeys);
            Thread consumer = new Thread(ShowKeyOnScreen);

            //--> Inicializar coleção thread-safe aqui
            blockingCollection = new BlockingCollection<ConsoleKey>();

            Console.WriteLine("Podes começar a carregar nas teclas");

            //--> Código para começar execução das threads aqui
            producer.Start();
            consumer.Start();

            //--> Código para esperar que as threads terminem aqui
            producer.Join();
            consumer.Join();

            Console.WriteLine("Obrigado!");
        }

        // Método produtor:
        // Lé as teclas do teclado e coloca-as na fila
        private static void ReadKeys()
        {
            //--> Completa este código
            ConsoleKey key;

            do
            {
                key = Console.ReadKey(true).Key;
                blockingCollection.Add(key);

            }while(key != ConsoleKey.Escape);


        }

        // Método consumidor:
        // Obtém/retira as teclas da fila, e apresenta informação no ecrã
        private static void ShowKeyOnScreen()
        {
            //--> Completa este código
            ConsoleKey key;

            while((key = blockingCollection.Take())!= ConsoleKey.Escape)
            {
                if(key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                    Console.WriteLine("Cima");

                if(key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                    Console.WriteLine("Baixo");

                if(key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                    Console.WriteLine("Esquerda");

                if(key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                    Console.WriteLine("Direita");
            }
        }
    }
}