#pragma once
#include "IKeyGenerator.h"

class MyString : public IKeyGenerator {
private:
    std::string content;

public:
    MyString(const std::string& input);

    std::string GetContent() const override;
    std::string GenerateKey() const override;
    void CapitalizeWords() override;
};