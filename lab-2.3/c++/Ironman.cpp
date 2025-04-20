#include "Ironman.h"

Ironman::Ironman() : name("Unknown"), suitModel("Mark I"), powerLevel(100) {}

Ironman::Ironman(std::string n, std::string sm, int pl)
    : name(n), suitModel(sm), powerLevel(pl) {}

Ironman::Ironman(const Ironman& other)
    : name(other.name), suitModel(other.suitModel), powerLevel(other.powerLevel) {}

std::string Ironman::getName() const {
    return name;
}

std::string Ironman::getSuitModel() const {
    return suitModel;
}

int Ironman::getPower() const {
    return powerLevel;
}

std::string Ironman::describe() const {
    return "Ironman: " + name + ", Suit: " + suitModel + ", Power: " + std::to_string(powerLevel);
}

IDescribable* Ironman::clone() const {
    return new Ironman(*this);
}