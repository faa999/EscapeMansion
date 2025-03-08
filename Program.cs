using System;
using System.Data;

namespace EscapeMansion
{
    class Program
    {

        static void Main(string[] args)

        {

            bool gameOver = false;



            while (!gameOver)

            {

                int health = 100; //Health of Paul 

                Console.Clear();

                Console.WriteLine("ADVENTURE OF PAUL");
                Console.ReadLine();
                Console.WriteLine("\"Press Enter To Read Next Line\"");
                Console.ReadLine();
                Console.WriteLine("As a storm raged outside, brave explorer Paul ventured into a legendary hidden mansion known as The House of Shadows, rumored to hold untold treasures. ");
                Console.WriteLine("Locals warned him that \"no one who enters returns,\" but he pressed on despite the ominous atmosphere. ");

                Console.ReadLine();



                Console.WriteLine("Upon entering, the heavy door slammed shut behind him, sealing his fate. The dark hallway, lined with faded portraits, contained a note that warned: ");
                Console.WriteLine("\"To those who dare enter: Prove your wit or face your doom. Solve my puzzles and find the way or lose yourself within these cursed rooms.\" ");
                Console.ReadLine();


                Console.WriteLine("With a firm grip on his torch, Paul felt the mansion's challenges come to life. \nAs he faced ghostly whispers and intricate puzzles, he was determined to uncover its secrets. \nThe question remained: would he make it out alive?");
                Console.ReadLine();



                Console.Write("Welcome to the Escape Mansion.");

                Console.ReadLine();



                Console.Clear();



                Console.WriteLine("Instructions for Playing Escape Mansion");

                Console.ReadLine();



                Console.WriteLine("Your goal is to survive and escape by making smart choices. You start with 100 health points (HP), and each decision you make will affect your health.\nIf your health reaches 0, the game ends, but you’ll have the option to restart with full health.");
                Console.ReadLine();
                Console.WriteLine("Throughout the game, you’ll face scenarios where you need to choose between options, like doors or objects. Each option will have consequences \nsome will help you progress safely, while others may harm you. To play, simply read the scenario, type the letter corresponding to your choice (A, B, or C),and press Enter. If you choose an invalid option, you’ll lose a small amount of health, so think carefully.");
                Console.ReadLine();
                Console.WriteLine("Pay attention to the descriptions provided in each scenario, as they often contain clues to guide your decisions. If you lose all your health, you’ll be \nasked if you want to restart. Your goal is to escape the mansion alive, so make wise decisions and learn from your mistakes if you need to try again. \nGood luck, and enjoy your adventure!");



                Console.ReadLine();

                Console.Clear();







                // Chapter 1: The Entrance Hall 

                Console.WriteLine("Chapter 1: The Entrance Hall");

                Console.ReadLine();



                Console.WriteLine("Paul stood in the flickering candlelight, surveying the grand entrance hall. The air was thick with the smell of damp wood, and strange shadows danced alongthe walls. Ahead of him were three doors, each marked with a symbol: a snowflake, a flame, and a musical note.");

                Console.ReadLine();



                Console.WriteLine("\nA cold breeze whispered through the keyhole of the snowflake door. The flame door was warm to the touch, and from behind the door with the musical note, he heard a low, humming melody.");
                Console.ReadLine();
                Console.WriteLine("\nWhich door will you choose?");

                Console.WriteLine("A: The door with the snowflake symbol.");

                Console.WriteLine("B: The door with the flame symbol.");

                Console.WriteLine("C: The door with the musical note symbol.");

                Console.Write("\nANSWER: ");

                string choice1 = Console.ReadLine().ToUpper();



                if (choice1 == "A")

                {

                    Console.WriteLine("\nYou chose the snowflake door. A cold breeze chills you to the bone.");

                    Console.WriteLine("You have obtained -20 health because of the cold breeze.");

                    health -= 20;

                }

                else if (choice1 == "B")

                {

                    Console.WriteLine("\nYou chose the flame door. A sudden heat wave washes over you.");

                    Console.WriteLine("You have obtained -20 health because of the flame.");

                    health -= 20;

                }

                else if (choice1 == "C")

                {

                    Console.WriteLine("\nYou chose the musical note door. A haunting melody fills the air.");

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lost -20 HP.");

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))
                {
                    continue;

                }



                Console.ReadLine();



                Console.Clear();





                // Chapter 2: The Trap Room 

                Console.WriteLine("Chapter 2: The Trap Room");

                Console.ReadLine();

                Console.WriteLine("The room you step into is a stone chamber, with cobwebs clinging to the corners. A table stands at the center, holding three objects—a golden key, a rusty dagger, and a tattered map covered in cryptic symbols. A message is carved into the wall:");
                Console.ReadLine();
                Console.WriteLine("\nChoose wisely, for only one object will open the way to freedom."); Console.ReadLine();

                Console.WriteLine("A: The golden key.");

                Console.WriteLine("B: The rusty dagger.");

                Console.WriteLine("C: The tattered map.");

                Console.Write("\nANSWER: ");

                string choice2 = Console.ReadLine().ToUpper();



                if (choice2 == "A")

                {

                    Console.WriteLine("\nYou chose the golden key. A trap is triggered! -20 HP.");

                    health -= 20;

                }

                else if (choice2 == "B")

                {

                    Console.WriteLine("\nYou chose the rusty dagger. The blade nicks your hand! -20 HP.");

                    health -= 20;

                }

                else if (choice2 == "C")

                {

                    Console.WriteLine("\nYou chose the tattered map. It showed you the way ouy it gave you hope +5 HP.");

                    health += 5;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP.");

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 3: The Number Lock 

                Console.WriteLine("Chapter 3: The Number Lock");

                Console.ReadLine();

                Console.WriteLine("You find yourself facing a heavy door sealed with a numeric keypad.Above it, scrawled in red ink, is a puzzle:");

                Console.ReadLine();

                Console.WriteLine("\nSolve this to unlock the door: 5× (4+3) −65 times (4 + 3) - 65× (4+3) −6");

                Console.WriteLine("A: 23");

                Console.WriteLine("B: 29");

                Console.WriteLine("C: 31");

                Console.Write("\nANSWER: ");

                string choice3 = Console.ReadLine().ToUpper();



                if (choice3 == "A")

                {

                    Console.WriteLine("\n A cloud of gas hisses from the walls!... You barely Made it out -20 HP");

                    health -= 20;

                }

                else if (choice3 == "B")

                {

                    Console.WriteLine("The sealed door suddenly opened it it gave you confidence +5 HP");

                    health += 5;

                }

                else if (choice3 == "C")

                {

                    Console.WriteLine("\n A cloud of gas hisses from the walls!... You barely Made it out -20 HP");

                    health -= 20;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP."); // For TESTINGS IF IT WONT END OR LOOP 

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }





                Console.ReadLine();



                Console.Clear();



                // Chapter 4: The Mirror Maze 

                Console.WriteLine("Chapter 4: The Mirror Maze");

                Console.ReadLine();

                Console.WriteLine("The door leads you into a dimly lit maze filled with tall mirrors. Each one reflects you differently—one shows you smiling, another frowning, and a third with a glowing pendant around your neck. A voice echoes through the maze:");

                Console.ReadLine();

                Console.WriteLine("Only true reflection will lead you out.\" ");

                Console.WriteLine("\nWhich reflection do you trust? ");

                Console.WriteLine("A: The smiling reflection. ");

                Console.WriteLine("B: The frowning reflection.");

                Console.WriteLine("C: The reflection with the glowing pendant.");

                Console.Write("\nANSWER: ");

                string choice4 = Console.ReadLine().ToUpper();



                if (choice4 == "A")

                {

                    Console.WriteLine("\nThe mirrors shatter around you, cutting off your escape route! -20 HP");

                    health -= 20;

                }

                else if (choice4 == "B")

                {

                    Console.WriteLine("\nThe mirrors shatter around you, cutting off your escape route! -20 HP");

                    health -= 20;

                }

                else if (choice4 == "C")

                {

                    Console.WriteLine("\nYour true reflection has leaded you out it gave you trust in yourself +5");

                    health += 5;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP."); // For TESTINGS IF IT WONT END OR LOOP 

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 5: The Chess Puzzle 

                Console.WriteLine("Chapter 5: The Chess Puzzle");

                Console.ReadLine();

                Console.WriteLine("After navigating the maze, you enter a room with a life-sized chessboard. Only one piece is on the board: a lone black knight surrounded by white pawns. A plaque beside the board reads: ");

                Console.ReadLine();

                Console.WriteLine("\"To find your path, move the knight to safety in two moves.\" ");

                Console.ReadLine();

                Console.WriteLine("\nWhat is your first move?  ");

                Console.WriteLine("A: Move the knight to the left, then Down. ");

                Console.WriteLine("B: Move the knight to the left, then up. ");

                Console.WriteLine("C: Move the knight one square forward, then two squares left. ");

                Console.Write("\nANSWER: ");

                string choice5 = Console.ReadLine().ToUpper();



                if (choice5 == "A")

                {

                    Console.WriteLine("\nThe chessboard tilts dangerously, threatening to trap you! -20 HP");

                    health -= 20;

                }

                else if (choice5 == "B")

                {

                    Console.WriteLine("\nYou moved the knight correctly, a secret passage opens + 5HP ");

                    health += 5;

                }

                else if (choice5 == "C")

                {

                    Console.WriteLine("\nThe chessboard tilts dangerously, threatening to trap you! -20 HP");

                    health -= 20;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP."); // For TESTINGS IF IT WONT END OR LOOP 

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 6: The Passage 

                Console.WriteLine("Chapter 6: The Passage");

                Console.ReadLine();

                Console.WriteLine("The passage takes you to a large iron door with intricate carvings. A riddle is engraved on the metal surface: ");

                Console.ReadLine();

                Console.WriteLine("\"I am not alive, but I am growing. I do not have lungs, but I need air. I do not have a mouth, but water kills me. What am I?\"  ");

                Console.WriteLine("\nWhat is your answer?  ");

                Console.WriteLine("A: Fire  ");

                Console.WriteLine("B: A shadow ");

                Console.WriteLine("C: A stone");

                Console.Write("\nANSWER: ");

                string choice6 = Console.ReadLine().ToUpper();



                if (choice6 == "A")

                {

                    Console.WriteLine("\nthe door creaks open, revealing a path forward. Your path becomes brigther +5HP ");

                    health += 5;

                }

                else if (choice6 == "B")

                {

                    Console.WriteLine("\nThe door locks tighter, and the walls begin to close in! -20HP.");

                    health -= 20;

                }

                else if (choice6 == "C")

                {

                    Console.WriteLine("\nThe door locks tighter, and the walls begin to close in! -20HP.");

                    health -= 20;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP."); // For TESTINGS IF IT WONT END OR LOOP 

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 7: Freedom or Doom? 

                Console.WriteLine("Chapter 7: Freedom or Doom? ");

                Console.ReadLine();

                Console.WriteLine("You enter a chamber lit by strange symbols carved into the walls. There are three levers—each with a glowing gem above it: one red, one blue, and one green. The air grows colder as you approach. ");

                Console.ReadLine();

                Console.WriteLine("\nWhich lever do you pull to escape? ");

                Console.WriteLine("A: The red gem lever.");

                Console.WriteLine("B: The blue gem lever. ");

                Console.WriteLine("C: The green gem lever. ");

                Console.Write("\nANSWER: ");

                string choice7 = Console.ReadLine().ToUpper();



                if (choice7 == "A")

                {

                    Console.WriteLine("\nThe ceiling trembles, and rocks start to fall! -20HP");

                    health -= 20;

                }

                else if (choice7 == "B")

                {

                    Console.WriteLine("\nA stone wall slides aside, leading to an underground cavern glowing with crystals. +5HP");

                    health += 5;

                }

                else if (choice7 == "C")

                {

                    Console.WriteLine("\nThe ceiling trembles, and rocks start to fall! -20HP");

                    health -= 20;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP."); // For TESTINGS IF IT WONT END OR LOOP 

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 8: The Crystal Cave 

                Console.WriteLine("Chapter 8: The Crystal Cave ");

                Console.ReadLine();

                Console.WriteLine("In the middle of the cave is a pedestal with three glowing crystals: red, blue, and yellow. A riddle appears, etched into the pedestal: ");

                Console.ReadLine();

                Console.WriteLine("\"I speak without a mouth and hear without ears.I have no body, but I come alive with wind.What am I ?\"  ");

                Console.ReadLine();

                Console.WriteLine("A: Echo ");

                Console.WriteLine("B: A cloud ");

                Console.WriteLine("C: A shadow ");

                Console.Write("\nANSWER: ");

                string choice8 = Console.ReadLine().ToUpper();



                if (choice8 == "A")

                {

                    Console.WriteLine("\nThe crystal pulses with light, revealing a spiral staircase +5HP ");

                    health += 5;

                }

                else if (choice8 == "B")

                {

                    Console.WriteLine("\nThe floor splits beneath you! -20 HP");

                    health -= 20;

                }

                else if (choice8 == "C")

                {

                    Console.WriteLine("\nThe floor splits beneath you! -20 HP");

                    health -= 20;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP."); // For TESTINGS IF IT WONT END OR LOOP 

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 9: The Clock Tower Puzzle 

                Console.WriteLine("Chapter 9: The Clock Tower Puzzle ");

                Console.ReadLine();

                Console.WriteLine("You ascend into a clock tower. The giant clock reads 3:15, frozen in time. Below the clock are three buttons: a sun, a moon, and a star. The gears seem ready to turn, but only if you press the right button. ");

                Console.ReadLine();

                Console.WriteLine("\"I follow you all day long, but when the night or rain comes, I am all gone. What am I?\"  ");

                Console.ReadLine();

                Console.WriteLine("A: Your shadow  ");

                Console.WriteLine("B: The sun  ");

                Console.WriteLine("C: The wind ");

                Console.Write("\nANSWER: ");

                string choice9 = Console.ReadLine().ToUpper();



                if (choice9 == "A")

                {

                    Console.WriteLine("you press the correct button, the clock moves, revealing a hidden door. + 5HP ");

                    health += 5;

                }

                else if (choice9 == "B")

                {

                    Console.WriteLine("\nA loud clang echoes, and the tower shakes! -20 HP ");

                    health -= 20;

                }

                else if (choice9 == "C")

                {

                    Console.WriteLine("A loud clang echoes, and the tower shakes! -20 HP.");

                    health -= 20;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP.");

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 10: The Potion Lab

                Console.WriteLine("Chapter 10: The Potion Lab ");

                Console.ReadLine();

                Console.WriteLine("Inside, you find an ancient alchemy lab. Bottles and flasks bubble and hiss with strange concoctions. A scroll on the table reads:  ");

                Console.ReadLine();

                Console.WriteLine("\"I can be cracked, made, told, and played. What am I? \" ");

                Console.ReadLine();

                Console.WriteLine("A: A joke ");

                Console.WriteLine("B: A mirror ");

                Console.WriteLine("C: An egg ");

                Console.Write("\nANSWER: ");

                string choice10 = Console.ReadLine().ToUpper();



                if (choice10 == "A")

                {

                    Console.WriteLine("\nThe potions glow, revealing a secret compartment + 5HP ");

                    health += 5;

                }

                else if (choice10 == "B")

                {

                    Console.WriteLine("\nAn explosion fills the room with smoke! -20 HP ");

                    health -= 20;

                }

                else if (choice10 == "C")

                {

                    Console.WriteLine("\nAn explosion fills the room with smoke! -20 HP ");

                    health -= 20;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP.");

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 11: The Bridge of Light 

                Console.WriteLine("\nChapter 11: The Bridge of Light ");

                Console.ReadLine();

                Console.WriteLine("You step onto a bridge made of rainbow tiles. A sign warns you: \"Choose the right pattern or fall into darkness.\" ");

                Console.ReadLine();

                Console.WriteLine("Sequence 1: Red, Orange, Yellow, Green, Blue, Indigo, Violet   ");

                Console.WriteLine("Sequence 2: Red, Yellow, Orange, Green, Blue, Indigo, Purple  ");

                Console.WriteLine("Sequence 3: Red, Orange, Yellow, Green, Blue, Purple, Indigo   ");
                


                Console.WriteLine("Which sequence do you follow?  ");

                Console.ReadLine();

                Console.WriteLine("A: Sequence 1  ");

                Console.WriteLine("B: Sequence 2  ");

                Console.WriteLine("C: Sequence 3 ");

                Console.Write("\nANSWER: ");

                string choice11 = Console.ReadLine().ToUpper();



                if (choice11 == "A")

                {

                    Console.WriteLine("\nYou followed the correct sequence on the bridge, you reach the end safely. ");

                    health += 0;

                }

                else if (choice11 == "B")

                {

                    Console.WriteLine("\nThe bridge gives way beneath you! -20 HP.");

                    health -= 20;

                }

                else if (choice11 == "C")

                {

                    Console.WriteLine("\nThe bridge gives way beneath you! -20 HP. ");

                    health -= 20;

                }

                else

                {

                    Console.WriteLine("\nInvalid choice. You lose 20 HP.");

                    health -= 20;

                }



                Console.WriteLine($"Current Health: {health} HP\n");



                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.ReadLine();



                Console.Clear();



                // Chapter 12: The Final Showdown 

                Console.WriteLine("\nChapter 12: The Final Showdown");

                Console.ReadLine();





                Console.WriteLine("The path forward takes you to the heart of the mansion—a massive circular chamber...");

                Console.WriteLine("The door to freedom lies beyond this final choice. The answer is simple, but choose wrongly, and this house will consume you forever.");

                Console.ReadLine();



                // Final Riddles 

                int correctAnswers = 0;



                // Riddle 1 

                Console.WriteLine("Riddle 1: \"What has roots as nobody sees, is taller than trees, up, up it goes, and yet never grows?\"");

                Console.WriteLine("A: A mountain");

                Console.WriteLine("B: A river");

                Console.WriteLine("C: A lightning bolt");

                Console.Write("\nANSWER: ");



                string riddle1 = Console.ReadLine().ToUpper();



                if (riddle1 == "A") correctAnswers++;
               



                else Console.WriteLine("WRONG");

                health -= 10;



                // Riddle 2 

                Console.WriteLine("\nRiddle 2: \"I am not seen, I am not heard, but I always tell the truth. What am I?\"");

                Console.WriteLine("A: The wind");

                Console.WriteLine("B: Time");

                Console.WriteLine("C: A mirror");

                Console.Write("\nANSWER: ");

                string riddle2 = Console.ReadLine().ToUpper();



                if (riddle2 == "B") correctAnswers++;









                else Console.WriteLine("WRONG");

                health -= 10;



                // Riddle 3 

                Console.WriteLine("\nRiddle 3: \"I have cities, but no houses. I have mountains, but no trees. I have water, but no fish. What am I?\"");

                Console.WriteLine("A: A painting");

                Console.WriteLine("B: A map");

                Console.WriteLine("C: A desert");

                Console.Write("\nANSWER: ");

                string riddle3 = Console.ReadLine().ToUpper();



                if (riddle3 == "B") correctAnswers++;

                else Console.WriteLine("WRONG");

                health -= 10;





                if (CheckHealth(ref health, ref gameOver))

                {

                    continue;

                }



                Console.Clear();



                // Victory or Failure 

                if (correctAnswers == 3)

                {

                    Console.WriteLine("GOOD ENDING: The Escape");

                    Console.WriteLine("You solved all the riddles correctly! The final door opens...");

                    Console.ReadLine();

                    Console.WriteLine("Paul steps through to freedom...");

                    Console.ReadLine();

                    Console.WriteLine("Congratulations! You successfully guided Paul to safety.");

                    gameOver = true;

                }

                else

                {

                    Console.WriteLine("BAD ENDING: Trapped Forever");

                    Console.WriteLine("The mansion consumes Paul as he fails to solve the riddles...");

                    Console.ReadLine();

                    Console.WriteLine("The House of Shadows has claimed another victim.");

                    gameOver = true;

                }

            }

        }
        static bool CheckHealth(ref int health, ref bool gameOver)

        {

            if (health <= 0)

            {

                Console.WriteLine("\nYou have succumbed to the dangers of the mansion.");

                bool validResponse = false;



                while (!validResponse)

                {

                    Console.Write("Try again? (yes/no): ");

                    string answer = Console.ReadLine().ToLower();



                    if (answer == "yes")

                    {

                        // RESTARTS THE GAME IF YES 

                        validResponse = true;

                        gameOver = false;

                    }

                    else if (answer == "no")

                    {

                        validResponse = true;

                        gameOver = true;  

                        Console.WriteLine("Game Over.");

                        Environment.Exit(0);   

                    }

                    else

                    {

                        // invalid input 

                        Console.WriteLine("\n\n\n\nInvalid input. Please enter 'yes' or 'no'.");

                    }

                }

                return true;

            }

            return false;

        }

    }

}