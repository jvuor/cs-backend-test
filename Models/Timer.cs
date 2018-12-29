using System;
using System.Timers;

namespace cs_backend_test.Models
{
  public class Timer
  {
    private static uint time;

    public Timer()
    {
      Timer.time = 0;
    }

    public static void setTime(uint newTime)
    {
      Timer.time = newTime;
    }

    public static uint getTime()
    {
      return Timer.time;
    }

    public static void incrementTime()
    {
      Timer.time++;
    }
  }
}
