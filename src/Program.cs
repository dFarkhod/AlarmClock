namespace AlarmClockTimeOOP;

class Program
{
    static void Main(string[] args)
    {
        // soatni hozirgi tizim vaqti bilan initsializatsiya qilib boshlaymiz:
        Clock myClock = new Clock(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

        // "budilnik"ni ertalab soat 5:10ga qo'yamiz:
        Alarm myAlarm = new Alarm(5, 10, 0);

        // soatni har sonia ishlaydigan qilib ishga tushiramiz
        while (true)
        {
            myClock.ShowTime(TimeFormat.Twelve);
            myClock.ShowTime(TimeFormat.TwentyFour);
            
            // budilnikda aniqlangan vaqt bilan solishtirib olamiz
            if (myAlarm.IsAlarmTime(new Time(myClock.Hours, myClock.Minutes, myClock.Seconds)))
            {
                myAlarm.Ring(); // jiringlatamiz!
            }

            // soatni yurgazamiz
            myClock.Tick();

            // keyingi yurishga bir soniya kutamiz:
            Thread.Sleep(1000);
        }
    }
}

