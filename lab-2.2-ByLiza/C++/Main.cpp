#include <iostream>
#include "BaseString.h"
#include "LowerCaseString.h"
#include "NumbersString.h"
using namespace std;
using namespace String;  

void ProcessString(BaseString* baseStr) {
    cout << "Оригінальний рядок: " << baseStr->GetValue() << endl;
    cout << "Довжина: " << baseStr->GetLength() << endl;
    cout << "Оброблений рядок: " << baseStr->Shift() << endl;
    cout << endl;
}

int main() {
    LowerCaseString lowerCaseString("Hello World!");
    NumbersString numbersString("12345");

    ProcessString(&lowerCaseString);
    ProcessString(&numbersString); 
    return 0;
}