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

// while (one.Hp > 0)
// {
//     Console.WriteLine(one.Hp);
//     one.Hp =- 25;
// }

Console.ReadLine();
