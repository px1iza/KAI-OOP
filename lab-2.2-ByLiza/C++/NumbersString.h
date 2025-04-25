#pragma once
#include "BaseString.h"

namespace String {

    class NumbersString : public BaseString {
    public:
        NumbersString(const std::string& input);
        int GetLength() const override;
        std::string Shift() const override;
    };

}