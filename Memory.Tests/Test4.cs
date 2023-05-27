using System;
using System.Threading;
namespace ConsoleApp4
{
    public class Program
    {
        public static void Memoryleak()
        {
            while (true)
            {
                Thread thread = new Thread(new ThreadStart(StartThread));
                thread.Start();
            }
        }
        public static void StartThread()
        {
            Console.WriteLine("Thread " +
            Thread.CurrentThread.ManagedThreadId + " started");
            Thread.CurrentThread.Join();
        }
    }
}