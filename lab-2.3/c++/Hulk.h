#ifndef HULK_H
#define HULK_H

#include "IDescribable.h"
#include <string>

class Hulk : public IDescribable {
private:
    std::string name;
    int strengthLevel;

public:
    Hulk();
    Hulk(std::string n, int sl);
    Hulk(const Hulk& other);

    std::string getName() const override;
    int getPower() const override;
    std::string describe() const override;
    IDescribable* clone() const override;
};

#endif