#include <iostream>

using namespace std;

int main()
{

    int startingWashers = 0;
    int boughtWashers = 0;
    int soldWashers = 0;


    cout << "Enter the dishwashers at the start of the month: ";
    cin >> startingWashers;
    cout << endl;

    cout << "Enter the dishwashers bought: ";
    cin >> boughtWashers;
    cout << endl;

    cout << "Enter the dishwashers sold: ";
    cin >> soldWashers;
    cout << endl;

    int totalWashers = startingWashers;

    totalWashers += boughtWashers;
    totalWashers -= soldWashers;

    int netWashers = totalWashers - startingWashers;

    cout << "There are " << totalWashers << " washers at the end of the month" << endl;
    cout << "There was a net of " << netWashers << " washers" << endl;

}
