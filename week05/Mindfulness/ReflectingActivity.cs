using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _list = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you you did something truly selfless."
    };

    private List <string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different thab other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you apply this experience to your future?"

    };

    public ReflectionActivity()
    : base ("Reflection activity" , "This activity will help you reflecto on times in your life when you have shown strenght and resiliance")
    {      
    }
    public void Run()
    {
        DisplayStartMessage();
        Random rand = new Random();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($">>> {_list[rand.Next(_list.Count)]}");
        Console.WriteLine("When you have something in mind, press Enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(3);

        int duration = GetDuration();
        DateTime endTime= DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
        }
        DisplayEndMessage();
    }

    


}