using System;

class Reverse
{
	public static void Main(String [] args)
	{
		int myNumber, reversedNumber=0, remainderValue;
		Console.WriteLine("Enter a number: ");
		myNumber = Convert.ToInt32(Console.ReadLine());

		while(myNumber > 0)
		{
			remainderValue = myNumber % 10;
			reversedNumber = reversedNumber * 10 + remainderValue;
			myNumber = myNumber / 10;
		}
		Console.WriteLine("The Reversed Number is: " +reversedNumber);
	}
}