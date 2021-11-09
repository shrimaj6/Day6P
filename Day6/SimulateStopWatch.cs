using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Day6
{
    public class SimulateStopwatch
    {
        public void startStopWatch()
        {
            ////Console.WriteLine("Enter start to start stopwatch: ");
            //string st1 = Console.ReadLine();
            //Stopwatch watch = null;
            Stopwatch stopwatch = new Stopwatch();//Stopwatch here is a pre-defined class
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(5);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed time:{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            //if(st1.Equals("start"))
            //{
            //    new Stopwatch();
            //    watch.Start();
            //}
            //Console.WriteLine("Enter end to end stopwatch");
            //string str2=Console.ReadLine();
            //if(str2.Equals("stop"))
            //{
            //    watch.Stop();
            //}

        }
    }
}