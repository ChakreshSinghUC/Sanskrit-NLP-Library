// FILE: include/transliteration.h
#ifndef TRANSLITERATION_H
#define TRANSLITERATION_H

#include <string>

class Transliteration
{
public:
    static std::string toIAST(const std::string &input);
    static std::string fromIAST(const std::string &input);
};

#endif // TRANSLITERATION_H