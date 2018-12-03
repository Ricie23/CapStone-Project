using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{   //********************************
    //Project:Capstone Project
    //Author: Richard Robertson
    //Program Type: Application
    //Date Created: 11/30/2018
    //Date Modified: 12/3/2018
    //*********************************
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            WelcomeScreen();
            userName = GetUserName();
            PartOneMenu(userName);

        }
       
        //First MENU
        static bool PartOneMenu(string userName)
        {
            bool runApplication = true;

            string menuChoice;

            DisplayHeader("\n\t\tPart 1\n");
            Console.WriteLine($"{userName} wakes up in a room they have never seen before.");
            Console.WriteLine("It is not a large room, but on both sides there is a lot of clutter all around.");
            Console.WriteLine("The  room has no windows but is lit well and has only one door directly ahead.");
            Console.WriteLine($"what does {userName} do?");
            Console.WriteLine();
            Console.WriteLine("\tA) Examine the door");
            Console.WriteLine("\tB) Check the right side of the room");
            Console.WriteLine("\tC) Check the left side of the room");
            Console.WriteLine("\tD) Chek the area behind you");
            Console.WriteLine("\tQ) Quit");
            Console.WriteLine();
            Console.Write("Enter a Menu choice:");
            menuChoice = Console.ReadLine().ToUpper();

            switch (menuChoice)
            {

                case "A":

                    break;

                case "B":

                    break;

                case "C":

                    break;

                case "Q":
                    runApplication = false;
                    break;

                default:
                    Console.WriteLine("please enter \"A\" ,\"B\",\"C\", Or\"Q\" ");
                    Console.WriteLine("press any key to try again");
                    Console.ReadKey();
                    break;
            }

            return runApplication;
        }
        //Examine Door
        static void ExamineDoorMenu(string userName)
        { string menuChoice;
            DisplayHeader("\t\t\tExamining the Door\n");
            
            Console.WriteLine($"{userName} walks up to the door");
            Console.WriteLine();
            Console.WriteLine("what do you do?");
            menuChoice=Console.ReadLine().ToUpper();
            switch (menuChoice)
            {   case

                default:
                    Console.WriteLine("please enter a valid menu option [A] [B] [C] [I] [Q]");
                    break;

            }
        }
        //RightSideRoom
        static void RightSideMenu(string userName)
        {

        }

        //get user name
        static string GetUserName(){
        string userName;
            DisplayHeader("\t\t\tGet User Name\n");
            Console.WriteLine("what is your name?");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}.");
            DisplayContinuePrompt();
            return userName;
        }

#region
        //CONTINUE PROMPT      
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("press enter to conitinue");
            Console.ReadLine();
        }


        //WELCOME SCREEN
        static void WelcomeScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\t\tWelcome to my Capstone Project\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is an escape room type text-based game.");
            Console.WriteLine("your goal is to figure out how to escape the room!");
            Console.WriteLine("You will be met with a series of choices on actions to take, inventory to use, " );
            Console.WriteLine("or inventroy to gather.");   
            Console.WriteLine("Have Fun!");

            DisplayContinuePrompt();
        }


        //HEADER        
        static void DisplayHeader(string headerText)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine(headerText);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }


        //CLOSING SCREEN     
        static void ClosingScreen()
        {

            DisplayHeader("\t\tClosing Screen");
            Console.WriteLine("It's been fun!");
            Console.WriteLine();
            Console.WriteLine("press enter key to exit");
            Console.ReadLine();
        }
        #endregion


    }
}
