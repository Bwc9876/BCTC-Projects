//Program Name: Rectangle Area
//Programmer  : Ben Crocker
//Date        : 5/14/21
//Purpose	  : Calculate the area of a rectangle


import javax.swing.JOptionPane;


/* Test Cases:

	> 5
	> 5
	< 25	
	
*/

public class RectangleArea{
		
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
	
	private static double getWidth(){
		/**
			Gets the width of the rectangle from the user
			@return The width of the rectangle
		*/
		
		String rawWidth = JOptionPane.showInputDialog("Enter Width");
		if (isValid(rawWidth, "Width")) {	
			return Double.parseDouble(rawWidth);
		} else 
		{
			return -1.0;
		}
		//end if
		
	}
	
	private static double getHeight(){
		/**
			Gets the height of the rectangle from the user
			@return the height of the rectangle
		*/
		
		String rawWidth = JOptionPane.showInputDialog("Enter Height");
		if (isValid(rawWidth, "Height")) {	
			return Double.parseDouble(rawWidth);
		} else {
			return -1.0;
		}
		//end if
		
	}
	
	private static double calcArea(double width, double height) {
		/**
			Calculates the area of a rectangle
			@param width the width of the rectangle
			@param height the height of the rectangle
			@return the area of the rectangle
		*/
		
		return width * height;
		
	}
	
	private static void displayData(double area) {
		/**
			Displays the area of the rectangle to the user
			@param the area of the rectangle
		*/
		
		System.out.printf("The area is: %.2f \n", area);
		
	}
	
	public static void main(String[] args){
		/*
			This code is run at the start of the program
			It gets width & height from the user, then calculates and displays the area
		*/
		
		double width = getWidth();
		double height = getHeight();
		if (width != -1 && height != -1) {
			
			double area = calcArea(width, height);
			displayData(area);
			
		}
		//end if
	
	}
	
}