using System;
using System.Reflection.Emit;

public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuSubTitle = "===== Welcome, {0} the {1} with level {2} =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Increase LVL";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOption4 = "4. Show inventory";
        const string MenuOption5 = "5. Buy items";
        const string MenuOption6 = "6. Show attacks by LVL";
        const string MenuOption7 = "7. Decode ancient Scroll";
        const string MenuOptionExit = "8. Exit game";
        const string MenuPrompt = "Choose an option (1-7) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 7.";
        const string InputErrorMessageName = "Invalid name, you cant use numbers.";
        const string uslessLevel = "Reapeat again in the second try.";
        const string LowLevel = "Still confusing a wand with a spoon.";
        const string midLevel = "You are an evoker of magic winds.";
        const string highLevel = "WoW! You can spawn a Drake without burning the laboratory.";
        const string specialLevel = "You are a master of the arcane arts.";
        const string rankD = "Raoden the Elantri";
        const string rankC = "Zyn the Buggued";
        const string rankB = "Arka Nullpointer";
        const string rankA = "Elarion of the Embers";
        const string rankS = "ITB-Wizard the Grey";
        const string RankMessage = "You are rank {0}";

        int op = 0;
        int level = 1;
        int hours = 0;
        bool validInput;
        string rankWizard = "Unknown";
        string nameWizard = "Unknown";

        Random random = new Random();

        do
        {
            Console.Clear();
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuSubTitle, nameWizard, rankWizard, level);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption5);
            Console.WriteLine(MenuOption6);
            Console.WriteLine(MenuOption7);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (!validInput)
            {
                continue;
            }

            switch (op)
            {
                case 1:
                    
                    Console.Write("What is your name: ");
                    nameWizard = Console.ReadLine();
                    Console.WriteLine($"You will start at level {level}.");
                    Console.WriteLine("-----------");
                    nameWizard = nameWizard.Substring(0, 1).ToUpper() + nameWizard.Substring(1).ToLower();

                    bool validador = false;

                    foreach (char i in nameWizard)
                    {
                        if (char.IsDigit(i))
                        {
                            validador = true;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (validador)
                    {
                        Console.WriteLine(InputErrorMessageName);
                        break;
                    }
                    
                    for (int day = 1; day <= 5; day++)
                    {
                        hours = random.Next(1, 25);
                        int rndLevel = random.Next(1, 11);
                        level = level + rndLevel;

                        Console.WriteLine($"Day {day} ---> {nameWizard} has meditated {hours} hours and your power is {level} now.");
                    }

                    Console.WriteLine("-----------");

                    if (level >= 20 && level < 30)
                    {
                        Console.WriteLine(LowLevel);
                        rankWizard = rankC;

                    }
                    else if (level >= 30 && level < 35)
                    {
                        Console.WriteLine(midLevel);
                        rankWizard = rankB;
                    }
                    else if (level >= 35 && level < 40)
                    {
                        Console.WriteLine(highLevel);
                        rankWizard = rankA;
                    }
                    else if (level >= 40)
                    {
                        Console.WriteLine(specialLevel);
                        rankWizard = rankS;
                    }
                    else
                    {
                        Console.WriteLine(uslessLevel);
                        rankWizard = rankD;
                    }

                    Console.WriteLine(RankMessage, rankWizard);

                    break;

                case 2:
                    Console.WriteLine("You venture into the dungeon...");
                    break;

                case 3:
                    Console.WriteLine("You loot the mine and find some gold!");
                    break;

                case 4:
                    Console.WriteLine("You loot the mine and find some gold!");
                    break;
                case 5:
                    Console.WriteLine("You loot the mine and find some gold!");
                    break;
                case 6:
                    Console.WriteLine("You loot the mine and find some gold!");
                    break;
                case 7:
                    Console.WriteLine("You loot the mine and find some gold!");
                    break;
                case 0:
                    Console.WriteLine("Exiting game...");
                    break;

                default:
                    Console.WriteLine(InputErrorMessage);
                    break;
            }

            if (op != 0)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }

        } while (op != 0);
    }
}