using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES or NO:");
            string noiseChoice = Console.ReadLine();
            string raisedNoiseChoice = noiseChoice.ToUpper();

            if (raisedNoiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("YOU FAILED! THE END.");
            }
            else if (raisedNoiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
                Console.WriteLine("You walk towards it. Do you open it or knock?");
                Console.WriteLine("Type OPEN or KNOCK:");
                string doorChoice = Console.ReadLine();
                string raisedDoorChoice = doorChoice.ToUpper();
                if (raisedDoorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Enter a number (1-3): ");
                    string keyChoice = Console.ReadLine();
                    string raisedKeyChoice = keyChoice.ToUpper();
                    switch (raisedKeyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Nothing except gold and jewels and rubies");
                            Console.WriteLine("WELL DONE! THE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.");
                            Console.WriteLine("YOU FAILED! THE END");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.");
                            Console.WriteLine("YOU FAILED! THE END");
                            break;
                        default:
                            Console.WriteLine("I am sorry, I don't understand");
                            break;
                    }
                }
                else if (raisedDoorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says,\"Answer this riddle: ");
                    Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    Console.WriteLine("Type your answer: ");
                    string riddleAnswer = Console.ReadLine();
                    string raisedRiddleAnswer = riddleAnswer.ToUpper();
                    if (raisedRiddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.");
                        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                        Console.WriteLine("WELL DONE! THE END");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.");
                        Console.WriteLine("YOU FAILED! THE END");
                    }
                }
                else
                {
                    Console.WriteLine("I am sorry, I don't understand");
                }
            }
            else
            {
                Console.WriteLine("I am sorry, I don't understand");
            }
        }
    }
}