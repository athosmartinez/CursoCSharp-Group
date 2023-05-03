using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("------------------------------------------------");

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            DateTime x = DateTime.Now;
            // DateTime y1 = x.Add(timeSpan);
            DateTime y2 = x.AddDays(2);
            DateTime y3 = x.AddHours(3);
            DateTime y4 = x.AddMilliseconds(2);
            DateTime y5 = x.AddMinutes(3);
            DateTime y6 = x.AddMonths(2);
            DateTime y7 = x.AddSeconds(3);
            DateTime y8 = x.AddTicks(90000000000000L);
            DateTime y9 = x.AddYears(12414);
            // DateTime y10= x.Subtract(timeSpan);
            // TimeSpan t = x.Subtract(dateTime);
        }
    }
}