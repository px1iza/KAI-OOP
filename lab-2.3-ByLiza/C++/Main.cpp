#include "MyString.h"
#include "MyString2.h"
#include "TextContainer.h"
#include <iostream>
using namespace std;

int main() {
    TextContainer text;

    text.AddLine(new MyString("привіт світ"));
    text.AddLine(new MyString2("Об'єКтно орієнтоване програмування"));

    cout << "Початковий текст:\n";
    text.PrintAll();

    text.CapitalizeAll();
    cout << "\nПісля приведення перших літер слів до регістру:\n";
    text.PrintAll();

    cout << "\nКлюч з першого рядка: " << text.GetKeyFromLine(0) << endl;
    cout << "Кількість рядків довжиною 33 символи: " << text.CountLinesOfLength(33) << endl;

    text.RemoveLine(1);
    cout << "\nПісля видалення другого рядка:\n";
    text.PrintAll();

    text.Clear();
    cout << "\nПісля очищення тексту:\n";
    text.PrintAll();

    return 0;
}