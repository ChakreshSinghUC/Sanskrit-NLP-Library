#include "unicode_support.h"
#include <unicode/unistr.h>

std::u16string UnicodeSupport::toUTF16(const std::string &input)
{
    icu::UnicodeString unicodeString = icu::UnicodeString::fromUTF8(input);
    std::u16string utf16String(unicodeString.length(), 0); // Ensure capacity
    unicodeString.extract(0, unicodeString.length(), reinterpret_cast<UChar *>(&utf16String[0]), unicodeString.length());
    return utf16String;
}

std::string UnicodeSupport::toUTF8(const std::u16string &input)
{
    icu::UnicodeString unicodeString(reinterpret_cast<const UChar *>(input.c_str()), static_cast<int32_t>(input.length()));
    std::string utf8String;
    unicodeString.toUTF8String(utf8String);
    return utf8String;
}