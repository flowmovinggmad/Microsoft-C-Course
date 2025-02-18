int monsterHealth = 10;
int heroHealth = 10;

Random mA = new Random();
Random hA = new Random();

int heroAttack = hA.Next(1, 11);
int monsterAttack = mA.Next(1, 11);

do
{
    heroAttack = hA.Next(1, 11);
    monsterHealth = monsterHealth - heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) break;

    monsterAttack= mA.Next(1, 11);
    heroHealth = heroHealth - monsterAttack;
    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

    if (heroHealth <= 0) break;

} while (monsterHealth > 0);


if (heroHealth < monsterHealth)
{
    Console.WriteLine("Monster Wins!");
} else if (monsterHealth < heroHealth)
{
    Console.WriteLine("Hero Wins!");
}

Console.ReadKey();
