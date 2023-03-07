using System;

class RemoteControlCar
{
    public int Speed { get; set; }
    public int BatteryDrain { get; set; }
    private int battery;
    private int distance;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        battery = 100;
        distance = 0;
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return (battery - BatteryDrain) < 0;
    }

    public int DistanceDriven(){ 
        return distance;
    }

    public void Drive()
    {
        if(!BatteryDrained()){
            distance += Speed;
            battery -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    public int Distance { get; set; }

    public RaceTrack(int distance) => Distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int drives = 100/car.BatteryDrain;
        int possDistance = drives*car.Speed;
        return (possDistance >= Distance);
    }
}
