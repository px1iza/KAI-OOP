#ifndef IDESCRIBABLE_H
#define IDESCRIBABLE_H

#include <string>

class IDescribable {
public:
    virtual std::string describe() const = 0;
    virtual std::string getName() const = 0;
    virtual int getPower() const = 0; // Для порівняння сили
    virtual IDescribable* clone() const = 0;
    virtual ~IDescribable() = default;
};

#endif