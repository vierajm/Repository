using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		Motorcycle motorcycle = new Motorcycle(200);
		
		motorcycle.Speed = 5000;
		
		Console.WriteLine(motorcycle.Speed);
		
		Console.ReadKey();
	}
}
class Motorcycle
{
	private int speed;
	
	public Motorcycle(int speed)
	{
		Speed = speed;
	}
	
	public int Speed 
	{ 
		get { return speed; }
		set 
		{
			if(value > 400)
			{
				speed = 400;
			}
			else
			speed = value;
		}
	}

}
