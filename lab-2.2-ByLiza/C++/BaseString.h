#pragma once
#include <string>

namespace String {

    class BaseString {
    protected:
        std::string _value;

    public:
        BaseString(const std::string& input);
        std::string GetValue() const;
        virtual int GetLength() const;
        virtual std::string Shift() const;
    };

}