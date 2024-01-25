// See https://aka.ms/new-console-template for more information
using System;

class CYOAGame
{
    static void Main()
    {
        Console.WriteLine("You wake up in a stone room lit by flickering torches.");
        Console.WriteLine("You look around and see two doors. One going LEFT, and one going RIGHT.");
        Console.WriteLine("Choices: LEFT or RIGHT");
        
        string choice = Console.ReadLine();

        switch (choice.ToUpper())
        {
            case "RIGHT":
                RightPath();
                break;
            case "LEFT":
                LeftPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void RightPath()
    {
        Console.WriteLine("You decide to go through the right doorway.");
        Console.WriteLine("Just before you enter the room ahead, you see a BOW and a SWORD.");
        Console.WriteLine("Choices: BOW or SWORD");

        string weaponChoice = Console.ReadLine();

        switch (weaponChoice.ToUpper())
        {
            case "BOW":
                BowPath();
                break;
            case "SWORD":
                SwordPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void BowPath()
    {
        Console.WriteLine("You pick the bow and enter the room with a hulking troll.");
        Console.WriteLine("Choices: AIM for EYE or HEART");

        string aimChoice = Console.ReadLine();

        switch (aimChoice.ToUpper())
        {
            case "EYE":
                EyePath();
                break;
            case "HEART":
                HeartPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void HeartPath()
    {
        Console.WriteLine("The arrow slams into the chest of the troll, but its thick hide prevents a killing blow.");
        Console.WriteLine("The troll grabs you and throws you against the wall. Dazed, you look up at the troll as it brings its large club down on your head. You LOSE.");
    }

    static void EyePath()
    {
        Console.WriteLine("The arrow pierces the eye of the troll, and it collapses.");
        Console.WriteLine("Ahead, you see a BAG and a CHEST.");
        Console.WriteLine("Choices: BAG or CHEST");

        string lootChoice = Console.ReadLine();

        switch (lootChoice.ToUpper())
        {
            case "BAG":
                BagPath();
                break;
            case "CHEST":
                ChestPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void BagPath()
    {
        Console.WriteLine("You grab the bag and find a blue crystal set in silver inside.");
        Console.WriteLine("You touch it and teleport to a green grassy field outside your home. You SURVIVE.");
    }

    static void ChestPath()
    {
        Console.WriteLine("You open the chest, and it turns out to be a mimic. It eats you. You LOSE.");
    }

    static void SwordPath()
    {
        Console.WriteLine("You grab the sword as the troll charges towards you.");
        Console.WriteLine("Choices: KILL or RUN");

        string actionChoice = Console.ReadLine();

        switch (actionChoice.ToUpper())
        {
            case "KILL":
                KillPath();
                break;
            case "RUN":
                RunPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void KillPath()
    {
        Console.WriteLine("You dodge the troll's swing, stab it in the back, and find a TRAPDOOR and some LOOT.");
        Console.WriteLine("Choices: TRAPDOOR or LOOT");

        string killChoice = Console.ReadLine();

        switch (killChoice.ToUpper())
        {
            case "TRAPDOOR":
                TrapdoorPath();
                break;
            case "LOOT":
                LootPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void LootPath()
    {
        Console.WriteLine("You grab the loot and find a blue crystal set in silver inside.");
        Console.WriteLine("You touch it and teleport to a green grassy field outside your home. You SURVIVE.");
    }

    static void TrapdoorPath()
    {
        Console.WriteLine("You open the trapdoor and find stairs. There are two doors, one going RIGHT and one going LEFT.");
        Console.WriteLine("Choices: RIGHT or LEFT");

        string stairsChoice = Console.ReadLine();

        switch (stairsChoice.ToUpper())
        {
            case "RIGHT":
                RightStairsPath();
                break;
            case "LEFT":
                LeftStairsPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void RightStairsPath()
    {
        Console.WriteLine("You walk down the right-hand hallway and fall into a pit of spikes. You LOSE.");
    }

    static void LeftStairsPath()
    {
        Console.WriteLine("You walk down the left-hand hallway and find a massive vault of coins.");
        Console.WriteLine("On the far wall is a staircase with the words 'exit.' You WIN!");
    }

    static void RunPath()
    {
        Console.WriteLine("You run back to the main room with the sword.");
        Console.WriteLine("Now, you can choose to go LEFT.");
        Console.WriteLine("Choices: LEFT");

        string runChoice = Console.ReadLine();

        switch (runChoice.ToUpper())
        {
            case "LEFT":
                LeftPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void LeftPath()
    {
        Console.WriteLine("You decide to go to the left.");
        Console.WriteLine("After walking down a long hallway, you stand in front of a pair of stairs.");
        Console.WriteLine("Choices: UP or DOWN");

        string leftChoice = Console.ReadLine();

        switch (leftChoice.ToUpper())
        {
            case "UP":
                UpStairsPath();
                break;
            case "DOWN":
                DownStairsPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void UpStairsPath()
    {
        Console.WriteLine("You go up the stairs into a large chamber with a Beholder.");
        Console.WriteLine("You stab the Beholder in the eye and see a RED and a BLUE button.");
        Console.WriteLine("Choices: RED or BLUE");

        string beholderChoice = Console.ReadLine();

        switch (beholderChoice.ToUpper())
        {
            case "RED":
                RedButtonPath();
                break;
            case "BLUE":
                BlueButtonPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void RedButtonPath()
    {
        Console.WriteLine("You press the red button and find yourself in a massive vault of coins.");
        Console.WriteLine("On the far wall is a staircase with the words 'exit.' You WIN!");
    }

    static void BlueButtonPath()
    {
        Console.WriteLine("A beam of blue energy turns you into a deity. You transcend into godhood and WIN!");
    }

    static void DownStairsPath()
    {
        Console.WriteLine("You go down the stairs into a room with a trap door.");
        Console.WriteLine("The room slowly shrinks, and the trap door is locked.");
        Console.WriteLine("Choices: PRY or PICK");

        string trapdoorChoice = Console.ReadLine();

        switch (trapdoorChoice.ToUpper())
        {
            case "PRY":
                PryPath();
                break;
            case "PICK":
                PickPath();
                break;
            default:
                Console.WriteLine("Invalid choice. The adventure ends.");
                break;
        }
    }

    static void PryPath()
    {
        Console.WriteLine("You try to pry the trap door open with your sword.");
        Console.WriteLine("The walls slowly crush you into a pulp. You LOSE.");
    }

    static void PickPath()
    {
        Console.WriteLine("You attempt to pick the lock, but you don't have any materials.");
        Console.WriteLine("The walls of the room slowly crush you into a pulp. You LOSE.");
    }
}

