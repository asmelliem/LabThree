using System;

namespace LabThree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            var proceed = "";
            do
            {
                Console.WriteLine("Enter a whole number between 1 and 100");
                var numberInput = Console.ReadLine();
                
                var validNumber = int.TryParse(numberInput, out var number);

                if (!validNumber || (number > 100 || number < 1))
                {
                    Console.WriteLine("You didn't enter a valid number");
                    Console.WriteLine("");
                    proceed = "Y";
                    continue;
                }

                if (IsEven(number))
                {
                    Console.WriteLine(DetermineEvenOutput(number, name));
                }
                else
                {
                    Console.WriteLine(DetermineOddOutput(number, name));
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                proceed = Console.ReadLine().ToUpper();
            } while (string.Equals(proceed, "Y"));

            Console.WriteLine("Goodbye!");
        }


        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        public static string DetermineEvenOutput(int value, string name)
        {
            if (value >= 2 && value < 25)
            {
                return $"\nHello {name}\nEven and less than 25.";
            }
            else if (value >= 26 && value <= 60)
            {
                return $"\nHello {name}\nEven.";
            }
            else
            {
                return $"\nHello {name}\n{value} Even";
            }
        }

        public static string DetermineOddOutput(int value, string name)
        {
            //redundant, but following the logic as specified in the assignment
            //normally, would have similar pattern to DetermineEvenOutput()
            if (value > 60)
            {
                return $"\nHello {name}\n{value} Odd";
            }
            else
            {
                return $"\nHello {name}\n{value} Odd";
            }
        }
    }
}
