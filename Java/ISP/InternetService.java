//Program Name: InternetService
//Programmer  : Ben Crocker
//Date        : 12-21-20
//Purpose	  : Calculate the user's monthly charge and display saving oppurtunities


import javax.swing.JOptionPane;


/* Test Cases:

	----------------
	Plan A:
		>A
		>20
		<29.95
		<You'd save $16.00 With Plan B
		<You'd save $10.00 With Plan C
	Plan B:
		>B
		>15
		<13.95
	Plan C:
		>C
		>50
		<19.95
	----------------
	
*/


public class InternetService{
	
	private static float OptionA(int hours, boolean calculateSavings){
		//This function calculates the cost for Option A
		//It first sets constants and then see if the user used extra hours
		//If they did, calculate how much money they need to pay
		//Either way, see if any other plan would save them money and tell them
		//Finally, return the monthly price
		
		final float monthlyRate = 9.95f;
		final int maxHoursUntilOverPay = 10;
		final float overPayRate = 2.00f;
		
		float overPayCost = 0f;
		
		if (hours > maxHoursUntilOverPay){
			
			int overPayHours = hours - maxHoursUntilOverPay;
			overPayCost = overPayHours * overPayRate;
			
		}
		
		float totalCost = monthlyRate + overPayCost;
		
		if (calculateSavings){
			
			float savingsWithB = totalCost - OptionB(hours, false);
			if (savingsWithB > 0f) System.out.printf("You'd save $%.2f With Plan B \n", savingsWithB);
			float savingsWithC = totalCost - OptionC(hours);
			if (savingsWithC > 0f) System.out.printf("You'd save $%.2f With Plan C \n", savingsWithC);
			
		}
		
		return totalCost;
		
	}
	
	private static float OptionB(int hours, boolean calculateSavings){
		//This function calculates the cost for Option B
		//It first sets constants and then see if the user used extra hours
		//If they did, calculate how much money they need to pay
		//Either way, see if plan C would save them money and tell them
		//Finally, return the monthly price
		
		
		final float monthlyRate = 13.95f;
		final int maxHoursUntilOverPay = 20;
		final float overPayRate = 1.00f;
		
		float overPayCost = 0f;
		
		if (hours > maxHoursUntilOverPay){
			
			int overPayHours = hours - maxHoursUntilOverPay;
			overPayCost = overPayHours * overPayRate;
			
		}
		
		float totalCost = monthlyRate + overPayCost;
		
		if (calculateSavings){
			
			float savingsWithC = totalCost - OptionC(hours);
			if (savingsWithC > 0f) System.out.printf("You'd save $%.2f With Plan C \n", savingsWithC);
			
		}
		
		return totalCost;
		
	}
	
	private static float OptionC(int hours){
		//This function calculates the cost for Option A
		//It simply returns the monthly rate
		
		final float monthlyRate = 19.95f;
		float totalCost = monthlyRate;
		return totalCost;
		
	}
	
	public static void main(String[] args){
		//This code is run at the start of the program
		//It first asks the user their plan
		//It then asks the hours of internet used
		//Then, it figures out which plan to calculate based off the input
		//Finally, it prints the cost of the plan
		
		String serviceOption = JOptionPane.showInputDialog("Enter Your Package (A, B, or C)");
		if (serviceOption != null && serviceOption.length() > 0){
			
			String rawHours = JOptionPane.showInputDialog("Enter Your Hours Used");
			int hours = -1;
			
			try{
				
				hours = Integer.parseInt(rawHours);
				
			} catch (NumberFormatException ne){
				
				System.out.println("Hours Must Be Numeric!");
				
			}
			
			if (hours != -1){
			
				float totalCharge = -1f;
				
				switch(serviceOption.toUpperCase()){	
					case "A":
						totalCharge = OptionA(hours, true);
						break;
					case "B":
						totalCharge = OptionB(hours, true);
						break;
					case "C":
						totalCharge = OptionC(hours);
						break;
					default:
						System.out.println("Invalid Package Option");
						break;
				}
				
				if (totalCharge != -1f){
					
					System.out.printf("Total Charge: $%.2f", totalCharge);
					
				}
			
			}
			
			
		} else {
			
			System.out.println("Invalid Package Option");
			
		}
		
	}
	
}