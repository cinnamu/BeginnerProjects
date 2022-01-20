using System;

namespace Turnbasedgame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 20;
            int enemyHealth = 20;

            /*This code will keep running the code below until someones health reaches 0*/
            while (playerHealth > 0 && enemyHealth > 0)
            {
                //Inform player of current game state
                Console.WriteLine("You have " + playerHealth + " health.");
                Console.WriteLine("The enemy has " + enemyHealth + " health.");
                Console.WriteLine("Write 'a' to attack the enemy or 'b' to block an enemy attack.");

                //Get player's choice
                string choice = Console.ReadLine();
                //Decide enemy damage
                int enemyDamage = new Random().Next(1, 4);

                //Process player's choice
                if (choice == "a")
                {
                    //If the player attacks
                    Console.WriteLine("You attacked for 2 damage!");
                    enemyHealth -= 2;
                    Console.WriteLine("The enemy attacked for " + enemyDamage + " damage!");
                    playerHealth -= enemyDamage;
                }

                if (choice == "b")
                {
                    //If the player defends
                    Console.WriteLine("You blocked against the attack!");
                    Console.WriteLine("The enemy would've DEALT " + enemyDamage + " damage!"!);
                }
                if (playerHealth == 0)
                {
                    Console.WriteLine("You Lost.");
                }
                if (enemyHealth == 0)
                {
                    Console.WriteLine("You Win!");
                }
            }
        }
    }
}