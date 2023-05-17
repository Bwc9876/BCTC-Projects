#include <iostream>

using namespace std;

int main()
{
    
    const double pi = 3.14;
    const double sliceArea = 14.13;

    double pizzaRadius = 0;

    cout << "Enter the radius of the pizza: ";
    cin >> pizzaRadius;
    cout << endl;

    double pizzaArea = pi * pow(pizzaRadius, 2);
    
    int slices = floor((float)(pizzaArea / sliceArea));

    cout << "The number of slices you can cut is " << slices << endl;

}

