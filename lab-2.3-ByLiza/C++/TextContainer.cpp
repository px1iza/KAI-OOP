#include "TextContainer.h"
#include <iostream>

void TextContainer::AddLine(IKeyGenerator* input) {
    lines.push_back(input);
}

void TextContainer::RemoveLine(size_t index) {
    if (index < lines.size())
        lines.erase(lines.begin() + index);
}

void TextContainer::Clear() {
    lines.clear();
}

void TextContainer::CapitalizeAll() {
    for (auto& line : lines) {
        line->CapitalizeWords();
    }
}

std::string TextContainer::GetKeyFromLine(size_t index) const {
    if (index < lines.size())
        return lines[index]->GenerateKey();
    return "";
}

int TextContainer::CountLinesOfLength(size_t length) const {
    int count = 0;
    for (const auto& line : lines) {
        if (line->GetContent().length() == length)
            ++count;
    }
    return count;
}

void TextContainer::PrintAll() const {
    for (const auto& line : lines) {
        std::cout << line->GetContent() << std::endl;
    }
}