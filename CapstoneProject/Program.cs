using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    //********************************
    //Project:Capstone Project
    //Author: Richard Robertson
    //Program Type: Application
    //Date Created: 11/30/2018
    //Date Modified: 12/5/2018
    //*********************************
    class Program
    {

        static void Main(string[] args)
        {


            string userName;
            bool runApp = true;
            WelcomeScreen();
            userName = GetUserName();
            Introduction(userName);
            InitializeFlashLight();
            Inventory key = new Inventory();
            key.CanUnlockDoor = false;
            Inventory drawerHandle = new Inventory();
            drawerHandle.unlockDrawer = false;
            Inventory codePaper = new Inventory();
            codePaper.Number = 0;
            do
            {
                MainMenu(userName, drawerHandle, key, codePaper);
            } while (runApp);
            ClosingScreen();
        }



        //First MENU
        static bool MainMenu(string userName, Inventory drawerHandle, Inventory key, Inventory codePaper)
        {
            bool runApp = true;
            string menuChoice;

            DisplayHeader("\n\t\tMain Menu\n");

            Console.WriteLine("You are In the Center of the Room");
            Console.WriteLine();
            Console.WriteLine("\tA) Examine the door");
            Console.WriteLine("\tB) Check the right side of the room");
            Console.WriteLine("\tC) Check the left side of the room");
            Console.WriteLine("\tQ) Quit");
            Console.WriteLine();
            Console.Write("Enter a Menu choice:");
            menuChoice = Console.ReadLine().ToUpper();

            switch (menuChoice)
            {

                case "A":
                    ExamineDoorMenu(userName, drawerHandle, key, codePaper);
                    break;

                case "B":
                    RightSideMenu(userName, drawerHandle, key, codePaper);
                    break;

                case "C":
                    LeftSideMenu(userName, drawerHandle, key, codePaper);
                    break;
                case "Q":
                    runApp = false;

                    break;

                default:
                    Console.WriteLine("please enter \"A\" ,\"B\",\"C\", Or\"Q\" ");
                    Console.WriteLine("press any key to try again");
                    Console.ReadKey();
                    break;


            }
            return runApp;
        }

        #region RIGHTSIDE MENUS
        //RightSideRoom
        static void RightSideMenu(string userName, Inventory drawerHandle, Inventory key, Inventory codePaper)
        {

            string menuChoice;
            DisplayHeader("\t\t\tRight side of room\n");

            Console.WriteLine();
            Console.WriteLine("On the right side of the room you see a small endtable with a picture,");
            Console.WriteLine("and a drawer missing a handle.");
            Console.WriteLine();
            Console.WriteLine("what do you do?");
            Console.WriteLine();
            Console.WriteLine("\tA) look at the picture");
            Console.WriteLine("\tB) try to open the drawer");
            Console.WriteLine("\tC) return to the center of the room");
            Console.WriteLine("\tD) go to the left side of the room");
            Console.WriteLine();
            menuChoice = Console.ReadLine().ToUpper();
            switch (menuChoice)
            {
                case "A":
                    PictureMenu(userName, drawerHandle, key, codePaper);
                    break;

                case "B":
                    DrawerMenu(userName, drawerHandle, key, codePaper);

                    break;

                case "C":
                    MainMenu(userName, drawerHandle, key, codePaper);
                    break;
                case "D":
                    LeftSideMenu(userName, drawerHandle, key, codePaper);
                    break;

                default:
                    Console.WriteLine("please enter \"A\" ,\"B\",\"C\", Or\"D\" ");
                    Console.WriteLine("press any key to try again");
                    Console.ReadKey();
                    break;
            }

        }

        static void DrawerMenu(string userName, Inventory drawerHandle, Inventory key, Inventory codePaper)
        {
            string menuChoice;
            DisplayHeader("\t\t\tThe Drawer\n");
            Console.WriteLine();
            Console.WriteLine($"{userName} looks at the drawer.");
            Console.WriteLine("there does not seem to be a handle to be able to open it.");
            Console.WriteLine();
            Console.WriteLine("\tA) Try to open drawer.");
            Console.WriteLine("\tB) return to the center of the room");
            Console.WriteLine("\tC) go to the left side of the room");
            Console.WriteLine();
            menuChoice = Console.ReadLine().ToUpper();
            switch (menuChoice)
            {
                case "A":
                    if (drawerHandle.unlockDrawer == true)
                    {
                        Console.WriteLine($"{userName} used the drawer handle to open the drawer and found a key inside!");
                        key.CanUnlockDoor = true;
                        DisplayContinuePrompt();
                    }
                    else
                    {
                        Console.WriteLine("You do not have a handle to open the drawer");
                        DisplayContinuePrompt();
                    }
                    break;

                case "B":
                    MainMenu(userName, drawerHandle, key, codePaper);
                    break;

                case "C":
                    LeftSideMenu(userName, drawerHandle, key, codePaper);
                    break;
                default:
                    Console.WriteLine("please enter a valid option [\"A\", \"B\", or \"C\"]");
                    DisplayContinuePrompt();
                    break;
            }
        }

        //picture frame
        static void PictureMenu(string userName, Inventory drawerHandle, Inventory key, Inventory codePaper)
        {
            string menuChoice;
            DisplayHeader("\t\t\t Picture\n");
            Console.WriteLine();
            Console.WriteLine($"{userName} picks up the picture. it is a picture of a small cabin in the woods");
            Console.WriteLine("the corner of the picture seems a off-color");
            Console.WriteLine();
            Console.WriteLine("\tA) Use flashlight on picture");
            Console.WriteLine("\tB) return to the center of the room");
            Console.WriteLine("\tC) go to the left side of the room");
            Console.WriteLine();
            menuChoice = Console.ReadLine().ToUpper();
            switch (menuChoice)
            {
                case "A":
                    Console.WriteLine("the picture revealed a small piece of paper with the numbers 2174 written on it.");
                    codePaper.Number = 2174;
                    DisplayContinuePrompt();
                    RightSideMenu(userName, drawerHandle, key, codePaper);
                    break;

                case "B":
                    MainMenu(userName, drawerHandle, key, codePaper);
                    break;

                case "C":
                    LeftSideMenu(userName, drawerHandle, key, codePaper);
                    break;
                default:
                    Console.WriteLine("please enter a valid option [\"A\", \"B\", or \"C\"]");
                    DisplayContinuePrompt();
                    break;


            }
        }
        #endregion

        #region LEFTSIDE MENUS
        //Left Side of Room
        static void LeftSideMenu(string userName, Inventory drawerHandle, Inventory key, Inventory codePaper)
        {
            string menuChoice;
            DisplayHeader("\t\t\tLeft Side of the Room\n");
            Console.WriteLine();
            Console.WriteLine($"on the left side of the room, {userName} sees a small safe with a combination lock on an endtable.");
            Console.WriteLine();
            Console.WriteLine("\tA) try to open the safe");
            Console.WriteLine("\tB) return to the center of the room");
            Console.WriteLine("\tC) go to the right side of the room");
            Console.WriteLine();
            menuChoice = Console.ReadLine().ToUpper();
            switch (menuChoice)
            {
                case "A":
                    LockBoxMenu(userName, drawerHandle, key, codePaper);
                    break;

                case "B":
                    MainMenu(userName, drawerHandle, key, codePaper);
                    break;

                case "C":
                    RightSideMenu(userName, drawerHandle, key, codePaper);
                    break;




                default:
                    Console.WriteLine("please enter \"A\" ,\"B\", or \"C\" ");
                    Console.WriteLine("press any key to try again");
                    Console.ReadKey();
                    break;
            }



        }
        //LockBoxMenu
        static void LockBoxMenu(string userName, Inventory drawerHandle, Inventory key, Inventory codePaper)
        {
            string codeEnter;
            int Code;
            DisplayHeader("\t\t\t Opening the LockBox\n");
            Console.WriteLine();
            Console.WriteLine("\tA) Enter Code");
            Console.WriteLine("\tB) check Paper");
            Console.WriteLine("\tC) go back");
            codeEnter = Console.ReadLine().ToUpper();
            switch (codeEnter)
            {
                case "A":
                    Console.WriteLine("please enter the code to unlock");
                    codeEnter = Console.ReadLine();
                    int.TryParse(codeEnter, out Code);
                    if (Code == 2174)
                    {
                        Console.WriteLine($"{userName} opened the lockbox and found a drawer handle");
                        drawerHandle.unlockDrawer = true;
                        DisplayContinuePrompt();
                        LeftSideMenu(userName, drawerHandle, key, codePaper);
                    }
                    else
                    {
                        Console.WriteLine("you did not enter the correct code");
                        DisplayContinuePrompt();
                        LockBoxMenu(userName, drawerHandle, key, codePaper);
                    }

                    LeftSideMenu(userName, drawerHandle, key, codePaper);
                    break;
                case "B":
                    Console.WriteLine($"the piece of paper says {codePaper.Number}");
                    DisplayContinuePrompt();
                    LockBoxMenu(userName, drawerHandle, key, codePaper);
                    break;
                default:
                    Console.WriteLine("Please enter a menu choice \"A\" or \"B\"");
                    DisplayContinuePrompt();
                    break;
                case "C":
                    LeftSideMenu(userName, drawerHandle, key, codePaper);
                    break;
            }

        }

        #endregion

        #region DOOR

        //Examine Door
        static void ExamineDoorMenu(string userName, Inventory drawerHandle, Inventory key, Inventory codePaper)
        {
            string menuChoice;

            DisplayHeader("\t\t\tExamining the Door\n");

            Console.WriteLine($"{userName} walks up to the door");
            Console.WriteLine();
            Console.WriteLine("what do you do?");
            Console.WriteLine("\tA) Try to open the door");
            Console.WriteLine("\tB) Go back to the center of the room");
            menuChoice = Console.ReadLine().ToUpper();
            switch (menuChoice)
            {
                case "A":
                    DoorLocked(userName, drawerHandle, key, codePaper);
                    break;

                case "B":
                    MainMenu(userName, drawerHandle, key, codePaper);
                    break;

                default:
                    Console.WriteLine("please enter a valid option [\"A\", or \"B\"]");
                    break;

            }
        }

        //door is locked
        static void DoorLocked(string userName, Inventory drawerHandle, Inventory key, Inventory codePaper)
        {
            
            DisplayHeader("\t\t\t open the door\n");
            if (key.CanUnlockDoor == true)
            {

                GameWon(userName);
                
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("The door is Locked");
                DisplayContinuePrompt();
                ExamineDoorMenu(userName, drawerHandle, key, codePaper);
            }
            
        }

        #endregion

        #region INVENTORY
        //inventory Menu
        static void ShowInventory()
        {
            DisplayHeader("\n\t\t\tInventory\n");



            DisplayContinuePrompt();

        }

        //add safecode to inventory
        static Inventory InitializeCodePaper()
        {
            Inventory CodePaper = new Inventory();
            CodePaper.CanUnlockDoor = false;
            CodePaper.Number = 0;
            CodePaper.unlockDrawer = false;
            CodePaper.uselight = false;

            return CodePaper;
        }

        //add flashlight to inventory
        static Inventory InitializeFlashLight()
        {
            Inventory Flashlight = new Inventory();
            Flashlight.uselight = true;
            Flashlight.unlockDrawer = false;
            Flashlight.CanUnlockDoor = false;
            return Flashlight;
        }

        //add drawer handle to inventory
        static Inventory InitializeDrawerHandle()
        {
            Inventory DrawerHandle = new Inventory();
            DrawerHandle.CanUnlockDoor = false;
            DrawerHandle.unlockDrawer = true;


            return DrawerHandle;
        }

        // add key to inventory
        static Inventory InitializeKey()
        {
            Inventory key = new Inventory();

            key.CanUnlockDoor = false;
            key.unlockDrawer = false;
            key.uselight = false;
            return key;
        }
        #endregion


        #region HELPERS



        //Win Screen    
        static void GameWon(string userName)
        {
            DisplayHeader("\t\t\tCongratulations!\n\n");

            Console.WriteLine();
            Console.WriteLine($"\t\t{userName} walks through the door and suddenly");
            Console.WriteLine(" wakes up in their own bed and realized it was all a dream......");
            Console.WriteLine();
            Console.WriteLine("\t\tNice Job!");
            Console.WriteLine();
            Console.WriteLine("press the enter key to exit the program");
            Console.ReadLine();
         
        }

        //get user name
        static string GetUserName()
        {
            string userName;
            DisplayHeader("\t\t\tGet User Name\n");
            Console.WriteLine("what is your name?");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}.");
            DisplayContinuePrompt();
            return userName;
        }

        //Intro
        static void Introduction(string userName)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"{userName} wakes up in a room they have never seen before.");
            Console.WriteLine("It is not a large room, but on both sides there is a lot of clutter all around.");
            Console.WriteLine("The  room has no windows but is lit well and has only one door directly ahead.");
            DisplayContinuePrompt();
        }

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
            Console.WriteLine("You will be met with a series of choices on actions to take, inventory to use, ");
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
            Console.WriteLine("thank you for playing!");
            Console.WriteLine();
            Console.WriteLine("press enter key to exit");
            Console.ReadLine();
        }
        #endregion
    }
}




