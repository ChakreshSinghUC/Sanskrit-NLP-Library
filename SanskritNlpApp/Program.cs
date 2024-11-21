using System;

namespace SanskritNlpLib
{
    class Program
    {
        static void Main(string[] args)
        {
            UnicodeSupport.EnsureUnicodeSupport();

            string devanagariText = "चक्रेश";
            string romanText = Transliteration.ToRoman(devanagariText);
            string _devanagariText = Transliteration.ToDevanagari(romanText);

            Console.WriteLine($"Devanagari: {devanagariText}");
            Console.WriteLine($"Romanized: {romanText}");
            Console.WriteLine($"Devanagari again: {_devanagariText}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
