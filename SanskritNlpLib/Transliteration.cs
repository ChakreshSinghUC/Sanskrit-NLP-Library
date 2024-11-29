using System;
using System.Collections.Generic;
using System.Text;

namespace SanskritNlpLib
{
    public static class Transliteration
    {
        private static readonly Dictionary<char, string> DevanagariToRoman;
        private static readonly Dictionary<string, char> RomanToDevanagari;
        private static readonly Dictionary<string, char> RomanToDevanagariMaatras;
        private static readonly Dictionary<string, string> SpecialCases;

        static Transliteration()
        {
            DevanagariToRoman = new Dictionary<char, string>();
            RomanToDevanagari = new Dictionary<string, char>();
            RomanToDevanagariMaatras = new Dictionary<string, char>();
            SpecialCases = new Dictionary<string, string>();

            // Initialize Devanagari to Roman dictionary
            AddToDictionary(DevanagariToRoman, 'अ', "a");
            AddToDictionary(DevanagariToRoman, 'आ', "ā");
            AddToDictionary(DevanagariToRoman, 'इ', "i");
            AddToDictionary(DevanagariToRoman, 'ई', "ī");
            AddToDictionary(DevanagariToRoman, 'उ', "u");
            AddToDictionary(DevanagariToRoman, 'ऊ', "ū");
            AddToDictionary(DevanagariToRoman, 'ऋ', "ṛ");
            AddToDictionary(DevanagariToRoman, 'ए', "e");
            AddToDictionary(DevanagariToRoman, 'ऐ', "ai");
            AddToDictionary(DevanagariToRoman, 'ओ', "o");
            AddToDictionary(DevanagariToRoman, 'औ', "au");
            AddToDictionary(DevanagariToRoman, 'क', "k");
            AddToDictionary(DevanagariToRoman, 'ख', "kh");
            AddToDictionary(DevanagariToRoman, 'ग', "g");
            AddToDictionary(DevanagariToRoman, 'घ', "gh");
            AddToDictionary(DevanagariToRoman, 'ङ', "ṅ");
            AddToDictionary(DevanagariToRoman, 'च', "ch");
            AddToDictionary(DevanagariToRoman, 'छ', "chh");
            AddToDictionary(DevanagariToRoman, 'ज', "j");
            AddToDictionary(DevanagariToRoman, 'झ', "jh");
            AddToDictionary(DevanagariToRoman, 'ञ', "ñ");
            AddToDictionary(DevanagariToRoman, 'ट', "ṭ");
            AddToDictionary(DevanagariToRoman, 'ठ', "ṭh");
            AddToDictionary(DevanagariToRoman, 'ड', "ḍ");
            AddToDictionary(DevanagariToRoman, 'ढ', "ḍh");
            AddToDictionary(DevanagariToRoman, 'ण', "ṇ");
            AddToDictionary(DevanagariToRoman, 'त', "t");
            AddToDictionary(DevanagariToRoman, 'थ', "th");
            AddToDictionary(DevanagariToRoman, 'द', "d");
            AddToDictionary(DevanagariToRoman, 'ध', "dh");
            AddToDictionary(DevanagariToRoman, 'न', "n");
            AddToDictionary(DevanagariToRoman, 'प', "p");
            AddToDictionary(DevanagariToRoman, 'फ', "ph");
            AddToDictionary(DevanagariToRoman, 'ब', "b");
            AddToDictionary(DevanagariToRoman, 'भ', "bh");
            AddToDictionary(DevanagariToRoman, 'म', "m");
            AddToDictionary(DevanagariToRoman, 'य', "y");
            AddToDictionary(DevanagariToRoman, 'र', "r");
            AddToDictionary(DevanagariToRoman, 'ल', "l");
            AddToDictionary(DevanagariToRoman, 'व', "v");
            AddToDictionary(DevanagariToRoman, 'श', "ś");
            AddToDictionary(DevanagariToRoman, 'ष', "ṣ");
            AddToDictionary(DevanagariToRoman, 'स', "s");
            AddToDictionary(DevanagariToRoman, 'ह', "h");
            AddToDictionary(DevanagariToRoman, '\u093E', "ā");
            AddToDictionary(DevanagariToRoman, '\u093F', "i");
            AddToDictionary(DevanagariToRoman, '\u0940', "ī");
            AddToDictionary(DevanagariToRoman, '\u0941', "u");
            AddToDictionary(DevanagariToRoman, '\u0942', "ū");
            AddToDictionary(DevanagariToRoman, '\u0943', "ṛ");
            AddToDictionary(DevanagariToRoman, '\u0947', "e");
            AddToDictionary(DevanagariToRoman, '\u0948', "ai");
            AddToDictionary(DevanagariToRoman, '\u094B', "o");
            AddToDictionary(DevanagariToRoman, '\u094C', "au");
            AddToDictionary(DevanagariToRoman, '\u0902', "ṃ");
            AddToDictionary(DevanagariToRoman, '\u0903', "ḥ");
            AddToDictionary(DevanagariToRoman, '\u0901', "ṅ");
            AddToDictionary(DevanagariToRoman, '\u094D', "");

            // Initialize Roman to Devanagari dictionary
            AddToDictionary(RomanToDevanagari, "a", 'अ');
            AddToDictionary(RomanToDevanagari, "ā", 'आ');
            AddToDictionary(RomanToDevanagari, "i", 'इ');
            AddToDictionary(RomanToDevanagari, "ī", 'ई');
            AddToDictionary(RomanToDevanagari, "u", 'उ');
            AddToDictionary(RomanToDevanagari, "ū", 'ऊ');
            AddToDictionary(RomanToDevanagari, "ṛ", 'ऋ');
            AddToDictionary(RomanToDevanagari, "e", 'ए');
            AddToDictionary(RomanToDevanagari, "ai", 'ऐ');
            AddToDictionary(RomanToDevanagari, "o", 'ओ');
            AddToDictionary(RomanToDevanagari, "au", 'औ');
            AddToDictionary(RomanToDevanagari, "k", 'क');
            AddToDictionary(RomanToDevanagari, "kh", 'ख');
            AddToDictionary(RomanToDevanagari, "g", 'ग');
            AddToDictionary(RomanToDevanagari, "gh", 'घ');
            AddToDictionary(RomanToDevanagari, "ṅ", 'ङ');
            AddToDictionary(RomanToDevanagari, "ch", 'च');
            AddToDictionary(RomanToDevanagari, "chh", 'छ');
            AddToDictionary(RomanToDevanagari, "j", 'ज');
            AddToDictionary(RomanToDevanagari, "jh", 'झ');
            AddToDictionary(RomanToDevanagari, "ñ", 'ञ');
            AddToDictionary(RomanToDevanagari, "ṭ", 'ट');
            AddToDictionary(RomanToDevanagari, "ṭh", 'ठ');
            AddToDictionary(RomanToDevanagari, "ḍ", 'ड');
            AddToDictionary(RomanToDevanagari, "ḍh", 'ढ');
            AddToDictionary(RomanToDevanagari, "ṇ", 'ण');
            AddToDictionary(RomanToDevanagari, "t", 'त');
            AddToDictionary(RomanToDevanagari, "th", 'थ');
            AddToDictionary(RomanToDevanagari, "d", 'द');
            AddToDictionary(RomanToDevanagari, "dh", 'ध');
            AddToDictionary(RomanToDevanagari, "n", 'न');
            AddToDictionary(RomanToDevanagari, "p", 'प');
            AddToDictionary(RomanToDevanagari, "ph", 'फ');
            AddToDictionary(RomanToDevanagari, "b", 'ब');
            AddToDictionary(RomanToDevanagari, "bh", 'भ');
            AddToDictionary(RomanToDevanagari, "m", 'म');
            AddToDictionary(RomanToDevanagari, "y", 'य');
            AddToDictionary(RomanToDevanagari, "r", 'र');
            AddToDictionary(RomanToDevanagari, "l", 'ल');
            AddToDictionary(RomanToDevanagari, "v", 'व');
            AddToDictionary(RomanToDevanagari, "ś", 'श');
            AddToDictionary(RomanToDevanagari, "ṣ", 'ष');
            AddToDictionary(RomanToDevanagari, "s", 'स');
            AddToDictionary(RomanToDevanagari, "h", 'ह');

            // Initialize Roman to Devanagari Maatras dictionary
            AddToDictionary(RomanToDevanagariMaatras, "ā", '\u093E');
            AddToDictionary(RomanToDevanagariMaatras, "i", '\u093F');
            AddToDictionary(RomanToDevanagariMaatras, "ī", '\u0940');
            AddToDictionary(RomanToDevanagariMaatras, "u", '\u0941');
            AddToDictionary(RomanToDevanagariMaatras, "ū", '\u0942');
            AddToDictionary(RomanToDevanagariMaatras, "ṛ", '\u0943');
            AddToDictionary(RomanToDevanagariMaatras, "e", '\u0947');
            AddToDictionary(RomanToDevanagariMaatras, "ai", '\u0948');
            AddToDictionary(RomanToDevanagariMaatras, "o", '\u094B');
            AddToDictionary(RomanToDevanagariMaatras, "au", '\u094C');
            AddToDictionary(RomanToDevanagariMaatras, "ṃ", '\u0902');
            AddToDictionary(RomanToDevanagariMaatras, "ḥ", '\u0903');
            AddToDictionary(RomanToDevanagariMaatras, "ṅ", '\u0901');
            AddToDictionary(RomanToDevanagariMaatras, "", '\u094D');

            // Initialize Special Cases dictionary
            AddToDictionary(SpecialCases, "kṣ", "क्ष");
            AddToDictionary(SpecialCases, "jñ", "ज्ञ");
        }

