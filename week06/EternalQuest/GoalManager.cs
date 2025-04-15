using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("Enter goal type (1 = Simple, 2 = Checklist, 3 = Eternal): ");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description));
        }
        else if (goalType == "2")
        {
            Console.WriteLine("Enter the number of events needed to complete this goal: ");
            int targetEvents = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, targetEvents));
        }
        else if (goalType == "3")
        {
            _goals.Add(new EternalGoal(name, description));
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalDetails()}");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("Saving goals...");

        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                file.WriteLine(goal.GetGoalDetails());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.WriteLine("Loading goals...");

        if (File.Exists("goals.txt"))
        {
            using (StreamReader file = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line); // In real implementation, we would parse and load them back as actual objects
                }
            }
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();

        Console.WriteLine("Enter the number of the goal to record an event: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
}
