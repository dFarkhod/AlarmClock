namespace AlarmClockTimeOOP;

public class Alarm
    {
        public Time AlarmTime { get; set; }

        public Alarm(int hours, int minutes, int seconds)
        {
            AlarmTime = new Time(hours, minutes, seconds);
        }

        public bool IsAlarmTime(Time currentTime)
        {
            return currentTime.Hours == AlarmTime.Hours && currentTime.Minutes == AlarmTime.Minutes && currentTime.Seconds == AlarmTime.Seconds;
        }

        public void Ring()
        {
            Console.WriteLine("JIRING! JIRING! VAQT BO'LDI!");
        }
    }


