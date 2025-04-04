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

    // Гетери
    std::string getName() const;
    int getAge() const;

    // Віртуальна функція
    virtual std::string identify() const; // Повертає ідентифікацію об'єкта

    // Віртуальний деструктор (обов’язковий при поліморфізмі)
    virtual ~Human() = default;
};

#endif