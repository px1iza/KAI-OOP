#include "Ironman.h"

Ironman::Ironman() : Human(), suitModel("Mark I"), powerLevel(100) {}

Ironman::Ironman(std::string n, int a, std::string sm, int pl) 
    : Human(n, a), suitModel(sm), powerLevel(pl) {}

Ironman::Ironman(const Ironman& other) 
    : Human(other), suitModel(other.suitModel), powerLevel(other.powerLevel) {}

std::string Ironman::getSuitModel() const {
    return suitModel;
}

int Ironman::getPowerLevel() const {
    return powerLevel;
}
