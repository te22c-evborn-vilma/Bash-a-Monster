// Megaman zero = new Megaman();
// zero.Name = "Zero";

Megaman man = new Megaman() {
  Name = "Yangyang",
  Hitpoints = 100
};

Enemy one = new Enemy () {
    Name = "Scar",
    Hp = 100
};

Console.WriteLine(man.Name + " & " + one.Name);

if (one.Hp == 100)
{
    one.Name = "Rough";
    one.Hp = 50;
}

Console.WriteLine(man.Name + " and the new enemy " + one.Name + " with the hp " + one.Hp);

Console.ReadLine();
