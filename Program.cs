using Microsoft.Win32.SafeHandles;

public class Program
{
    static void Main() {

        
        //1. Write a C# program that reads a file path from the user and tries to open the file.
        //Handle exceptions if the file does not exist.
        try {
            Task2();
        } catch(Exception ex) {
            Console.WriteLine("An error occured in Task 2: ");
            Console.WriteLine(ex.Message);
        }
        //3. Write a C# program that implements a method that takes an array of integers as input
        //and calculates the average value. Handle the exception if the array is empty.

        try {
            Task4();
        } catch(Exception ex) {
            Console.WriteLine("An error occured in Task 4: ");
            Console.WriteLine(ex.Message);
        }
        try {
            Task5();
        } catch(Exception ex) {
            Console.WriteLine("An error occured in Task 5: ");
            Console.WriteLine(ex.Message);
        }
        try {
            Task6();
        } catch(Exception ex) {
            Console.WriteLine("An error occured in Task 6: ");
            Console.WriteLine(ex.Message);
        }

        //7. Write a C# program that creates a method that reads a date from the user in the
        //format "dd/mm/yyyy" and converts it to a DateTime object. Handle an exception if the
        //input format is invalid.

        
        try {
            Task8();
        } catch(Exception ex) {
            Console.WriteLine("An error occured in Task 8: ");
            Console.WriteLine(ex.Message);
        }
        try {
            Task9();
        } catch(Exception ex) {
            Console.WriteLine("An error occured in Task 9: ");
            Console.WriteLine(ex.Message);
        }

        //Write a C# program that creates a method that calculates the factorial of a given
        //number. Handle the OverflowException that occurs if the result exceeds the Int32
        //maximum value.

    }

    public static void Task2(){
        //2. Write a C# program that prompts the user to input a numeric integer and throws an
        //exception if the number is less than 0 or greater than 1000.

        Console.WriteLine("Task 2");
        Console.WriteLine("Input a number from 0 to 1000");
        int num1 = int.Parse(Console.ReadLine());
        if (num1 < 0 || num1 > 1000) {
            throw new ArgumentOutOfRangeException("Number should only be between 0 and 1000");
        } else {
            Console.WriteLine("Your number is " + num1.ToString());
        }
    }

    public static void Task4(){
        //4. Write a C# program that reads a string from the user and converts it to an integer.
        //Handle the exception if the input cannot be parsed into an integer.
        Console.WriteLine("Task 4");
        Console.WriteLine("Input a number");
        bool isNum2aNumber = int.TryParse(Console.ReadLine(), out int x);

        if (!isNum2aNumber) {
            Console.WriteLine("The input you entered is not a number!");
        }

    }

    public static void Task5() {
        
        //5. Write a C# program that reads a list of integers from the user. Handle the exception
        //that occurs if the user enters a value outside the range of Int32.
        int[] numbers = {};
        bool exit = false;
        while (!exit){
            Console.WriteLine("Enter a number to add on the list. enter any text to exit");
            bool isThisANumber = int.TryParse(Console.ReadLine(), out int numToAdd);
            exit = !isThisANumber;

            numbers.Append(numToAdd);
        }
        Console.WriteLine("The Numbers you added are:");
        foreach (var item in numbers)
        {
            Console.Write(item.ToString() + ", ");
        }
    }

    public static void Task6() {
        
        //6. Write a C# program that implements a method that divides two numbers. Handle the
        //DivideByZeroException that occurs if the denominator is 0.
        Console.WriteLine("Task 6");
        Console.WriteLine("Enter the dividend:");
        int dividend = int.Parse(Console.ReadLine());
        int divisor = 0;
        
        while(divisor == 0) {
            Console.WriteLine("Enter the divisor:");
            divisor = int.Parse(Console.ReadLine());
            if (divisor == 0) {
                Console.WriteLine("Divisor cannot be 0");
            }
        }
        Console.WriteLine("quotient is " + (dividend/divisor).ToString());
    }

    public static void Task8() {
            //8. Write a C# program that reads a number from the user and calculates its square root.
        //Handle the exception if the number is negative.
        Console.WriteLine("Task 8");
        int squareNumber = -1;
        
        while(squareNumber < 0) {
            Console.WriteLine("Enter the a number to determine the square root:");
            squareNumber = int.Parse(Console.ReadLine());
            if (squareNumber < 0) {
                Console.WriteLine("number can't be negative");
            }
        }
        Console.WriteLine("Square root of " + squareNumber.ToString() +  " is " + Math.Sqrt(squareNumber).ToString());
    }

    public static void Task9() {
        //9. Write a C# program that creates a method that takes a string as input and converts it
        //to uppercase. Handle the NullReferenceException that occurs if the input string is
        //null.
        Console.WriteLine("Task 9");
        
        string testToUpper = "";
        while (string.IsNullOrEmpty(testToUpper))
        {
            testToUpper = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(testToUpper))
                Console.WriteLine("You entered an empty string, try again");        
        }
        Console.WriteLine(testToUpper.ToUpper());
    }

    // public static void Task10(){
    //     Console.WriteLine("Enter a number to get its factorial");
    //     int factorialNumber = int.Parse(Console.ReadLine());

    //     int result = 1;
    //     for (factorialNumber; )
    // }

}