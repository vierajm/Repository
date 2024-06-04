using System;

namespace Module4Program
{
    class program
    {
        static void Main(string[] args)
        {
			 // Program notes:
             // Ran program and tested various inputs
             // Added Overflow Exception
			 // Added more detailed error messages
			 // Testing without try-catch blocks resulted in command termination of signal 6
             int x;
             int y;
             int result;

            try {
            Console.Write("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            result = x / y;

            Console.WriteLine($"The result of {x} divided by {y} is: {result}");
            }
            catch (FormatException ex)
            {
				Console.WriteLine("Please enter only numbers.");
				Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error Details: Cannot divide by zero.");
				Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (OverflowException ex)
            {
				Console.WriteLine("Error Details: Number is too long.");
				Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            catch (Exception ex)
            {
				Console.WriteLine("Error Details: Something went wrong.");
				Console.WriteLine($"Detailed error message: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
