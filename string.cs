using System;

namespace String_namespace
{
    class Test2
    {
        public static void not_main()
        {
            string string1 = "This is example for CSharp";
            string string2 = "CSharp";
        
            // Length
            Console.WriteLine($"string1.Length: {string1.Length}");

            // Upper - Lower
            Console.WriteLine($"ToLower(): " + string1.ToLower());
            Console.WriteLine($"ToUpper(): " + string1.ToUpper());

            // Concat
            Console.WriteLine($"Concat: " + String.Concat(string1, ", hello"));
            
            // CompateTo - Outputs 0, 1, -1
            Console.WriteLine($"CompareTo: " + string1.CompareTo(string2));

            //Contains
            Console.WriteLine($"Contains: " + string1.Contains(string2));
            Console.WriteLine($"EndsWith: " + string1.EndsWith(string2));
            Console.WriteLine($"StartsWith: " + string1.StartsWith("This"));

            // Index
            Console.WriteLine($"IndexOf: " + string1.IndexOf("for"));
            Console.WriteLine($"LastIndexOf: " + string1.LastIndexOf("i"));

            // Insert
            Console.WriteLine($"Insert: " + string1.Insert(0, string2));

            // PadLeft, PadRight
            Console.WriteLine($"PadLeft1: " + string1 + string2.PadLeft(30));
            Console.WriteLine($"PadLeft2: " + string1 + string2.PadLeft(30, '-'));
            Console.WriteLine($"PadRight1: " + string1.PadRight(30) + string2);
            Console.WriteLine($"PadRight2: " + string1.PadRight(30, '@') + string2);

            // Remove
            Console.WriteLine($"Remove(10): " + string1.Remove(10));
            Console.WriteLine($"Remove(5,3): " + string1.Remove(5,3));
            Console.WriteLine($"Remove(0,1): " + string1.Remove(0,1));

            // Split
            Console.WriteLine($"Split: " + string1.Split(" "));

            // Substring
            Console.WriteLine($"Substring: " + string1.Substring(10));

        }
    }
}