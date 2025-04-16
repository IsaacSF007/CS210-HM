using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        
        activities.Add(new Running("12 May 2018", 30, 4.8));
        activities.Add(new Cycling("9 Jun 2018", 45, 15.5));
        activities.Add(new Swimming("18 Jul 2018", 60, 40));

        
        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}
