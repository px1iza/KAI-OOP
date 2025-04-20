#ifndef IRONMAN_H
#define IRONMAN_H

#include "IDescribable.h"
#include <string>

class Ironman : public IDescribable {
private:
    std::string name;
    std::string suitModel;
    int powerLevel;

public:
    Ironman();
    Ironman(std::string n, std::string sm, int pl);
    Ironman(const Ironman& other);

    std::string getName() const override;
    std::string getSuitModel() const;
    int getPower() const override;
    std::string describe() const override;
    IDescribable* clone() const override;
};

#endif