namespace MethodOverloading
{
    public class Program
    {
	//create a method named add that accepts two ints and returns the sum
	public static int Add (int a, int b)
	{
		return (a + b);
	}

	// now create an overload of add that allows you to add two decimals together
	public static decimal Add (decimal a, decimal b)
	{
		return (a + b);
	}
	// now create another overload of the Add method that returns a string and accepts 3 parameters
	// two integers and one boolean
	public static string Add (int a, int b, bool c)
	{
		while (c == true) 
		{
			if (a + b == 1)
			{
				return "1 dollar";
			}
			else
			{
				int output = (a + b);
				Console.WriteLine($"{output} dollars.");
				return "";
			}
		
		}
			return "";
	}		

        static void Main(string[] args)
        {
		var x = 13;
		var y = 12;

		var answer = Add(x,y);

		decimal c = 15.1m;
		decimal d = 16.7m;

		var decAnswer = Add(c,d);

		var third = Add(1, 3, true);


        }
	
    
}
}
