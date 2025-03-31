#ifndef HUMAN_H
#define HUMAN_H

#include <string>

class Human {
private:
    std::string name;
    int age;

public:
    Human();
    Human(std::string n, int a);
    Human(const Human& other);

    std::string getName() const;
    int getAge() const;
};

#endif