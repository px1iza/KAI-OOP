#ifndef AVENGERSTEAM_H
#define AVENGERSTEAM_H

#include "IDescribable.h"
#include <vector>
#include <string>

class AvengersTeam {
private:
    std::vector<IDescribable*> members;

public:
    AvengersTeam();
    AvengersTeam(const AvengersTeam& other);
    ~AvengersTeam();

    void addMember(const IDescribable* member);
    void removeMember(const std::string& name);
    void removeBySuitModel(const std::string& suitModel);
    void clearTeam();
    const IDescribable* getMostPowerful() const;
    void capitalizeNames();

    const std::vector<IDescribable*>& getMembers() const;
};

#endif