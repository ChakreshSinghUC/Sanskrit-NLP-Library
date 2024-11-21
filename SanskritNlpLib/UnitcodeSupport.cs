using System;
using System.Text;

namespace SanskritNlpLib
{
    public static class UnicodeSupport
    {
        public static void EnsureUnicodeSupport()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
        }
    }
}
