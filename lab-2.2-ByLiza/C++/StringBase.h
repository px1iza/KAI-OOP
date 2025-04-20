#pragma once
#include <string>

class StringBase {
protected:
    std::string _value;

public:
    StringBase(const std::string& value);
    
    std::string getValue() const;
    
    // Виртуальный метод для вычисления длины строки
    virtual int getLength() const;
    
    // Виртуальный метод для сдвига символов
    virtual std::string shiftCharacters() const;
    
    // Виртуальный деструктор
    virtual ~StringBase();
};