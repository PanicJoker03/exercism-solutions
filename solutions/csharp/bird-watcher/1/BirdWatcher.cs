class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        int todayCount = birdsPerDay.Last();
        birdsPerDay[birdsPerDay.Count() - 1] = todayCount + 1;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(birds => birds == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdsCount = 0;
        for(int i = 0; i < numberOfDays; i++){
            birdsCount += birdsPerDay[i];
        }
        return birdsCount;
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(birds => birds >= 5);
    }
}
