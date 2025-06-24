using System;

namespace Datetime_math_namespace
{
    class Test2
    {
        public static void not_main()
        {
            Console.WriteLine("Now: "+ DateTime.Now);
            Console.WriteLine("Date: "+ DateTime.Now.Date);
            Console.WriteLine("Day: "+ DateTime.Now.Day);
            Console.WriteLine("Month: "+ DateTime.Now.Month);
            Console.WriteLine("Year: "+ DateTime.Now.Year);
            Console.WriteLine("Hour: "+ DateTime.Now.Hour);
            Console.WriteLine("Minute: "+ DateTime.Now.Minute);
            Console.WriteLine("Second: "+ DateTime.Now.Second);

            Console.WriteLine("DayOfWeek: "+ DateTime.Now.DayOfWeek);
            Console.WriteLine("DayOfYear: "+ DateTime.Now.DayOfYear);

            Console.WriteLine("ToLongDateString: "+ DateTime.Now.ToLongDateString());
            Console.WriteLine("ToShortDateString: "+ DateTime.Now.ToShortDateString());

            Console.WriteLine("ToLongTimeString: "+ DateTime.Now.ToLongTimeString());
            Console.WriteLine("ToShortTimeString: "+ DateTime.Now.ToShortTimeString());

            Console.WriteLine("AddDays: "+ DateTime.Now.AddDays(2));
            Console.WriteLine("AddHours: "+ DateTime.Now.AddHours(2));
            Console.WriteLine("AddMinutes: "+ DateTime.Now.AddMinutes(2));
            Console.WriteLine("AddSeconds: "+ DateTime.Now.AddSeconds(2));
            Console.WriteLine("AddYears: "+ DateTime.Now.AddYears(2));
            Console.WriteLine("AddMilliseconds: "+ DateTime.Now.AddMilliseconds(2));

            // Datetime.Format
            Console.WriteLine("ToString('dd'): "+ DateTime.Now.ToString("dd"));
            Console.WriteLine("ToString('ddd'): "+ DateTime.Now.ToString("ddd"));
            Console.WriteLine("ToString('dddd'): "+ DateTime.Now.ToString("dddd"));

            Console.WriteLine("ToString('MM'): "+ DateTime.Now.ToString("MM"));
            Console.WriteLine("ToString('MMM'): "+ DateTime.Now.ToString("MMM"));
            Console.WriteLine("ToString('MMMM'): "+ DateTime.Now.ToString("MMMM"));

            Console.WriteLine("ToString('yy'): "+ DateTime.Now.ToString("yy"));
            Console.WriteLine("ToString('yyyy'): "+ DateTime.Now.ToString("yyyy"));

            // Math Library
            Console.WriteLine("Abs: "+ Math.Abs(-1));
            Console.WriteLine("Sin: "+ Math.Sin(10));
            Console.WriteLine("Cos: "+ Math.Cos(10));
            Console.WriteLine("Tan: "+ Math.Tan(10));

            Console.WriteLine("Ceiling: "+ Math.Ceiling(22.3));
            Console.WriteLine("Round: "+ Math.Round(22.3));
            Console.WriteLine("Floor: "+ Math.Floor(22.3));

            Console.WriteLine("Max: "+ Math.Max(2,6));
            Console.WriteLine("Min: "+ Math.Min(2,6));

            Console.WriteLine("Pow: "+ Math.Pow(2,6));
            Console.WriteLine("Sqrt: "+ Math.Sqrt(9));
            Console.WriteLine("Log: "+ Math.Log(2,6));


        }
    }
}