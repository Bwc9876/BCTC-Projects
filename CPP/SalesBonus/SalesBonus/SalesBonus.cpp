// Name: Ben Crocker
// Program Name: Salesbonus
// Date: 8/30/21
// Purpose: Calculate the total sales and bonus sales for the manager of a sales company

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	//This program asks the manager of teh sales company for a bonus rate
	//It then calculates the total sales and the bonuses for each employee

	const double SALES_PEOPLE[10][3] = { {2400, 3500, 2000}, {1500, 7000, 1000}, {600, 450, 2100}, {790, 240, 500}, {1000, 1000, 1000}, {6300, 7000, 8000}, {1300, 450, 700}, {2700, 5500, 6000}, {4700, 4800, 4900}, {1200, 1300, 400} };

	double bonusRate;
	double totalBonus = 0.0;

	cout << "Enter Bonus Rate: ";
	cin >> bonusRate;

	cout << fixed << setprecision(2);
	
	for (int person = 0; person < 10; person++) {

		double totalSales = 0;

		for (int month = 0; month < 3; month++) {

			totalSales += SALES_PEOPLE[person][month];

		}
		// end for

		double bonus = totalSales * (bonusRate / 100.0);
		totalBonus += bonus;

		cout << "Person " << person + 1 << (person == 9 ? " |" : "  |") << " Total Sales: $" << totalSales << " Bonus: $" << bonus << endl;

	}
	// end for

	cout << "Total Bonuses: $" << totalBonus << endl;

}
