#include "Human.h"

Human::Human() : name("Unknown"), age(0) {}

Human::Human(std::string n, int a) : name(n), age(a) {}

Human::Human(const Human& other) : name(other.name), age(other.age) {}

std::string Human::getName() const {
    return name;
}

int Human::getAge() const {
    return age;
}

std::string Human::identify() const {
    return "I am a human named " + name;
}
