//Program Name: Conversion
//Programmer  : Ben Crocker
//Date        : 5/14/21
//Purpose	  : Convert from meters to a variety of units


import javax.swing.JOptionPane;


/* Test Cases:

	> 5000
	> 1
	< 5
	> 2
	< 196850
	> 3
	< 16405
	> 4
	*exits*
	
*/

public class Conversion{
	
	private static boolean isValid(String toCheck, String displayName){
		/**
			Validates a given input
			@param toCheck The input to check
			@param displayName the name to display if this input is invalid
			@return a boolean saying whether the input is valid
		*/
		
		if (toCheck != null && toCheck.length() > 0){
			
			try{
				
				double testValue = Double.parseDouble(toCheck);
				
				if (testValue > 0){
					
					return true;
					
				} else {
					
					System.out.println(displayName + " Must Be Over 0!");
					return false;
					
				}
				//end if
				
				
			} catch (NumberFormatException ne) {
				
				System.out.println(displayName + " Must Be Numeric!");
				return false;
				
			}
			//end try catch
			
		} else {
			
			System.out.println(displayName + " Can't Be Empty!");
			return false;
			
		}
		//end if
		
	}
	
	private static void showKilometers(double meters) {
		/**
			Shows the meters in kilometers
			@param meters the meters to convert
		*/
		
		System.out.printf("%.2f kilometers \n", meters * 0.001);
		
	}
	
	private static void showInches(double meters) {
		/**
			Shows the meters in inches
			@param meters the meters to convert
		*/
		
		System.out.printf("%.2f inches \n", meters * 39.37);
		
	}
	
	private static void showFeet(double meters) {
		/**
			Shows the meters in feet
			@param meters the meters to convert
		*/
		
		System.out.printf("%.2f feet \n", meters * 3.281);
		
	}
	
	private static void menu(){
		/**
			Displays a menu for the user to select a unit or exits*
		*/
		
		System.out.println("1. Kilometers\n2. Inches\n3. Feet\n4. Quit");
		
	}

	public static void main(String[] args){
		/*
			This code is run when the program starts
			It first gets meters from the user
			It then allows the user to convert to kilometers, inches, and feet
			It keeps doing this until the user exits
		*/
		
		boolean done = false;
		
		String rawMeters = JOptionPane.showInputDialog("Enter Meters");
		
		if (isValid(rawMeters, "Meters")) {
			
			double meters = Double.parseDouble(rawMeters);
			
			while (done != true) {
			
				menu();
				String choice = JOptionPane.showInputDialog("Select Option #");
				switch (choice) {
					case "1":
						showKilometers(meters);
						break;
					case "2":
						showInches(meters);
						break;
					case "3":
						showFeet(meters);
						break;
					case "4":
						done = true;
						break;
					default:
						System.out.println("Invalid Choice");
						break;
				}
				//end switch
			}
			//end while
		}
		//end if
	}
	
}