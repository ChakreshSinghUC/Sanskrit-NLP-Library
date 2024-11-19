#include "transliteration.h"
#include <unordered_map>

// Example mappings for transliteration
std::unordered_map<char, std::string> devanagariToIAST = {
    {'अ', "a"}, {'आ', "ā"}, {'इ', "i"}, {'ई', "ī"}, {'उ', "u"}, {'ऊ', "ū"},
    // Add more mappings as needed
};

std::unordered_map<std::string, char> iastToDevanagari = {
    {"a", 'अ'}, {"ā", 'आ'}, {"i", 'इ'}, {"ī", 'ई'}, {"u", 'उ'}, {"ū", 'ऊ'},
    // Add more mappings as needed
};

std::string Transliteration::toIAST(const std::string& input) {
    std::string result;
    for (char c : input) {
        if (devanagariToIAST.find(c) != devanagariToIAST.end()) {
            result += devanagariToIAST[c];
        } else {
            result += c; // Keep the character as is if no mapping is found
        }
    }
    return result;
}

std::string Transliteration::fromIAST(const std::string& input) {
    std::string result;
    std::string buffer;
    for (char c : input) {
        buffer += c;
        if (iastToDevanagari.find(buffer) != iastToDevanagari.end()) {
            result += iastToDevanagari[buffer];
            buffer.clear();
        }
    }
    return result;
}