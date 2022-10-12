using System;

using FightGame2;


Fighter f1 = new Fighter();
Fighter f2 = new Fighter();
f1.weapon = new Weapon();
f2.weapon = new Weapon();

bool finnished = false;



while(finnished != true)
{
    int f1AtkDmg = f1.weapon.Attack();
    int f2AtkDmg = f2.weapon.Attack();

    f1.Hp -= f2AtkDmg;
    f2.Hp -= f1AtkDmg;
    Console.WriteLine($"f1 Hp: {f1.Hp}");
    Console.WriteLine($"f2 Hp: {f2.Hp}");
    if(f1.Hp <= 0 || f2.Hp <= 0)
    {
        finnished = true;
        Console.WriteLine("The match is finnished");
        if(f1.Hp <= 0 && f2.Hp <= 0)
        {
            System.Console.WriteLine("Result: Tie");       
        }
        else if(f2.Hp <= 0 && f1.Hp > 0)
        {
            System.Console.WriteLine("Result: f1 wins");
        }
        else
        {
            System.Console.WriteLine("Result: f2 wins");
        }
    }
    else
    {
        System.Console.WriteLine("Press any key to attack again");
        Console.ReadKey();
        Console.Clear();
    }

}

Console.ReadLine();