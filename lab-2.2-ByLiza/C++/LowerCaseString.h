#pragma once
#include "BaseString.h"
#include <algorithm>

namespace String {

    class LowerCaseString : public BaseString {
    public:
        LowerCaseString(const std::string& input);           
        int GetLength() const override;
        std::string Shift() const override;
    };

}