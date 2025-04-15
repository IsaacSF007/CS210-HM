using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity, this will help you relax your mind");
        Console.WriteLine(_description);
        Console.WriteLine("Enter how long you want the session to be (In seconds): ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Console.Clear();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity");
        ShowSpinner(3);
        Console.Clear();

    }
    public int GetDuration()
    {
        return _duration;
    }

    public void ShowCountdown(int _seconds)
    {
        for (int i = _seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int _seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};
        DateTime end = DateTime.Now.AddSeconds(_seconds);
        int index = 0;

        while (DateTime.Now < end)
        {
            Console.Write(spinner[index % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            index++;
        }
    }
} 