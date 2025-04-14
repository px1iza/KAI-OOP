#include "DoctorStrange.h"

DoctorStrange::DoctorStrange() : name("Unknown"), magicLevel(50) {}

DoctorStrange::DoctorStrange(std::string n, int ml)
    : name(n), magicLevel(ml) {}

DoctorStrange::DoctorStrange(const DoctorStrange& other)
    : name(other.name), magicLevel(other.magicLevel) {}

std::string DoctorStrange::getName() const {
    return name;
}

int DoctorStrange::getPower() const {
    return magicLevel;
}

std::string DoctorStrange::describe() const {
    return "Doctor Strange: " + name + ", Magic: " + std::to_string(magicLevel);
}

IDescribable* DoctorStrange::clone() const {
    return new DoctorStrange(*this);
}