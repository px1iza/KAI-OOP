#include "Hulk.h"

Hulk::Hulk() : name("Unknown"), strengthLevel(80) {}

Hulk::Hulk(std::string n, int sl)
    : name(n), strengthLevel(sl) {}

Hulk::Hulk(const Hulk& other)
    : name(other.name), strengthLevel(other.strengthLevel) {}

std::string Hulk::getName() const {
    return name;
}

int Hulk::getPower() const {
    return strengthLevel;
}

std::string Hulk::describe() const {
    return "Hulk: " + name + ", Strength: " + std::to_string(strengthLevel);
}

IDescribable* Hulk::clone() const {
    return new Hulk(*this);
}