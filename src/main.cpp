#include <iostream>
#include "transliteration.h"
#include "unicode_support.h"

int main()
{
    std::string input = "अआइईउऊ"; // Example Devanagari input

    // Transliteration example
    std::string iast = Transliteration::toIAST(input);
    std::cout << "IAST: " << iast << std::endl;

    std::string original = Transliteration::fromIAST(iast);
    std::cout << "Original: " << original << std::endl;

    // Unicode support example
    std::u16string utf16 = UnicodeSupport::toUTF16(input);
    std::string utf8 = UnicodeSupport::toUTF8(utf16);
    std::cout << "UTF-8: " << utf8 << std::endl;

    return 0;
}