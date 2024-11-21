#ifndef UNICODE_SUPPORT_H
#define UNICODE_SUPPORT_H

#include <string>

class UnicodeSupport
{
public:
    static std::u16string toUTF16(const std::string &input);
    static std::string toUTF8(const std::u16string &input);
};

#endif // UNICODE_SUPPORT_H