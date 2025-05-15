#include <iostream>
#include "AvengersTeam.h"
#include "Ironman.h"
#include "DoctorStrange.h"
#include "Hulk.h"
#include "Widow.h"

int main() {
    AvengersTeam team;

    // Створення супергероїв
    IDescribable* tony = new Ironman("Tony Stark", "Mark L", 9000);
    IDescribable* stephen = new DoctorStrange("Stephen Strange", 8000);
    IDescribable* bruce = new Hulk("Bruce Banner", 8500);
    IDescribable* natasha = new Widow("Natasha Romanoff", 7000);

    // Додавання до команди
    team.addMember(tony);
    team.addMember(stephen);
    team.addMember(bruce);
    team.addMember(natasha);

    // Виведення команди
    std::cout << "Team members:\n";
    for (const auto* member : team.getMembers()) {
        std::cout << member->describe() << std::endl;
    }

    // Видалення за ім'ям
    std::cout << "\nRemoving Natasha Romanoff:\n";
    team.removeMember("Natasha Romanoff");
    for (const auto* member : team.getMembers()) {
        std::cout << member->describe() << std::endl;
    }

    // Найпотужніший член
    std::cout << "\nMost powerful member:\n";
    if (const IDescribable* powerful = team.getMostPowerful()) {
        std::cout << powerful->describe() << std::endl;
    }

    // Очищення команди
    std::cout << "\nClearing team:\n";
    team.clearTeam();
    std::cout << "Team is empty: " << (team.getMembers().empty() ? "Yes" : "No") << std::endl;

    // Очищення пам'яті
    delete tony;
    delete stephen;
    delete bruce;
    delete natasha;

    return 0;
}