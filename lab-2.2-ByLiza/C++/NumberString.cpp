#include "NumbersString.h"

namespace String {

    NumbersString::NumbersString(const std::string& input) : BaseString(input) {}

    int NumbersString::GetLength() const {
        return _value.length();
    }

    std::string NumbersString::Shift() const {
        if (_value.length() > 1) {
            std::string chars = _value;
            char lastChar = chars[chars.length() - 1];
            for (size_t i = chars.length() - 1; i > 0; --i) {
                chars[i] = chars[i - 1];
            }
            chars[0] = lastChar;
            return chars;
        }
        return _value;
    }

}