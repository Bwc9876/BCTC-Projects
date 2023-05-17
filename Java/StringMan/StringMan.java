import javax.swing.JOptionPane;

/* Test Case:

New Mexico (shhh):

	Should be:
		10
		new mexico
		NEW MEXICO
		N

*/

public class StringMan{
	
	public static void main(String[] args){
		
		String cityName = JOptionPane.showInputDialog("Enter Your Favourite City's Name: ");
		
		if (cityName != null && cityName.length() > 0){
		
			System.out.println("The number of characters in that name is: " + cityName.length());
			
			System.out.println("That name in lowercase is: " + cityName.toLowerCase());
			
			System.out.println("That name in uppercase is: " + cityName.toUpperCase());
			
			System.out.println("The first letter of that name is: " + cityName.charAt(0));
		
		}
		else {
			
			System.out.println("Name cannot be empty!");
			
		}
		
	}
	
}