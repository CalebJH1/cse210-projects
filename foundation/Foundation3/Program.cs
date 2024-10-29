using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();

        double distance = 3.0;
        Running runningExercise = new Running("20 Jun 2019", 30, distance);
        activityList.Add(runningExercise);

        double speed = 15.0;
        Cycling cyclingExercise = new Cycling("10 Jul 2019", 60, speed);
        activityList.Add(cyclingExercise);

        int laps = 30;
        Swimming swimmingExercise = new Swimming("11 Aug 2019", 45, laps);
        activityList.Add(swimmingExercise);

        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}