//Program Name: Falling Distance
//Programmer  : Ben Crocker
//Date        : 5/14/21
//Purpose	  : Calculates the distance an object fell for up to 10 seconds


import javax.swing.JOptionPane;

/*
	
	Test Cases
	
	> 5
	< 122.5
	
*/

public class FallingDistance{
	
	private static double fallingDistance(int time, final double GRAVITY_CONSTANT) {
		/**
			Gets the distance fallen given the time spent fallingDistance
			@param time how much time has passed
			@param GRAVITY_CONSTANT the gravity constant in the equation
			@return the distance fallen
		*/
		
		return 0.5 * GRAVITY_CONSTANT * (time * time);
	}

	public static void main(String[] args){
		/*
			This code is run when the program starts
			It calculate the distance fallen after 1-10 seconds
		*/
		
		final double GRAVITY_CONSTANT = 9.8;
		
		for (int time = 1; time <= 10; time++) {
			
			System.out.printf(time + ": %.2f meters \n", fallingDistance(time, GRAVITY_CONSTANT));
			
		}
		//end for
		
	
	}
	
}