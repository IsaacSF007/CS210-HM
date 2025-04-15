using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    private List<string> _prompts =new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When you have felt the Holy spirit in this month?",
        "Who are some of your personal heores?"
    };
    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    public void Run()
    {
        DisplayStartMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("\nList as many responses as you can in the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);

        List<string> responses = new List<string>();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }
        Console.WriteLine($"\nYou listed {responses.Count} responses");
        DisplayEndMessage();

    }
}