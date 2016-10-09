using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
             {

            
            
                Console.Clear();
                //asks for the x of their problem
                Console.WriteLine("What is your X(m)?");
                
                //turns the x input into a readable floating point number.
                float x = float.Parse(Console.ReadLine());
              
                
                while (true)
                {
                    //ask the time for their problem 
                    Console.Clear();
                    Console.WriteLine("What is your X(m)?");
                    Console.WriteLine(x);
                    Console.WriteLine("What is your time(s)?");
                    float t = float.Parse(Console.ReadLine());
            
                 //Decides whether the number produced is valid
                 if (t < 0)
                 {
                     Console.Clear();
                     Console.WriteLine("Since when did time flow BACKWARDS?!? That is not a valid number for time!");
                     Thread.Sleep(2000);
                     continue;
                }
                    if (t == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("DIDN'T YOU LEARN ANYTHING FROM THE MOVIES?!? You can't be in two places at once!");
                        Thread.Sleep(2000);
                        continue;
                    }
                    else
                    {

                        //clears the screen and says "finding the V"
                        Console.Clear();
                        Console.WriteLine("Finding the answers for which you seek... One moment please!");
                        Thread.Sleep(2000);

                        //Clears the screen
                        Console.Clear();

                        //Finds the Velocity
                        float V = x / t;

                        //Writes the Velocity to the screen
                        Console.WriteLine("WE GOT THE VELOCITY!");
                        Console.WriteLine("Your Velocity is: " + V + "m/s");
                        Console.WriteLine(" ");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        
                        break;
                    }

                        
                }

                //clears the screen and asks the user a Q
                Console.Clear();
                Console.WriteLine("Would you like to continue?(Y/N)");

                //stores their answer
                string answer = Console.ReadLine();

                //if the answer is yes then it starts back at the top.    
                if (answer.ToLower() == "y" )
                {
                    continue;
                }

              // if the answer is not then it checks whether or not is a no or an invalid answer. 
              while (true)
                {

                    // only comes into play if the answer is invalid.
                    if (answer.ToLower() == "y")
                    {
                        break;
                    }

                    if (answer.ToLower() == "n")
                    {
                        break;
                    }

                    else
                    {
                        //if the answer is invlaid then it asks the question again and starts at the top of the loop.
                        Console.WriteLine("That is not an answer that I can understand. You must input Y or N.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Would you like to continue?(Y/N)");
                        answer = Console.ReadLine();
                        continue;
                       
                    }
                }


                if (answer.ToLower() == "y")
                {
                    continue;
                }

                if (answer.ToLower() == "n")
                {
                    break;
                }
            }
            
            
            //Tells the user Thank You and to use me again.
            Console.Clear();
            Console.WriteLine("Thanks for Using Me! Come again soon!");

            //gives the use time to read the lines on the screen and then automatically closes.
            Thread.Sleep(2000);
        }
    }
}