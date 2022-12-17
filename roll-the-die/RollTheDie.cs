using System;

public class Player
{
    Random rnd = new();
    public int RollDie()=> rnd.Next(1,18);

    public double GenerateSpellStrength()=> rnd.NextDouble()*100;
}
