#include "AvengersTeam.h"
#include "Ironman.h"
#include "DoctorStrange.h"
#include "Hulk.h"
#include "Widow.h"
#include <algorithm>

AvengersTeam::AvengersTeam() {}

AvengersTeam::AvengersTeam(const AvengersTeam& other) {
    for (const auto* member : other.members) {
        members.push_back(member->clone());
    }
}

AvengersTeam::~AvengersTeam() {
    for (auto* member : members) {
        delete member;
    }
}

void AvengersTeam::addMember(const IDescribable* member) {
    members.push_back(member->clone());
}

void AvengersTeam::removeMember(const std::string& name) {
    members.erase(
        std::remove_if(members.begin(), members.end(),
            [&name](const IDescribable* member) { return member->getName() == name; }),
        members.end()
    );
}

void AvengersTeam::removeBySuitModel(const std::string& suitModel) {
    members.erase(
        std::remove_if(members.begin(), members.end(),
            [&suitModel](const IDescribable* member) {
                const Ironman* ironman = dynamic_cast<const Ironman*>(member);
                return ironman && ironman->getSuitModel() == suitModel;
            }),
        members.end()
    );
}

void AvengersTeam::clearTeam() {
    for (auto* member : members) {
        delete member;
    }
    members.clear();
}

const IDescribable* AvengersTeam::getMostPowerful() const {
    if (members.empty()) return nullptr;
    const IDescribable* maxPower = members[0];
    int maxLevel = members[0]->getPower();
    for (const auto* member : members) {
        if (member->getPower() > maxLevel) {
            maxLevel = member->getPower();
            maxPower = member;
        }
    }
    return maxPower;
}

void AvengersTeam::capitalizeNames() {
    for (auto* member : members) {
        std::string name = member->getName();
        if (!name.empty()) {
            name[0] = std::toupper(name[0]);
            // Note: Потребує сеттера для зміни імені
        }
    }
}

const std::vector<IDescribable*>& AvengersTeam::getMembers() const {
    return members;
}