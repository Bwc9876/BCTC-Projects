/*
	Program Name: 11_06_44
	Programmer: Ben Crocker
	Date: 5/10/21
	Purpose: Perform a wide variety of tasks using value-returning functions
*/


#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

// BEGIN NUMBER 23 FUNCTIONS

	// Test Cases

	// > 5
	// > 5
    // > 5
	// < 15

	// > 1
	// > 2
	// > 3
	// < 6

double getTestScore(int);

double getTestScore(int number) {
	//This function is used to obtain a test score from the user

	double score;
	cout << "Enter Test Score #" << number << ": ";
	cin >> score;
	return score;

}

double calcAverage(double, double, double);

double calcAverage(double score1, double score2, double score3) {
	//This function is used to find the average of three test scores

	return (score1 + score2 + score3) / 3.0;

}

void number23();


void number23() {
	//This is the function for question number 23
	//It gets three test scores and returns their averages

	double score1 = getTestScore(1);
	double score2 = getTestScore(2);
	double score3 = getTestScore(3);

	cout << fixed << setprecision(1);
	cout << "Average: " << calcAverage(score1, score2, score3) << endl;

}

// END NUMBER 23 FUNCTIONS


// BEGIN NUMBER 22 FUNCTIONS

	// Test Cases
	
	// > 50, 1
	// < $55
	// > 40, 1
	// < $40
	// > 30, 1
	// < $30
	// > -1
	// < $125

double calcEmployeePay(int, double);

double calcEmployeePay(int hours, double rate) {
	//This function is used to calculate the gross pay for an employee
	const int HOURS_UNTIL_OVERTIME = 40;

	if (hours > HOURS_UNTIL_OVERTIME) {	
		int overtimeHours = hours - HOURS_UNTIL_OVERTIME;
		return (static_cast<double>(overtimeHours) * (rate * 1.5)) + (HOURS_UNTIL_OVERTIME * rate);
	}
	else {
		return static_cast<double>(hours) * rate;
	}
	//end if

}

double calcTotalPay(double, double);

double calcTotalPay(double currentTotal, double newPay) {
	//This function is used to calculate the total pay from a current total and a new value

	return currentTotal + newPay;

}

void number22();

void number22() {
	//This is the function for question number 22, it gets the total gross pay for a group of employees

	int hours = 0;
	double rate = 0.0;
	double total = 0.0;
	
	cout << fixed << setprecision(2);

	while (hours != -1) {
		cout << "Enter hours worked (-1 to stop): ";
		cin >> hours;
		if (hours != -1) {
			cout << "Enter Pay Rate: ";
			cin >> rate;
			double grossPay = calcEmployeePay(hours, rate);
			cout << "Gross Pay: $" << grossPay << endl;
			total = calcTotalPay(total, grossPay);
		}
		// end if
	}
	// end while

	cout << "Total Gross Pay: $" << total << endl;

}

// END NUMBER 22 FUNCTIONS


// BEGIN NUMBER 20 FUNCTIONS

	// Test Cases

	// > -5
	// < The sales cannot be less than 0.
	
	// > 100000
	// < $2000

	// > 400000
	// < $17000

	// > 400001
	// < $17000.10


double calcCommision(int);

double calcCommision(int sales) {
	// This function calculates the commision given the number of sales

	double commision;

	if (sales < 0)
		commision = -1;
	else if (sales <= 100000)
		commision = sales * 0.02;
	else if (sales <= 400000)
		commision = (sales - 100000) * 0.05 + 2000;
	else
		commision = (sales - 400000) * 0.1 + 17000;
	//end if

	return commision;

}

void number20();

void number20() {
	// This is the function for question number 20, it calculates the commision for a number of sales

	int sales = 0;
	double commision = 0.0;

	cout << "Sales: ";
	cin >> sales;

	commision = calcCommision(sales);

	if (commision != -1) {
		cout << fixed << setprecision(2);
		cout << "Commision: $" << commision << endl;
	}
	else {
		cout << "The sales cannot be less than 0." << endl;
	} 
	//end if

}

// END NUMBER 20 FUNCTIONS

// BEGIN NUMBER 18 FUNCTIONS

	// Test Cases:
	
	// > 5
	// > 5
	// > 5
	// < 15
	// < F

	// > 300
	// > 20
	// < 320
	// < A

	// > 200
	// > 81
	// < 281
	// < B

int getScore();

int getScore() {
	//This function prompts the user for a score

	int score;
	cout << "Enter Next Score (-1 To Stop): ";
	cin >> score;
	return score;

}

char getLetterGrade(int);

char getLetterGrade(int score) {
	// This function gets the letter grade of a given score

	if (score >= 315) {
		return 'A';
	}
	else if (score >= 280) {
		return 'B';
	}
	else if (score >= 245) {
		return 'C';
	}
	else if (score >= 210) {
		return 'D';
	}
	else {
		return 'F';
	} 
	// end if

}

void number18();

void number18() {
	// This is the function for question number 18, it allows the user to enter scores and then shows the total and letter grades
	
	int score = 0;
	int total = 0;

	while (score != -1) {
		score = getScore();
		if (score != -1) {
			total += score;
		}
		// end if
	}
	// end while

	cout << "Total: " << total << endl;
	cout << "Letter Grade: " << getLetterGrade(total) << endl;

}

// END NUMBER 18 FUNCTIONS

int main()
{
	//This function is run when the program starts
	//It asks for a question number and runs the corresponding function if the question number is correct

	int questionNumber;
	cout << "Select Question Number: ";
	cin >> questionNumber;

	switch (questionNumber){
		case 18:
			number18();
			break;
		case 20:
			number20();
			break;
		case 22:
			number22();
			break;
		case 23:
			number23();
			break;
		default:
			cout << "Invalid question" << endl;
			break;
	}
	// end switch

	system("pause");
	return 0;
}
