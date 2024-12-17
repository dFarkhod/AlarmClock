namespace AlarmClockTimeOOP;
public class Clock
{
    private Time _currentTime;

    public int Hours => _currentTime.Hours;
    public int Minutes => _currentTime.Minutes;
    public int Seconds => _currentTime.Seconds;

    public Clock(int hours, int minutes, int seconds)
    {
        _currentTime = new Time(hours, minutes, seconds);
    }

    public void ShowTime(TimeFormat timeFormat)
    {
        switch (timeFormat)
        {
            case TimeFormat.Twelve:
                Console.WriteLine("Vaqt (12): " + _currentTime.Get12HourFormat());
                break;
            case TimeFormat.TwentyFour:
                Console.WriteLine("Vaqt (24):" + _currentTime.GetFormattedTime());
                break;
            default:
                break;
        }
    }

    public void Tick()
    {
        _currentTime.Tick();
    }
}

public enum TimeFormat
{
    Twelve,
    TwentyFour
}


