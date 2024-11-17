// FILE: src/unicode_support.cpp
#include "unicode_support.h"

std::u16string UnicodeSupport::toUTF16(const std::string& utf8) {
    icu::UnicodeString unicodeString = icu::UnicodeString::fromUTF8(utf8);
    std::u16string utf16;
    unicodeString.toUTF16String(utf16);
    return utf16;
}

std::string UnicodeSupport::toUTF8(const std::u16string& utf16) {
    icu::UnicodeString unicodeString = icu::UnicodeString::fromUTF16(utf16);
    std::string utf8;
    unicodeString.toUTF8String(utf8);
    return utf8;
}