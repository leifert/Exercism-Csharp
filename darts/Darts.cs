using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Math.Sqrt(x * x + y * y);
        if (distance <= 1.0) //inner circle
        {
            return 10;
        }
        else if (distance <= 5.0) //middle circle
        {
            return 5;
        }
        else if (distance <= 10.0) //outer circle
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
