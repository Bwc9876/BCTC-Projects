//Program Name: BodyMassIndex
//Programmer  : Ben Crocker
//Date        : 12-15-20
//Purpose	  : Calculate the user's BMI and show a related message


import javax.swing.JOptionPane;


/* Test Cases:

	----------------
	Underweight:
		>72
		(5,184)
		> 100
		(70,300)
		< 13.5
		< Underweight	
	Optimal:
		> 72
		(5,184)
		> 140
		(98,420)
		< 18.9
		< Optimal	
	Overweight:
		> 72
		(5,184)
		> 250
		(175,750)
		> 33.9
		> Overweight
	----------------
	
*/


public class BodyMassIndex{

	public static void main(String[] args){
		//This code is run at the start of the program
		//It first sets up constants
		//Then, it asks the user for weight & height
		//It then checks if both values enetered are valid, it will only go forward if both are valid
		//It then calculates the BMI and chooses what message to display depending on it's value
		
		final double MIN_OPTIMAL_BMI = 18.5;
		final double MAX_OPTIMAL_BMI = 25.0;
			
		String rawHeight = JOptionPane.showInputDialog("What Is Your Height? (in)");
		String rawWeight = JOptionPane.showInputDialog("What Is Your Weight? (lbs)");
			
		boolean heightIsValid = IsValid(rawHeight, "Height");
		boolean weightIsValid = IsValid(rawWeight, "Weight");
		
		if (heightIsValid && weightIsValid){
		
			double height = Double.parseDouble(rawHeight);
			double weight = Double.parseDouble(rawWeight);
			
			double bmi = (weight * 703.0) / (height * height);
			String message;
			
			if      (bmi < MIN_OPTIMAL_BMI) message = "You Are Underweight"; 
			else if (bmi > MAX_OPTIMAL_BMI) message = "You Are Overweight";
			else                            message = "You Are In The Optimal Range!";
			
			System.out.printf("Your BMI is: %.2f \n", bmi);
			System.out.println(message);	
		
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