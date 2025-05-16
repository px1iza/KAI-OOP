#pragma once
#include "IKeyGenerator.h"
#include <vector>

class TextContainer {
private:
    std::vector<IKeyGenerator*> lines;

public:
    void AddLine(IKeyGenerator* input);
    void RemoveLine(size_t index);
    void Clear();
    void CapitalizeAll();
    std::string GetKeyFromLine(size_t index) const;
    int CountLinesOfLength(size_t length) const;
    void PrintAll() const;
};