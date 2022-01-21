// Building this dice game teaches you more about for & if loops as well as how to work with integers better. Listen to te Guide!
int playerPoints = 0;
int enemyPoints = 0;

for (int i = 0; i < 10; i++)
{
    int playerRandomNum;
    int enemyRandomNum;

    Random random = new Random();

    Console.WriteLine("Press any key to roll the die.");

    Console.ReadKey();

    playerRandomNum = random.Next(1, 7);
    Console.WriteLine("You rolled a " + playerRandomNum + ".");

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(200);

    enemyRandomNum = random.Next(1, 7);
    Console.WriteLine("The enemy AI rolled a " + enemyRandomNum + ".");

    if (playerRandomNum < enemyRandomNum)
    {
        enemyPoints++;
        Console.WriteLine("Enemy wins this round!");
    }
    else if (playerRandomNum > enemyRandomNum)
    {
        playerPoints++;
        Console.WriteLine("You Win this round!");
    }
    else
    {
        Console.WriteLine("Draw!");
    }
    Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
    Console.WriteLine();
}
if(playerPoints > enemyPoints)
{
    Console.WriteLine("You Win!");
}
else if(playerPoints < enemyPoints)
{
    Console.WriteLine("You Lose!");
}
else
{
    Console.WriteLine("Game Draw!");
}