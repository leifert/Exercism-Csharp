using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdsCount = {0, 2, 5, 3, 7, 8, 4};
        return birdsCount;
    }

    public int Today() => this.birdsPerDay.Last();
    

    public void IncrementTodaysCount() => this.birdsPerDay[this.birdsPerDay.Length- 1]++;
    //birdsPerDay[^1]++;
    

    public bool HasDayWithoutBirds()
    {
        bool isBirds = false;
        for (int i = 0; i < birdsPerDay.Length; i++) {
            if (birdsPerDay[i] == 0) {
                isBirds = true;
            }
        }
        return isBirds;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < numberOfDays; i++) {
            sum += birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        for (int i = 0; i < birdsPerDay.Length; i++) {
            if (birdsPerDay[i] >= 5) {
                busyDays++;
            }
        }
        return busyDays;
    }
}