        private static void AddToDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
            {
                throw new ArgumentException($"Duplicate key detected: {key}");
            }
            dictionary[key] = value;
        }

        public static string ToRoman(string devanagariText)
        {
            var romanText = new StringBuilder();
            for (int i = 0; i < devanagariText.Length; i++)
            {
                char ch = devanagariText[i];
                if (DevanagariToRoman.TryGetValue(ch, out var romanChar))
                {
                    romanText.Append(romanChar);
                }
                else
                {
                    romanText.Append(ch); // Keep the character as is if no mapping is found
                }
            }
            return ApplySpecialCases(romanText.ToString());
        }

        public static string ToDevanagari(string romanText)
        {
            var devanagariText = new StringBuilder();
            for (int i = 0; i < romanText.Length;)
            {
                bool matched = false;
                foreach (var kvp in SpecialCases)
                {
                    if (romanText.Substring(i).StartsWith(kvp.Key))
                    {
                        devanagariText.Append(kvp.Value);
                        i += kvp.Key.Length;
                        matched = true;
                        break;
                    }
                }
                if (!matched)
                {
                    foreach (var kvp in RomanToDevanagari)
                    {
                        if (romanText.Substring(i).StartsWith(kvp.Key))
                        {
                            devanagariText.Append(kvp.Value);
                            i += kvp.Key.Length;
                            matched = true;
                            break;
                        }
                    }
                }
                if (!matched)
                {
                    foreach (var kvp in RomanToDevanagariMaatras)
                    {
                        if (romanText.Substring(i).StartsWith(kvp.Key))
                        {
                            devanagariText.Append(kvp.Value);
                            i += kvp.Key.Length;
                            matched = true;
                            break;
                        }
                    }
                }
                if (!matched)
                {
                    devanagariText.Append(romanText[i]);
                    i++;
                }
            }
            return devanagariText.ToString();
        }

        private static string ApplySpecialCases(string text)
        {
            foreach (var kvp in SpecialCases)
            {
                text = text.Replace(kvp.Key, kvp.Value);
            }
            return text;
        }
    }
}
