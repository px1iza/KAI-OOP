#include "LowerCaseString.h"

namespace String {

    LowerCaseString::LowerCaseString(const std::string& input)
    : BaseString(input)
{
    for (char& c : _value) {
        c = std::tolower(c); 
    }
}
    int LowerCaseString::GetLength() const {
        return _value.length();
    }

    std::string LowerCaseString::Shift() const {
        if (_value.length() > 1) {
            std::string chars = _value;
            char firstChar = chars[0];
            for (size_t i = 0; i < chars.length() - 1; ++i) {
                chars[i] = chars[i + 1];
            }
            chars[chars.length() - 1] = firstChar;
            return chars;
        }
        return _value;
    }

}