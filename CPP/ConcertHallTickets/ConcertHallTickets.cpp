#include <iostream>

using namespace std;

int main()
{
    
    const float orchestraCost = 25;
    const float mainFloorCost = 30;
    const float balconyCost = 15;

    int orchestraSold;
    int mainFloorSold;
    int balconySold;

    cout << "Enter orchestra tickets sold: ";
    cin >> orchestraSold;
    cout << endl;

    cout << "Enter main floor tickets sold: ";
    cin >> mainFloorSold;
    cout << endl;

    cout << "Enter balcony tickets sold: ";
    cin >> balconySold;
    cout << endl;

    float totalRevenue = 0;

    float orchestraRevenue = orchestraSold * orchestraCost;
    float mainFloorRevenue = mainFloorSold * mainFloorCost;
    float balconyRevenue = balconySold * balconyCost;

    totalRevenue = orchestraRevenue + mainFloorRevenue + balconyRevenue;

    cout << "The total revenue is: $" << totalRevenue << endl;

    double orchestraContribution = orchestraRevenue / totalRevenue * 100;
    double mainFloorContribution = mainFloorRevenue / totalRevenue * 100;
    double balconyContribution = balconyRevenue / totalRevenue * 100;

    cout << "The contribution for each is as follows:" << endl;
    cout << "Orchestra: " << "%" << round(orchestraContribution) << endl;
    cout << "Main Floor: " << "%" << round(mainFloorContribution) << endl;
    cout << "Balcony: " << "%" << round(balconyContribution) << endl;

}