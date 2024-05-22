namespace Conditions_Loops
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Which Question would you like to run?");
            Console.WriteLine("1 - Question_1");
            Console.WriteLine("2 - Question_2");
            Console.WriteLine("3 - Question_3");
            Console.WriteLine("4 - Question_4");
            Console.WriteLine("5 - Question_5");
            Console.WriteLine("6 - Question_6");

            string? userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Question_1();
            }
            else if (userInput == "2")
            {
                Question_2();
            }
            else if (userInput == "3")
            {
                Question_3();
            }
            else if(userInput == "4") 
            {
                Question_4();
            }
            else if (userInput == "5")
                {
                Question_5();
            }
            else if (userInput == "6") 
            {
                Question_6();
            }
            else
            {
                Console.WriteLine("Thankg you have a great day");
            }
        }

        public static void Question_1()
        {// Prompt the user to enter a number
            Console.Write("Please enter a Number: ");

            // Read the user input
            string? userInput = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(userInput, out int number))
            {
                // Determine if the number is positive, negative, or zero
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }
            }
            else
            {
                // Inform the user that the input was not a valid integer
                Console.WriteLine("The input is not a valid integer. Please try again.");
            }
        }
        public static void Question_2()
        { // Prompt the user to enter the first number
            Console.Write("Please enter the first number: ");
            string? input1 = Console.ReadLine();

            // Prompt the user to enter the second number
            Console.Write("Please enter the second number: ");
            string? input2 = Console.ReadLine();

            // Prompt the user to enter the third number
            Console.Write("Please enter the third number: ");
            string? input3 = Console.ReadLine();

            // Try to parse the inputs to integers
            if (int.TryParse(input1, out int number1) &&
                int.TryParse(input2, out int number2) &&
                int.TryParse(input3, out int number3))
            {
                // Determine the largest of the three numbers
                int largest = number1;

                if (number2 > largest)
                {
                    largest = number2;
                }

                if (number3 > largest)
                {
                    largest = number3;
                }

                // Display the largest number
                Console.WriteLine("The largest number is: " + largest);
            }
            else
            {
                // Inform the user that one or more inputs were not a valid numbere
                Console.WriteLine("One or more inputs are not valid numbers. Please try again.");
            }
        }
        public static void Question_3()
        {
            {
                // Prompt the user to enter an alphabet
                Console.Write("Please enter an alphabet: ");
                string input = Console.ReadLine().ToLower(); // Convert input to lowercase for uniformity

                // Check if the input is a single character and a letter
                if (input.Length == 1 && char.IsLetter(input[0]))
                {
                    char letter = input[0];

                    // Check if the letter is a vowel
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        Console.WriteLine("The alphabet is a vowel.");
                    }
                    else
                    {
                        Console.WriteLine("The alphabet is a consonant.");
                    }
                }
                else
                {
                    // Inform the user that the input is not a valid single alphabet letter
                    Console.WriteLine("The input is not a valid single alphabet letter. Please try again.");
                }
            }
        }
        public static void Question_4()
        { // Prompt the user to enter a number
            Console.Write("Please enter a number: ");
            string? input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out int number))
            {
                // Print the multiplication table up to 10
                Console.WriteLine($"Multiplication table for {number}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                // Inform the user that the input was not a valid integer
                Console.WriteLine("The input is not a valid integer. Please try again.");
            }
        }
        public static void Question_5()
        {
            Console.Write("Enter a number: ");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true; // 2 is the only even prime number
            if (number % 2 == 0) return false; // All other even numbers are not primes

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void Question_6()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

    
