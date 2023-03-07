using System;

public class SpaceAge
{
    public int Seconds { get; set; }

    private static readonly double SecondsInEarthYear = 31557600;
    private static readonly double MercuryToEarthYears = 0.2408467;
    private static readonly double VenusToEarthYears = 0.61519726;
    private static readonly double MarsToEarthYears = 1.8808158;
    private static readonly double JupiterToEarthYears = 11.862615;
    private static readonly double SaturnToEarthYears = 29.447498;
    private static readonly double UranusToEarthYears = 84.016846;
    private static readonly double NeptuneToEarthYears = 164.79132;

    public SpaceAge(int seconds)
    {
       Seconds = seconds;
    }

    public double OnEarth()
    {
        return Seconds / SecondsInEarthYear;
    }

    public double OnMercury()
    {
         return OnEarth() / MercuryToEarthYears;
    }

    public double OnVenus()
    {
        return OnEarth() / VenusToEarthYears;
    }

    public double OnMars()
    {
        return OnEarth() / MarsToEarthYears;
    }

    public double OnJupiter()
    {
        return OnEarth() / JupiterToEarthYears;
    }

    public double OnSaturn()
    {
        return OnEarth() / SaturnToEarthYears;
    }

    public double OnUranus()
    {
        return OnEarth() / UranusToEarthYears;
    }

    public double OnNeptune()
    {
        return OnEarth() / NeptuneToEarthYears;
    }
}