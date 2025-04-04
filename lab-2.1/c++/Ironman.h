#ifndef IRONMAN_H
#define IRONMAN_H

#include "Human.h"
#include <string>

class Ironman : public Human {
private:
    std::string suitModel;
    int powerLevel;

public:
    Ironman();
    Ironman(std::string n, int a, std::string sm, int pl);
    Ironman(const Ironman& other);

    std::string getSuitModel() const;
    int getPowerLevel() const;
};

#endif