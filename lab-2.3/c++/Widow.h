#ifndef WIDOW_H
#define WIDOW_H

#include "IDescribable.h"
#include <string>

class Widow : public IDescribable {
private:
    std::string name;
    int skillLevel;

public:
    Widow();
    Widow(std::string n, int sl);
    Widow(const Widow& other);

    std::string getName() const override;
    int getPower() const override;
    std::string describe() const override;
    IDescribable* clone() const override;
};

#endif