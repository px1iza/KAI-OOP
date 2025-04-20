#include "Widow.h"

Widow::Widow() : name("Unknown"), skillLevel(60) {}

Widow::Widow(std::string n, int sl)
    : name(n), skillLevel(sl) {}

Widow::Widow(const Widow& other)
    : name(other.name), skillLevel(other.skillLevel) {}

std::string Widow::getName() const {
    return name;
}

int Widow::getPower() const {
    return skillLevel;
}

std::string Widow::describe() const {
    return "Black Widow: " + name + ", Skill: " + std::to_string(skillLevel);
}

IDescribable* Widow::clone() const {
    return new Widow(*this);
}