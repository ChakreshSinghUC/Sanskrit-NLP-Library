// FILE: include/unicode_support.h
#ifndef UNICODE_SUPPORT_H
#define UNICODE_SUPPORT_H

#include <string>
#include <unicode/unistr.h>
#include <unicode/ustream.h>

class UnicodeSupport
{
public:
    static std::u16string toUTF16(const std::string &utf8);
    static std::string toUTF8(const std::u16string &utf16);
};

#endif // UNICODE_SUPPORT_H