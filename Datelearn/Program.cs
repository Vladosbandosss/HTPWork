using System;

namespace Datelearn
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.Date + " " + now.Hour + " " + now.Minute);

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newdt = dt.AddDays(1);
            Console.WriteLine(newdt);
            TimeSpan ts = now - dt;
            Console.WriteLine(ts.Days);
           TimeSpan test = now.Subtract(newdt);
            Console.WriteLine(now.Subtract(newdt));
        }
    }
}
