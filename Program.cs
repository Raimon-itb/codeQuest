using System;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

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
        const string UslessLevel = "Reapeat again in the second try.";
        const string LowLevel = "Still confusing a wand with a spoon.";
        const string MidLevel = "You are an evoker of magic winds.";
        const string HighLevel = "WoW! You can spawn a Drake without burning the laboratory.";
        const string specialLevel = "You are a master of the arcane arts.";
        const string RankD = "Raoden the Elantri";
        const string RankC = "Zyn the Buggued";
        const string RankB = "Arka Nullpointer";
        const string RankA = "Elarion of the Embers";
        const string RankS = "ITB-Wizard the Grey";
        const string RankMessage = "You are rank {0}";
        const string MonsterMessage = "{0} has apeard!!!";
        const string MonsterDeathMessage = "{0} has died!!!";
        const string CurrentLevelMessage = "Youre current level is {0}.";
        const string DiceSideOne = """ 
           ________
          /       /|   
         /_______/ |
         |       | |
         |   o   | /
         |       |/ 
         '-------'
         """;
        const string DiceSideTwo = """ 
           ________
          /       /|   
         /_______/ |
         |     o | |
         |       | /
         | o     |/ 
         '-------'
         """;
        const string DiceSideThree = """ 
           ________
          /       /|   
         /_______/ |
         |     o | |
         |   o   | /
         | o     |/ 
         '-------'
         """;
        const string DiceSideFour = """ 
           ________
          /       /|   
         /_______/ |
         | o   o | |
         |       | /
         | o   o |/ 
         '-------'
         """;
        const string DiceSideFive = """ 
           ________
          /       /|   
         /_______/ |
         | o   o | |
         |   o   | /
         | o   o |/ 
         '-------'
         """;
        const string DiceSideSix = """ 
           ________
          /       /|   
         /_______/ |
         | o   o | |
         | o   o | /
         | o   o |/ 
         '-------'
         """;
        const string ScrollTitle = "===== What do you want to do with youre Scroll =====";
        const string ScrollOption1 = "1. Delete spaces";
        const string ScrollOption2 = "2. Count vowels";
        const string ScrollOption3 = "3. Extract numbers";
        const string Scroll1 = " The   path   has   been   marked . You   must   find    the   flame that   sleeps   in   the   tunnels . ";
        const string Scroll2 = "Thê sęcrèt fìrè Ìs hìddèn wìthìn thê shàdòws. Ónlý thôsè wìth thé còrrect êyè càn rëvèàl thê pàth lîngérîng bèlôw thê eàrth.";
        const string Scroll3 = "7The 92guardian 504holds 33the 808key. If 12you 401seek 77the 9003truth, 66proceed 4to 222the 1309wall where 818the 44ancient 505echoes 300slumber.";
        const string InputErrorMessageScroll = "Invalid input. Please enter a number between 0 and 7.";


        int op = 0;
        int level = 1;
        int hours = 0;
        int hp = 0;
        int bits = 0;
        int storeOption = 0;
        int[] dicesValor = { 1, 2, 3, 4, 5, 6 };
        int[] monsterRosterHp = { 3, 5, 10, 11, 18, 15, 20, 50 };
        int[] priceObject = { 30, 10, 50, 40, 20 };
        int sop = 0;
        bool validInput;
        string rankWizard = "Unknown";
        string nameWizard = "Unknown";
        string[] dices = { DiceSideOne, DiceSideTwo, DiceSideThree, DiceSideFour, DiceSideFive, DiceSideSix };
        string[] monsterRoster = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🤢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍", "Ancient Dragon 🐉" };
        string[] objectBuy = { "Iron Dagger 🗡️", "Healing Potion ⚗️", "Ancient Key 🗝️", "Crossbow 🏹", "Metal Shield 🛡️" };
        string[] inventory = new string[0];
        string[] attacksLvl1 = { "Magic Spark 💫" };
        string[] attacksLvl2 = { "Fireball 🔥", "Ice Ray 🥏", "Arcane Shield ⚕️" };
        string[] attacksLvl3 = { "Meteor ☄️", "Pure Energy Explosion 💥", "Minor Charm 🎭", "Air Strike 🍃" };
        string[] attacksLvl4 = { "Wave of Light ⚜️", "Storm of Wings 🐦" };
        string[] attacksLvl5 = { "Cataclysm 🌋", "Portal of Chaos 🌀", "Arcane Blood Pact 🩸", "Elemental Storm ⛈️" };
        string[][] attacksLevel = new string[][]
        {
            attacksLvl1,
            attacksLvl2,
            attacksLvl3,
            attacksLvl4,
            attacksLvl5
        };


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
                        rankWizard = RankC;

                    }
                    else if (level >= 30 && level < 35)
                    {
                        Console.WriteLine(MidLevel);
                        rankWizard = RankB;
                    }
                    else if (level >= 35 && level < 40)
                    {
                        Console.WriteLine(HighLevel);
                        rankWizard = RankA;
                    }
                    else if (level >= 40)
                    {
                        Console.WriteLine(specialLevel);
                        rankWizard = RankS;
                    }
                    else
                    {
                        Console.WriteLine(UslessLevel);
                        rankWizard = RankD;
                    }

                    Console.WriteLine(RankMessage, rankWizard);

                    break;

                case 2:
                    int randomMonster = random.Next(0, 8);

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(MonsterMessage, monsterRoster[randomMonster]);
                        hp = monsterRosterHp[randomMonster];
                        Console.WriteLine("------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Dice is rolling...");

                        while (hp > 0)
                        {
                            int valorDice = random.Next(0, 6);

                            Console.WriteLine(dices[valorDice]);
                            hp = hp - dicesValor[valorDice];

                        }

                        Console.WriteLine(MonsterDeathMessage, monsterRoster[randomMonster]);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        level++;
                    }

                    Console.WriteLine(CurrentLevelMessage, level);

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("===== LOOT THE MINE =====");

                    int attempts = 5;
                    int size = 5;
                    Random rnd = new Random();

                    string[,] mineVisible = new string[size, size];
                    int[,] mineHidden = new int[size, size];

                    for (int i = 0; i < size; i++)
                        for (int j = 0; j < size; j++)
                            mineVisible[i, j] = "➖";

                    for (int i = 0; i < 5; i++)
                    {
                        int x = rnd.Next(0, size);
                        int y = rnd.Next(0, size);
                        mineHidden[x, y] = 1;
                    }

                    void PrintMatrix()
                    {
                        Console.WriteLine();
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                                Console.Write(mineVisible[i, j] + " ");
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("You have 5 attempts to mine for bits!\n");

                    for (int i = 1; i <= attempts; i++)
                    {
                        Console.WriteLine($"Attempt {i} of {attempts}");

                        int x, y;
                        bool validCoordinates = false;

                        do
                        {
                            try
                            {
                                Console.Write("Enter X coordinate (0-4): ");
                                x = int.Parse(Console.ReadLine());

                                Console.Write("Enter Y coordinate (0-4): ");
                                y = int.Parse(Console.ReadLine());

                                if (x >= 0 && x < size && y >= 0 && y < size)
                                {
                                    validCoordinates = true;

                                    if (mineHidden[x, y] == 1)
                                    {
                                        int reward = rnd.Next(5, 51);
                                        bits += reward;
                                        mineVisible[x, y] = "🪙";
                                        Console.WriteLine($"You found a coin! +{reward} bits");
                                    }
                                    else
                                    {
                                        mineVisible[x, y] = "❌";
                                        Console.WriteLine("Nothing here...");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Coordinates must be between 0 and 4.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input. Enter numbers only.");
                                validCoordinates = false;
                            }

                        } while (!validCoordinates);

                        PrintMatrix();
                    }

                    Console.WriteLine($"Mining complete! You now have {bits} bits.");
                    break;

                case 4:
                    if (inventory.Length == 0)
                    {
                        Console.WriteLine("Your inventory is empty.");
                    }
                    else
                    {
                        Console.WriteLine("=== INVENTORY ===");
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine($"Slot {i + 1}: {inventory[i]}");
                        }
                    }

                    break;
                case 5:
                    Console.WriteLine("===== STORE =====");
                    for (int i = 0; i < objectBuy.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {objectBuy[i]} - {priceObject[i]} bits");
                    }

                    Console.Write("Choose an item to buy (1-5): ");
                    bool validStore = int.TryParse(Console.ReadLine(), out storeOption);

                    if (!validStore || storeOption < 1 || storeOption > objectBuy.Length)
                    {
                        Console.WriteLine("Invalid option.");
                    }
                    else
                    {
                        int price = priceObject[storeOption - 1];

                        if (bits < price)
                        {
                            Console.WriteLine("Not enough bits to buy this item.");
                        }
                        else
                        {
                            bits = bits - price;

                            Array.Resize(ref inventory, inventory.Length + 1);
                            inventory[^1] = objectBuy[storeOption - 1];

                            Console.WriteLine($"You bought {objectBuy[storeOption - 1]}!");
                        }
                    }
                    break;
                case 6:
                    if (rankWizard == RankD)
                    {
                        for (int i = 0; i < attacksLvl1.Length; i++)
                        {
                            Console.WriteLine("You can use this attacks: " + attacksLevel[0][i]);
                        }
                    }
                    else if (rankWizard == RankC)
                    {
                        for (int i = 0; i < attacksLvl2.Length; i++)
                        {
                            Console.WriteLine("You can use this attacks: " + attacksLevel[1][i]);
                        }
                    }
                    else if (rankWizard == RankB)
                    {
                        for (int i = 0; i < attacksLvl3.Length; i++)
                        {
                            Console.WriteLine("You can use this attacks: " + attacksLevel[2][i]);
                        }
                    }
                    else if (rankWizard == RankA)
                    {
                        for (int i = 0; i < attacksLvl4.Length; i++)
                        {
                            Console.WriteLine("You can use this attacks: " + attacksLevel[3][i]);
                        }
                    }
                    else if (rankWizard == RankS)
                    {
                        for (int i = 0; i < attacksLvl5.Length; i++)
                        {
                            Console.WriteLine("You can use this attacks: " + attacksLevel[4][i]);
                        }
                    }
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