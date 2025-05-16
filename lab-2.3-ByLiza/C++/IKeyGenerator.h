#pragma once
#include <string>

class IKeyGenerator {
public:
    virtual std::string GenerateKey() const = 0;
    virtual std::string GetContent() const = 0;
    virtual void CapitalizeWords() = 0;
    virtual ~IKeyGenerator() {}
};