using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

// Marta Polishchuk
// 301432299
// COMP100-402
// Assignment 6

namespace Question01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question01: 
            //DisplayMenu();

            //Question02: Modify your main so that the DisplayMenu method is called repeatedly. The program should terminate when the user enters 0. Any other choice should produce an error message. No arithmetic is involved so user input can be accepted as an int, char or string. Use a do-while loop to do the repetitions and a switch to check for user options. 

            int choice;//variable for choice chosen, no need for a counter variable

            do
            {
                DisplayMenu(); // invoke the method to display the menu
                choice = int.Parse(Console.ReadLine());


                // the if-else statement below was my attempt at trying to accept user input as int, string, or char. The idea was to TryParse the input to int; if it worked- the program would continue onto the switch statements; if not - it would execute the else statemment which would ask for a valid input, and then continue on to another iteration of the loop. I could not get it to work - the else statement would execute regardless of the input. 

               /* if (int.TryParse(Console.ReadLine(), out choice)) 
                { */
                    switch (choice) // Switch statements for each menu option:
                    {
                        case 3: //Question03
                            Console.WriteLine(" "); //empty lines for readability
                            Console.WriteLine("The sum is: " + CalculateSum(5) + ".");
                            Console.WriteLine(" ");
                            break;
                        case 4: //Question04
                            Console.WriteLine(" ");
                            Console.Write("Please enter the prefered number of inputs: ");
                            int inputs = int.Parse(Console.ReadLine());
                            Console.WriteLine("The Sum of Squares is: " + CalculateSumOfSquares(inputs) + ".");
                            Console.WriteLine(" ");
                            break;
                        case 5: //Question05
                            Console.WriteLine(" ");
                            Console.WriteLine("The Sum of Cubes is: " + CalculateSumOfCubes() + ".");
                            Console.WriteLine(" ");
                            break;
                        case 0: // added a case for 0 because otherwise the loop exits but also displays the error message, but 0 is a valid option.
                            Console.WriteLine(" ");
                            Console.WriteLine("Program Exited");
                            Console.WriteLine(" ");
                            break;
                        case 6://Question06
                            Console.WriteLine(" ");
                            Console.WriteLine("The average is: " + CalculateAverage() + ".");
                            Console.WriteLine(" ");
                            break;
                        default: //Error message
                            Console.WriteLine(" ");
                            Console.WriteLine("Error. Select a valid option.");
                            Console.WriteLine(" ");
                            break;
                    }
                /*}
                else
                {
                    Console.WriteLine("Please enter a valid input");
                    continue;
                }*/

            } while (choice != 0); // as long as user doesn't input 0 the loop will continue

        }

        //----------- NETHODS: ----------//

        /* Question01: Write a method with the following specifications: 
            name: DisplayMenu
            arguments: none
            return value: none
            tasks: display the following menu choice on the screen:
                Calculation Menu
                3) Calculate Sum
                4) Calculate Sum of Squares
                5) Calculate Sum of Cubes
                0) To Exit
                Enter the number that corresponds to your choice. 
        
       You don’t have to implement the functionalities of the various menu choices at this stage. Call this method from your main. */

        public static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu:");
            Console.WriteLine("  3) Calculate Sum");
            Console.WriteLine("  4) Calculate Sum of Squares");
            Console.WriteLine("  5) Calculate Sum of Cubes");
            Console.WriteLine("  6) Calculate Average"); //Option added as of Question06
            Console.WriteLine("  0) To Exit");
            Console.WriteLine(" ");
            Console.Write("Enter the number that corresponds to your choice: ");
        }

        /* Question03: Write a method with the following specifications: 
                name: CalculateSum 
                arguments: a single int representing the number of inputs that will constitute the sum
                return value: int representing the sum of all the user inputs
                displays: only the prompt for the user inputs (does not display the sum)
                tasks: prompt and accepts inputs(as many as specified by the argument), and sum them, Finally the method      will return the sum of all the inputs(the sum). 

        In your main you will call this method when the user enters 3 in response to the menu choices. You will invoke this method with argument 5 and then display the resulting value from the method. */

        public static int CalculateSum(int inputs)
        {
            Console.Write("Please enter the prefered number of inputs: ");
            inputs = int.Parse(Console.ReadLine());
            int sum = 0; // have to declare sum out here so it can be used in the for loop & for the return value

            for (int counter = 1; counter <= inputs; counter++)
            {
                Console.Write($"Enter number {counter}: "); //counter will keep track of input # for user
                int number = int.Parse(Console.ReadLine()); // need a new variable for the inputs themselves
                sum += number; // need to add numbers to themselves each iteration of the loop and assign this value to a variable
            }
            return sum;
        }

        /* Question04: Write a method with the following specifications:
                name: CalculateSumOfSquares
                arguments: int representing the number of input that will constitute the sum
                return value: int representing the sum of the squares of its input
                displays: the user prompts but NOT the sum of the squares
                tasks: prompt the user for inputs and accumulates the sum of the squares of the input. This is repeated as specified by the argument. Returns the final sum 

            In your main when the user enters 4 in response to the menu choices, you will prompt the user for the number of inputs that she will be working with. You will invoke this method with this value and display the resulting value. */

        public static int CalculateSumOfSquares(int inputs)
        {
            int sum = 0;

            for (int counter = 1; counter <= inputs; counter++)
            {
                Console.Write($"Please enter number {counter}: ");
                int number = int.Parse(Console.ReadLine()); //collecting user input for each number 
                //need to square the number and assign value to an integer that is then added to the sum
                int square = number * number;
                sum += square;
            }
            return sum;
        }

        /* Question05: Write a method with the following specifications:
                name: CalculateSumOfCubes
                arguments: none
                return value: int representing the sum of the cubes of its input
                displays: the user prompts but NOT the sum of the cubes 
                tasks: 
                    •prompt the user for the number of inputs that she will be working with
                    •read in the user input
                    •Prompts the user for their input
                    •Accumulates the sum of the cubes input
                    •Repeat the above two steps are many times as required
                    •Returns the final sum 
            In your main when the user enters 5 in response to the menu choices, you will invoke this method and display the resulting value. */

        public static int CalculateSumOfCubes()
        {
            int sum = 0; //return variable 
            Console.Write("Please enter the prefered number of inputs: "); //user prompt
            int inputs = int.Parse(Console.ReadLine()); //user input

            for (int counter = 1; counter <= inputs; counter++)
            {
                Console.Write($"Enter input {counter}: "); //user prompt
                int number = int.Parse(Console.ReadLine()); //user input for number
                int cube = number * number * number; //cube the number and assign value to a variable
                sum += cube; //add cube value to the sum
            }
            return sum;
        }

        /* Question06: Write a method with the following specifications:
                name: CalculateAverage
                arguments: none
                return value: double representing the mathematical average of its inputs
                displays: the user prompts but NOT the average
                tasks: prompt and accept for the number of inputs that she will be working with. Prompts the user for the required number of inputs. Calculate and return the average of the inputs. 

        Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes. In your main when the user enters the appropriate choice in response to the menu choices, you will invoke this method and display the resulting value.*/

        public static double CalculateAverage()
        {
            int sum = 0; 
            Console.Write("Please enter the prefered number of inputs: "); //user prompt for # of inputs
            int inputs = int.Parse(Console.ReadLine()); //user input assigned to a variable

            for (int counter = 1; counter <= inputs; counter++)
            {
                Console.Write("Enter input " + counter + ": "); //user prompt for input values
                int number = int.Parse(Console.ReadLine()); //user input assigned to variable 
                sum += number; //gather the sum of all inputs 
            }
            double average = (double)sum / inputs; //return variable initialized & value assigned 
            return average;
        }

    }
}
