#include "BaseString.h"

namespace String {

    BaseString::BaseString(const std::string& input) : _value(input) {}

    std::string BaseString::GetValue() const {
        return _value;
    }

    int BaseString::GetLength() const {
        return _value.length();
    }

    std::string BaseString::Shift() const {
        return _value;
    }

}