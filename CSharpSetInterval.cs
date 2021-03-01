using System;
using System.Collections.Generic;
using System.Timers;

namespace ConsoleApp3
{
    class Program
    {
        private static int count;

        static void Main(string[] args)
        {
            Timer aTimer2s = new Timer();
            aTimer2s.Interval = 2000;
            Timer aTimer1s = new Timer();
            aTimer1s.Interval = 1000;
            Timer aTimer_5s = new Timer();
            aTimer_5s.Interval = 500;
            Timer aTimer3s = new Timer();
            aTimer3s.Interval = 3000;

            // Hook up the Elapsed event for the timer. 
            aTimer2s.Elapsed += OnTimedEvent;
            aTimer1s.Elapsed += OnTimedEvent;
            aTimer_5s.Elapsed += OnTimedEvent;
            aTimer3s.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer2s.AutoReset = true;
            aTimer1s.AutoReset = true;
            aTimer_5s.AutoReset = true;
            aTimer3s.AutoReset = true;

            // Start the timer
            aTimer2s.Enabled = true;
            aTimer1s.Enabled = true;
            aTimer_5s.Enabled = true;
            aTimer3s.Enabled = true;

            Console.WriteLine("證明沒有被卡住... ");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("證明沒有被卡住... end");
            Console.ReadLine();
        }

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            var even = (Timer)sender;
            if (even.Interval == 3000)
            {
                count++;
                if (count == 3)
                {
                    Console.WriteLine($"at throw Exception");
                    throw new Exception("test");
                }
            }

            Console.WriteLine($"at {e.SignalTime}___{even.Interval}");
        }
    }
}
