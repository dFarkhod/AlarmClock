namespace AlarmClockTimeOOP;
public class Time
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    // HH:MM:SS
    public string GetFormattedTime()
    {
        return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
    }

    public void Tick()
    {
        Seconds++;
        if (Seconds >= 60)
        {
            Seconds = 0;
            Minutes++;
            if (Minutes >= 60)
            {
                Minutes = 0;
                Hours++;
                if (Hours >= 24)
                {
                    Hours = 0;
                }
            }
        }
    }

    public string Get12HourFormat()
    {
        var period = Hours >= 12 ? "PM" : "AM";
        var hour = Hours > 12 ? Hours - 12 : Hours == 0 ? 12 : Hours;
        return $"{hour:D2}:{Minutes:D2}:{Seconds:D2} {period}";
    }
}
