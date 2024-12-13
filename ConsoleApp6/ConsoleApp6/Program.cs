using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public delegate void telega(object obj);
        object obj = new object();
        static void Main(string[] args)
        {
            Program program = new Program();
            Thread thread = new Thread(() => program.Main1());
            Thread thread1 = new Thread(() => program.Main1());
            thread.Start();
            thread1.Start();
            Console.ReadKey();
        }
        void Main1()
        {
            bool Lock = false;
            try
            {
                Monitor.Enter(obj, ref Lock);
                for (int i = 0; i < 1000; i++)
                {
                    
                    Console.WriteLine(i);
                }
            }
            finally
            {
                if (Lock)
                {
                    Monitor.Exit(obj);
                }
               
            }

            //lock (obj)
            //{
                
            //}
        }
    }
}
