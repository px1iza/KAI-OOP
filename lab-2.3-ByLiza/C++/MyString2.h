#pragma once
#include "IKeyGenerator.h"

class MyString2 : public IKeyGenerator {
private:
    std::string content;

public:
    MyString2(const std::string& input);

    std::string GetContent() const override;
    std::string GenerateKey() const override;
    void CapitalizeWords() override;
};