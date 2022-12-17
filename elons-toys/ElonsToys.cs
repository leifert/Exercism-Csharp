using System;

class RemoteControlCar
{
    public int Distance { get; set; } = 0;
    public int Battery { get; set; } = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()=>$"Driven {Distance} meters";
    

    public string BatteryDisplay()=> (Battery > 0)? $"Battery at {Battery}%": EmptyBattery();

    public void Drive()
    {
        if (Battery >= 1) {
            Distance += 20;
            Battery -= 1;
        }
        else {
            EmptyBattery();
        }
    }
    private string EmptyBattery()=>"Battery empty";
}
