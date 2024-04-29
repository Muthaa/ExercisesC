using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int heroHealth = 10;
        int monsterHealth = 10;

        Console.WriteLine("Let the battle begin!");

        do
        {
            int heroAttack = random.Next(1, 11);
            monsterHealth -= heroAttack;
            Console.WriteLine($"Hero attacks! Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

            if (monsterHealth <= 0)
            {
                Console.WriteLine("Hero wins!");
                break;
            }

            int monsterAttack = random.Next(1, 11);
            heroHealth -= monsterAttack;
            Console.WriteLine($"Monster attacks! Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

            if (heroHealth <= 0)
            {
                Console.WriteLine("Monster wins!");
                break;
            }

        } while (heroHealth > 0 && monsterHealth > 0);
    }
}
