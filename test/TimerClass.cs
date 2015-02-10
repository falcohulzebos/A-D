using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Timing
{
    TimeSpan startingTime;
    TimeSpan duration;

	public Timing()
	{
        startingTime = new TimeSpan(0);
        duration = new TimeSpan(0);
	}

    public void stopTime()
    {
        duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
    }

    public void startTime()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
    }

    public TimeSpan Result()
    {
        return duration;
    }
}
