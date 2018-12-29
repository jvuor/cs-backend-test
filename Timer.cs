using System;
using System.Timers;

namespace cs_backend_test
{
  public class Timer
  {
    private static System.Timers.Timer clock;

    public Timer()
    {
      clock = new System.Timers.Timer(1000);
      Console.WriteLine("Starting timer");

      clock.Elapsed += TimerEvent;
      clock.AutoReset = true;
      clock.Enabled = true;
    }

    private static void TimerEvent (Object source, ElapsedEventArgs e) 
    {
      cs_backend_test.Models.Timer.incrementTime();
    }
  }
}
