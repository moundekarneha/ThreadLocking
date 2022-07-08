using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadLocking
{
    //Locking thread
    internal class Program
    {
        public void Display()
        {
            //umtill this thread is completed other thread will wait since it is acquiring the lock
            lock (this)
            {
                Console.WriteLine("Hey this is me");
                Thread.Sleep(5000);
                Console.WriteLine("What you will do to know about me");
            }
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Display();
            //p.Display();
            //p.Display();

            Thread t1 = new Thread(p.Display);
            Thread t2 = new Thread(p.Display);
            Thread t3 = new Thread(p.Display);
            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }
    }
}
