/*
	Program Name: 11_07_03
	Programmer: Ben Crocker
	Date: 5/12/21
	Purpose: Perform a wide variety of tasks using void functions
*/

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

//Number 23 Functions

// Test Cases:
//
// > 3000
// > 2000
// < 1000
// < 110

void getInput(int &newReading, int &oldReading);
void calcBill(int curRead, int prevRead, double chgPerUnit, int &numUnits, double &totChg);
void displayBill(int used, double charge);

void getInput(int &newReading, int &oldReading)
{
	//This function gets the readings from the user

	cout << "Current reading: ";
	cin >> newReading;
	cout << "Previous reading: ";
	cin >> oldReading;
}

void calcBill(int curRead, int prevRead, const double chgPerUnit, int &numUnits, double &totChg)
{
	//This function calculates the difference between readings and the total charge

	numUnits = curRead - prevRead;
	totChg = numUnits * chgPerUnit;
}

void displayBill(int used, double charge)
{
	//This function displays the bill to the user

	cout << "Units used: " << used << endl;
	cout << "Total charge: $" << charge << endl;
}

void number23();
void number23() {
	// This is the function for question 23, it gets the previous and current readings on a meter and gives you the bill

	const double UNIT_CHG = .11;
	int current = 0;
	int previous = 0;
	int units = 0;
	double total = 0.0;

	cout << fixed << setprecision(2);

	getInput(current, previous);
	calcBill(current, previous, UNIT_CHG, units, total);
	displayBill(units, total);
}

// Number 22 Functions

// Test Cases
//
// > 5
// > 5
// > 5
// < 15
//
// > 1
// > 2
// > 3
// < 6

void getTestScore(int, double &);

void getTestScore(int number, double &score) {
	//This function is used to obtain a test score from the user

	cout << "Enter Test Score #" << number << ": ";
	cin >> score;

}

void calcAverage(double, double, double, double &);

void calcAverage(double score1, double score2, double score3, double &avg) {
	//This function is used to find the average of three test scores

	avg = (score1 + score2 + score3) / 3.0;

}

void number22();

void number22() {
	//This is the function for question number 23
	//It gets three test scores and returns their averages

	double score1;
	double score2;
	double score3;

	getTestScore(1, score1);
	getTestScore(2, score2);
	getTestScore(3, score3);

	double average;
	calcAverage(score1, score2, score3, average);

	cout << fixed << setprecision(1);
	cout << "Average: " << average << endl;

}

// Number 19 Functions

// Test Cases:
//
// > 5000
// < 1000
// < 400
// < 3600

void getSalary(double &);
void getSalary(double &salary) {
	// This function gets the salary from the user

	cout << "Enter Salary: $";
	cin >> salary;

}

void displayInfo(double, double, double);
void displayInfo(double fwtTax, double ficaTax, double netPay) {
	// This function display payment info to the user

	cout << fixed << setprecision(2);
	cout << "FWT: $" << fwtTax << endl;
	cout << "FICA: $" << ficaTax << endl;
	cout << "Net Pay: $" << netPay << endl;

}

void calcNetPay(double, double, double, double&);
void calcNetPay(double grossPay, double fwtTax, double ficaTax, double &netPay) {
	// This function is used to calculate the net pay

	netPay = grossPay - fwtTax - ficaTax;

}

void calcFedTaxes(double, const double, const double, double &, double &);
void calcFedTaxes(double salary, const double fwtRate, const double ficaRate, double &fwtTax, double &ficaTax) {
	// This function is used to calculate the federal taxes given a salary and their rates

	fwtTax = salary * fwtRate;
	ficaTax = salary * ficaRate;

}

void number19();
void number19() {
	// This is the function for question 19, given salaries it displays the taxes and net pays for each

	const double FWT_RATE = 0.2;
	const double FICA_RATE = 0.08;

	double salary;
	getSalary(salary);
	while (salary > 0) {
		double ficaTax;
		double fwtTax;
		calcFedTaxes(salary, FWT_RATE, FICA_RATE, fwtTax, ficaTax);
		double netPay;
		calcNetPay(salary, fwtTax, ficaTax, netPay);
		displayInfo(fwtTax, ficaTax, netPay);
		getSalary(salary);
	}
	// end while
	

}


// Number 18 Functions

// Test Cases:
//
// > 162
// > 9
// < 81
// < 50%

void calcFatCals(int, int &);
void calcFatCals(int fatGrams, int &fatCals) {
	// This function calculates the fat calories given the fat grams

	fatCals = fatGrams * 9;
}

void calcFatPercent(int, int, double &);
void calcFatPercent(int fatCals, int totalCals, double &fatPercent) {
	// This fucntion calculates the fat percentage based off the fat calories and the total calories

	fatPercent = static_cast<double>(fatCals) / static_cast<double>(totalCals) * 100;
}

void number18() {
	// This is the function for question number 18, it calculates and displays the fat in grams, and the amount of calories that are from fat

	int totalCals;
	int fatGrams;
	int fatCals;
	double fatPercent = 0.0;
	cout << "Total calories: ";
	cin >> totalCals;
	cout << "Grams of fat: ";
	cin >> fatGrams;

	if (totalCals >= 0 && fatGrams >= 0)
	{
		calcFatCals(fatGrams, fatCals);
		calcFatPercent(fatCals, totalCals, fatPercent);
		cout << "Fat calories: " << fatCals << endl;
		cout << fixed << setprecision(0);
		cout << "Fat percentage: " << fatPercent << "%" << endl;
	}
	else
	{
		cout << "Input Error" << endl;
	}
	//end if

}


// Number 16 Functions

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

void getScore(int &);

void getScore(int &score) {
	//This function prompts the user for a score

	cout << "Enter Next Score (-1 To Stop): ";
	cin >> score;
}

void getLetterGrade(int, char &);

void getLetterGrade(int score, char &grade) {
	// This function gets the letter grade of a given score

	if (score >= 315) {
		grade = 'A';
	}
	else if (score >= 280) {
		grade = 'B';
	}
	else if (score >= 245) {
		grade = 'C';
	}
	else if (score >= 210) {
		grade = 'D';
	}
	else {
		grade = 'F';
	}
	// end if

}

void number16() {
	// This is the function for question number 16, it allows the user to enter scores and then shows the total and letter grades

	int score = 0;
	int total = 0;

	while (score != -1) {
		getScore(score);
		if (score != -1) {
			total += score;
		}
		// end if
	}
	// end while

	char grade;
	getLetterGrade(total, grade);

	cout << "Total: " << total << endl;
	cout << "Letter Grade: " << grade << endl;

}


int main()
{
	//This function is run when the program starts
	//It asks for a question number and runs the corresponding function if the question number is correct

	int questionNumber;
	cout << "Select Question Number: ";
	cin >> questionNumber;
	switch (questionNumber) {
		case 16:
			number16();
			break;
		case 18:
			number18();
			break;
		case 19:
			number19();
			break;
		case 22:
			number22();
			break;
		case 23:
			number23();
			break;
		default:
			cout << "Invalid Question" << endl;
			break;
	}
	// end switch
	system("pause");
	return 0;
}
