#include "MyString2.h"
#include <sstream>
#include <cctype>
#include <vector>

MyString2::MyString2(const std::string& input) : content(input) {}

std::string MyString2::GetContent() const {
    return content + " 2";
}

std::string MyString2::GenerateKey() const {
    std::istringstream iss(content);
    std::vector<std::string> words;
    std::string word, key;
    while (iss >> word) {
        words.push_back(word);
    }
    for (int i = words.size() - 1; i >= 0; --i) {
        if (!words[i].empty())
            key += words[i][0];
    }
    return key;
}

void MyString2::CapitalizeWords() {
    std::istringstream iss(content);
    std::ostringstream oss;
    std::string word;
    bool first = true;
    while (iss >> word) {
        if (!word.empty())
            word[0] = std::tolower(word[0]);
        if (!first) oss << " ";
        oss << word;
        first = false;
    }
    content = oss.str();
}