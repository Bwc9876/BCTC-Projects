/*

	Program name: Test Average
	Programmer: Ben Crocker
	Date: 10/20/20
	Purpose: Assist the user in finding out the average score of three tests
	
	
	Test Case:
	
	> = Input
	< = Expected Output
	
	>4
	>3
	>2
	
	<Test 1: 4
	<Test 2: 3
	<Test 3: 2
	<Average: 3
	
*/

import java.util.Scanner;
import javax.swing.JOptionPane;

public class TestAverage{

	public static void main (String[] args){
		/*
			This code is run at the start of the program
			It first asks the user for all three test scores
			It then checks to see if they are all valid
			If they are, then the program outputs all the test scores
			Then it calculates the average by adding them and dividing the sum by 3
			Finally, it outputs the average
		*/
		
		String rawTest1 = JOptionPane.showInputDialog("Enter test 1 score: ");
		String rawTest2 = JOptionPane.showInputDialog("Enter test 2 score: ");
		String rawTest3 = JOptionPane.showInputDialog("Enter test 3 score: ");
		
		boolean test1IsValid = IsValid(rawTest1, "Test 1 Score");
		boolean test2IsValid = IsValid(rawTest2, "Test 2 Score");
		boolean test3IsValid = IsValid(rawTest3, "Test 3 Score");
		
		if (test1IsValid && test2IsValid && test3IsValid){
			
			Double test1 = Double.parseDouble(rawTest1);
			Double test2 = Double.parseDouble(rawTest2);
			Double test3 = Double.parseDouble(rawTest3);
			
			System.out.println("Test 1 Score: " + test1);
			System.out.println("Test 2 Score: " + test2);
			System.out.println("Test 3 Score: " + test3);
			
			Double average = (test1 + test2 + test3) / 3.0;
			
			System.out.println("Average is: " + average);
			
		}
		
	}
	
	private static boolean IsValid(String toCheck, String displayName){
		/*
			This code is run to check if an input is valid
			It first makes sure that the input isn't empty
			It then makes sure that the input is numeric
			The, it checks to see if the input negative
			If any of these check fail, then the program notifies the user and return false
			If all of them succed, then the program returns true
		*/
		
		if (toCheck != null && toCheck.length() > 0){
			
			try {
				
				Double numberToCheck = Double.parseDouble(toCheck);
				
				if (numberToCheck >= 0) {
					
					return true;
					
				}
				else {
					
					System.out.println(displayName + ": Input can't be negative!");
					return false;
					
				}
				
			}
			catch (NumberFormatException nfe) {
				
				System.out.println(displayName + ": Input must be numeric!");
				return false;
				
			}
			
		}
		else {
			
			System.out.println(displayName + ": Input can't be empty!");
			return false;
			
		}
		
	}
	

}