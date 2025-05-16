#include "MyString.h"
#include <sstream>
#include <cctype>

MyString::MyString(const std::string& input) : content(input) {}

std::string MyString::GetContent() const {
    return content;
}

std::string MyString::GenerateKey() const {
    std::istringstream iss(content);
    std::string word, key;
    while (iss >> word) {
        if (!word.empty())
            key += word[0];
    }
    return key;
}

void MyString::CapitalizeWords() {
    std::istringstream iss(content);
    std::ostringstream oss;
    std::string word;
    bool first = true;
    while (iss >> word) {
        if (!word.empty())
            word[0] = std::toupper(word[0]);
        if (!first) oss << " ";
        oss << word;
        first = false;
    }
    content = oss.str();
}