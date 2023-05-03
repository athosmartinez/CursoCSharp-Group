using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";
            string MaiscOriginal = original.ToUpper();
            string MinusOriginal = original.ToLower();
            string NoSpace = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string CutString1 = original.Substring(3);
            string CutString2 = original.Substring(3, 5);
            string CharReplace1 = original.Replace('A', 'Y');
            string CharReplace2 = original.Replace("abc", "xy");
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: " + original + "-");
            Console.WriteLine("To Upper: " + MaiscOriginal + "-");
            Console.WriteLine("To Lower: " + MinusOriginal + "-");
            Console.WriteLine("Trim: " + NoSpace + "-");
            Console.WriteLine("IndexOf(bc): " + n1);
            Console.WriteLine("LastIndexOf(bc): " + n2);
            Console.WriteLine("Substring(3): " + CutString1 + "-");
            Console.WriteLine("Substring(3, 5): " + CutString2 + "-");
            Console.WriteLine("Replace('A', 'Y'): " + CharReplace1 + "-");
            Console.WriteLine("Replace(\"abc\", \"xy\"): " + CharReplace2 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);   
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);   
        }
    }
}