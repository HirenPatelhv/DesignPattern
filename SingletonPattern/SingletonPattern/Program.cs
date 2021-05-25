using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //**************************************************** Lazy Intilization ********************************************
            //Using Simple Implimentation\
            Console.WriteLine("******  Using Simple Implimentation  ******");
            PrintMessage("Hiren");
            PrintMessage("Tushar");


            //Using Simple Implimentation in thread
            Console.WriteLine("\n\n******  Using Simple Implimentation in thread  ******");
            Parallel.Invoke(() => PrintMessageThred("Hiren"), () => PrintMessageThred("Tushar"));


            //Using Simple Implimentation in thread-safe
            Console.WriteLine("\n\n******  Using Simple Implimentation in thread safe ******");
            Parallel.Invoke(() => PrintMessageThredSafe("Hiren"), () => PrintMessageThredSafe("Tushar"));


            //Using Simple Implimentation in thread-safe with Eager intilization
            Console.WriteLine("\n\n******  Using Simple Implimentation in thread with eager initilization ******");
            Parallel.Invoke(() => PrintMessageThredSafeEager("Hiren"), () => PrintMessageThredSafeEager("Tushar"));


            //Using Simple Implimentation in thread-safe with Eager Lazy intilization
            Console.WriteLine("\n\n******  Using Simple Implimentation in thread with eager Lazy initilization ******");
            Parallel.Invoke(() => PrintMessageThredSafeEagerLazy("Hiren"), () => PrintMessageThredSafeEagerLazy("Tushar"));
        }

        private static void PrintMessage(string name)
        {
            Singletone singletone = Singletone.GetInstance();
            Console.WriteLine(singletone.PrintInformation(name));
        }

        private static void PrintMessageThred(string name)
        {
            SingletoneThread singletonethread = SingletoneThread.GetInstance();
            Console.WriteLine(singletonethread.PrintInformation(name));
        }

        private static void PrintMessageThredSafe(string name)
        {
            SingletoneThreadSafe singletonethread = SingletoneThreadSafe.GetInstance();
            Console.WriteLine(singletonethread.PrintInformation(name));
        }

        private static void PrintMessageThredSafeEager(string name)
        {
            SingletoneEager singletonethread = SingletoneEager.GetInstance();
            Console.WriteLine(singletonethread.PrintInformation(name));
        }
        private static void PrintMessageThredSafeEagerLazy(string name)
        {
            SingletoneEagerLazy singletonethread = SingletoneEagerLazy.GetInstance();
            Console.WriteLine(singletonethread.PrintInformation(name));
        }
    }
}
