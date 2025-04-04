#include <iostream>
#include "Segment.h"

using namespace std;  

int main() {
    Segment segment(0, 0, 3, 4);

    Segment segment1 = segment;

    cout << "Дані відрізка:" << endl;
    cout << segment.GetSegmentData() << endl;

    double length = segment.GetLength();
    cout << "Довжина відрізка: " << length << endl;

    if (length > 5) {
        segment.ReduceLengthBy5();
        cout << "Довжина відрізка зменшена на 5." << endl;
        cout << segment.GetSegmentData() << endl;
    }  
    else {
        cout << "Довжина відрізка менша або дорівнює 5, тому не можна зменшити на 5." << endl;
    }
    return 0;
}
