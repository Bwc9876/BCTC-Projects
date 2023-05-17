//Program Name: Bank System
//Programmer  : Ben Crocker
//Date        : 12-21-20
//Purpose	  : Calcualte the fee a bank needs for checks


import javax.swing.JOptionPane;


/* Test Cases:

	----------------
	1. Low:
		>15
		<11.50
	2. Between:
		>57
		<13.42
	3. Max:
		>67
		<12.68
	----------------
	
*/

public class BankSystem{

	public static void main(String[] args){
		//This code is run when the program starts
		//It first sets up constants
		//It then gets & checks checks from the user
		//Then, it determines the needed fee to apply based on the number of checks
		//Finally, it calculates the total fee and outputs it
		
		final float BASE_FEE = 10.0f;
		
		String rawChecks = JOptionPane.showInputDialog("How many checks did you write?");
		
		boolean checksIsValid = IsValid(rawChecks, "Checks");
		
		if (checksIsValid){
			
			int checks = Integer.parseInt(rawChecks);
			
			float checkFeeRate;
			
			if (checks < 20){
				
				checkFeeRate = 0.10f;
				
			} else if (checks <= 39) {
				
				checkFeeRate = 0.08f;
				
			} else if (checks <= 59) {
				
				checkFeeRate = 0.06f;
				
			} else {
				
				checkFeeRate = 0.04f;
				
			}
			
			float checkFee = checks * checkFeeRate;
			
			float totalFee = BASE_FEE + checkFee;
			
			System.out.printf("Total Fee: $%.2f", totalFee);
			
		}
		
		
	
	}
	
	private static boolean IsValid(String toCheck, String displayName){
		//This code is run to check if a given string is valid
		//It first makes sure the string isn't empty
		//It then makes sure the string is numeric
		//Finally, it checks if the number in the string is over 0
		
		if (toCheck != null && toCheck.length() > 0){
			
			try{
				
				double testValue = Integer.parseInt(toCheck);
				
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