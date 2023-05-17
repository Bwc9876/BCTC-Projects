/*
Program name: Miles Per Gallon
Programmer: Ben Crocker
Date: 10/20/20
Purpose: Assist the user in finding out the miles per gallon of a trip
*/

import javax.swing.JOptionPane;


public class MilesPerGal{

	public static void main(String[] args){
		/*
			This code is run when the program starts
			It first asks the user for the miles driven and the gas used in gallons
			It then checks to make sure that the user entered the data in correctly
			Then, it calculates the milePerGal by dividing the milesDriven by the gallonsUsed
			Finally, it outputs the result of the calculation
		*/
	
		String rawMilesDriven = JOptionPane.showInputDialog("How many miles did you drive?");
		String rawGallonsUsed = JOptionPane.showInputDialog("How many gallons of gas did you use?");
		
		if (IsValid(rawMilesDriven) && IsValid(rawGallonsUsed)){
			
			Double milesDriven = null;
			Double gallonsUsed = null;
			
			try{
				
				milesDriven = Double.parseDouble(rawMilesDriven);
				gallonsUsed = Double.parseDouble(rawGallonsUsed);
				
			}
			catch (NumberFormatException nf){
				
				System.out.println("Inputs must be numeric!");	
				
			}
			
			if (milesDriven != null && gallonsUsed != null){
				
				if (milesDriven > 0 && gallonsUsed > 0){
					Double milePerGal = milesDriven / gallonsUsed;
					
					System.out.println("The Miles Per Gallon is: " + milePerGal);
				}
				else {
					
					System.out.println("Inputs must be positive!");
					
				}
				
			}
			
		}
		else {
			
			System.out.println("No Inputs can be empty!");
			
		}
	
	}
	
	private static boolean IsValid(String toCheck){
		
		if (toCheck != null && toCheck.length() > 0){
			
			return true;
			
		}
		else {
			
			return false;
			
		}
		
	}

}