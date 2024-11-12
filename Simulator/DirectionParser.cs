namespace Simulator;

public static class DirectionParser
{
    public static Direction[] Parse(string letters)
    {
        List<Direction> directions = new();

        foreach (var letter in letters)
        {
            if (letter == 'u')
            {
                directions.Add(Direction.Up);
            }
            else if (letter == 'd')
            {
                directions.Add(Direction.Down); ;
            }
            else if (letter == 'l')
            {
                directions.Add(Direction.Left);
            }
            else if (letter == 'r')
            {
                directions.Add(Direction.Right);
            }
        }

        return directions.ToArray();
    }
}