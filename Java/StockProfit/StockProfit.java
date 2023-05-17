//Program Name: Stock Profit
//Programmer  : Ben Crocker
//Date        : 5/14/21
//Purpose	  : Calculate the profit made from a stock purchase


import javax.swing.JOptionPane;


/* Test Cases:

	> 35
	> 44.90
	> 4.95
	> 44.39
	> 4.95
	< 7.95
	
*/

public class StockProfit{
	
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
	
	private static double stockProfit(double sharesPurchased, double saleRate, double saleCommision, double purchaseRate, double purchaseCommision) {
		/**
			Gets the profit of a given stock purchase
			@param sharesPurchased number of shares purchased
			@param saleRate price per share at time of sale
			@param saleCommision commision at time of sale
			@param purchaseRate price per share at time of purchase
			@param purchaseCommision commision rate at time of purchase
			@return the profit made (or lost)
		*/
		
		return ((sharesPurchased * saleRate) - saleCommision) - ((sharesPurchased * purchaseRate) + purchaseCommision);
		
	}

	public static void main(String[] args){
		/*
			This code is run at the start of the program
			It gets the stock data from the user
			It then checks is everything is valid
			Finally, it calculates and displays the profit
		*/
	
		String rawPurchased = JOptionPane.showInputDialog("Enter Shares Purchased");
		String rawSaleRate = JOptionPane.showInputDialog("Enter Sale Share Price");
		String rawSaleCommision = JOptionPane.showInputDialog("Enter Sale Commision");
		String rawPurchaseRate = JOptionPane.showInputDialog("Enter Purchase Share Price");
		String rawPurchaseCommision = JOptionPane.showInputDialog("Enter Purchase Commision");
		
		boolean purchasedValid = isValid(rawPurchased, "Shares Purchased");
		boolean saleRateValid = isValid(rawSaleRate, "Sale Share Price");
		boolean saleCommisionValid = isValid(rawSaleCommision, "Sale Commision");
		boolean purchaseRateValid = isValid(rawPurchaseRate, "Purchase Share Price");
		boolean purchaseCommisionValid = isValid(rawPurchaseCommision, "Purchase Commision");
		
		
		if (purchasedValid && saleRateValid && saleCommisionValid && purchaseRateValid && purchaseCommisionValid) {
			
			double sharesPurchased = Double.parseDouble(rawPurchased);
			double saleRate = Double.parseDouble(rawSaleRate);
			double saleCommision = Double.parseDouble(rawSaleCommision);
			double purchaseRate = Double.parseDouble(rawPurchaseRate);
			double purchaseCommision = Double.parseDouble(rawPurchaseCommision);
			
			double profit = stockProfit(sharesPurchased, saleRate, saleCommision, purchaseRate, purchaseCommision);
			
			System.out.printf("$%.2f", profit);
			
		}
		//end if
	
	}
	
	
	
}