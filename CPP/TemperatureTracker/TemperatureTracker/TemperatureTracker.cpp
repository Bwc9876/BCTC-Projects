//Program Name: Temperature Tracker
//Programmer: Ben Crocker
//Date: 8-27-21
//Purpose: Track temperatures for a week then display the average highs and lows

//Test Cases:
//
// > All 5s
// < 5.0
//
//
// > Stuff adding up to 45
// > Stuff adding up to 14
// < 6.4
// < 2.1
//


#include <iostream>
#include <iomanip>

using namespace std;

void display_averages(int temperatures[7][2]) {
	// This function takes an array of temperatures and calculates the  average low and high

	int totalHigh = 0;
	int totalLow = 0;

	for (int i = 0; i < 7; i++) {

		totalHigh += temperatures[i][0];
		totalLow += temperatures[i][1];

	}
	// end for

	double highAverage = static_cast<double>(totalHigh) / 7.0;
	double lowAverage = static_cast<double>(totalLow) / 7.0;

	cout << "Average Highest Temperature: " << fixed << setprecision(1) << highAverage;
	cout << endl << "Average Lowest Temperature: " << lowAverage;

}

int main()
{
	// This function generates and array of highs and lows for the week from user input
	// It then displays the average of both highs and lows

	int temperatures[7][2] = { 0 };

	for (int i = 0; i < 7; i++) {

		cout << "Enter highest temperature for day " << i + 1 << ": ";
		cin >> temperatures[i][0];
		cout << "Enter lowest temperature for day " << i + 1 << ": ";
		cin >> temperatures[i][1];

	}
	// end for

	display_averages(temperatures);

}

