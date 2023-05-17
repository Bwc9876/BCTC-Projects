//Program Name: Fat Grams
//Programmer  : Ben Crocker
//Date        : 12-21-20
//Purpose	  : Calculate the grams of calories from fat


import javax.swing.JOptionPane;


/* Test Cases:

	----------------
	1. Basic Use:
		> 100
		> 4
		< %36.0
	2. Low Fat:
		> 100
		> 2
		< %18.0
		< Low In Fat
	3. Calories From Fat > Total;
		> 100
		> 50
		< Error!
	----------------
	
*/

public class FatGRams{

	public static void main(String[] args){
		//This code is run when the program is started
		//It first sets up constants
		//It then gets the calories and fat grams from the user
		//It then calculates teh calories from fat and then determines the percentage
		//Finally, it displays the percent to teh user and whether it's low in fat
		
		final double LOW_FAT_PERCENTAGE = 30.0;
		
		String rawCalories = JOptionPane.showInputDialog("Enter Total Calories");
		String rawFat = JOptionPane.showInputDialog("Enter Fat In Grams");
		
		boolean caloriesIsValid = IsValid(rawCalories, "Calories");
		boolean fatIsValid = IsValid(rawFat, "Fat");
		
		if (caloriesIsValid && fatIsValid){
			
			double totalCalories = Double.parseDouble(rawCalories);
			double gramsOfFat = Double.parseDouble(rawFat);
			
			double caloriesFromFat = gramsOfFat * 9.0;
			
			if (totalCalories > caloriesFromFat){
				
				double percentFat = (caloriesFromFat / totalCalories) * 100;
				System.out.printf("Percent Calories From Fat: %.1f \n", percentFat);
				if (percentFat < LOW_FAT_PERCENTAGE) System.out.println("This item is low in fat");
				
			} else {
				
				System.out.println("Calories from fat can't be greater than total calories!");
				
			}
			
			
		}
	
	}
	
	private static boolean IsValid(String toCheck, String displayName){
		//This code is run to check if a given string is valid
		//It first makes sure the string isn't empty
		//It then makes sure the string is numeric
		//Finally, it checks if the number in the string is over 0
		
		if (toCheck != null && toCheck.length() > 0){
			
			try{
				
				double testValue = Double.parseDouble(toCheck);
				
				if (testValue > 0){
					
					return true;
					
				} else {
					
					System.out.println(displayName + " Must Be Over 0!");
					return false;
					
				}
				
				
			} catch (NumberFormatException ne) {
				
				System.out.println(displayName + " Must Be Numeric!");
				return false;
				
			}
			
		} else {
			
			System.out.println(displayName + " Can't Be Empty!");
			return false;
			
		}
		
	}
	
}