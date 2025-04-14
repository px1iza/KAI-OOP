#ifndef DOCTORSTRANGE_H
#define DOCTORSTRANGE_H

#include "IDescribable.h"
#include <string>

class DoctorStrange : public IDescribable {
private:
    std::string name;
    int magicLevel;

public:
    DoctorStrange();
    DoctorStrange(std::string n, int ml);
    DoctorStrange(const DoctorStrange& other);

    std::string getName() const override;
    int getPower() const override;
    std::string describe() const override;
    IDescribable* clone() const override;
};

#endif