using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3E2_Rework
{
    internal class Program
    {
      
        

                //Create method
                static int RollDice()
                {
                    int retVal = 0; //declare return value

                    //process
                    Random random = new Random();

                    int randomNumber = random.Next(1, 7); //generate a number form 1 to 6

                    retVal = randomNumber;

                    return retVal; //return value back

                }

                  static void Main(string[] args)
                { 
                    //declaration
                    string userInput = "";
                    int userGuess = 0;
                    int rollNumber = 0;

                    
                    //game title
                    Console.WriteLine("Welcome to RollDice Game!");

                    do
                    {
                        //process if user does not input QUIT
                        Console.WriteLine("Enter a number from 1 to 6 or type QUIT to exit?");
                        userInput = Console.ReadLine();

                        if (userInput == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            try
                            {
                                userGuess = Convert.ToInt32(userInput); //Convert the user input & hold guess

                                rollNumber = RollDice(); //get the roll number

                                Console.WriteLine("You rolled " + rollNumber);

                                //determine the winner
                                if (userGuess > rollNumber)
                                {
                                    Console.WriteLine("You won!");
                                }
                                else if (userGuess < rollNumber)
                                {
                                    Console.WriteLine("You lost! Try again!");
                                }
                                else
                                {
                                    Console.WriteLine("it is a tie");
                                }

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Please input a valid number");
                            }

                        }

                    }
                    while (userInput != "QUIT");
                    Console.WriteLine("The application exits");
                    Console.ReadLine();

                }
            }
        }

