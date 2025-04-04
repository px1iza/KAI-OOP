#include <iostream>
#include "Ironman.h"

int main() {
    Ironman tony1;
    std::cout << "Default Ironman: " << tony1.getName() << ", " 
              << tony1.getAge() << ", " << tony1.getSuitModel() << ", " 
              << tony1.getPowerLevel() << std::endl;

    Ironman tony2("Tony Stark", 38, "Mark L", 9000);
    std::cout << "Custom Ironman: " << tony2.getName() << ", " 
              << tony2.getAge() << ", " << tony2.getSuitModel() << ", " 
              << tony2.getPowerLevel() << std::endl;

    Ironman tony3(tony2);
    std::cout << "Copied Ironman: " << tony3.getName() << ", " 
              << tony3.getAge() << ", " << tony3.getSuitModel() << ", " 
              << tony3.getPowerLevel() << std::endl;

    return 0;
}