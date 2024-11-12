using System.ComponentModel.DataAnnotations;

namespace Simulator;

public class Orc : Creature
{
    private int rage = 0;
    private int HuntCount = 0;

    public int Rage
    {
        get => rage;
        init => rage = Validator.Limiter(value, 0, 10);
    }

    public Orc(string name = "Unknown Orc", int level = 1, int rage = 1) : base(name, level)
    {
        rage = Validator.Limiter(rage, 0, 10);
    }

    public override int Power => 7 * Level + 3 * Rage;

    public void Hunt()
    {
        HuntCount++;
        if (HuntCount % 3 == 0)
        {
            if (rage < 10)
            {
                rage++;
            }
        }
    }
    public override string Info => $"{Name} [{Level}][{Rage}]";

    public override void SayHi() => Console.WriteLine($"Hi, I'm {Name}, my level is {Level}, my rage is {Rage}.");
}