// Megaman zero = new Megaman();
// zero.Name = "Zero";

Megaman man = new Megaman() {
  Name = "Yangyang",
  Hitpoints = 100
};

Enemy one = new Enemy () {
    Name = "Scar",
    HP = 100
};

Console.WriteLine(man.Name + " & " + one.Name);

if (one.HP == 100)
{
    one.Name = "Rough";
    one.HP = 50;
}

Console.WriteLine(man.Name + " and the new enemy " + one.Name + " with the hp " + one.HP);

Console.ReadLine();
