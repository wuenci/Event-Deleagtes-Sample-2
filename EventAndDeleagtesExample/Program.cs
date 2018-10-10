using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDeleagtesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            c.SchwellwertErreicht += c_SchwellwertErreicht;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        private static void c_SchwellwertErreicht(object sender, EventArgs e)
        {
            Console.WriteLine("Die Schwelle wurde ereicht");
            Environment.Exit(0);
        }
    }
}
