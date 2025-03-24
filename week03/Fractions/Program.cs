using System;

class Fractions
{
    private int numerator;
    private int denominator;
    // Constructors
    public Fractions()
    {
        numerator = 1;
        denominator = 1;
    } 
    public Fractions(int numerator) // This gives the denominator a value, even if is not specified 
    {
        this.numerator = numerator;
        this.denominator = 1;
    }
    public Fractions(int numerator, int denominator) 
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    //Getters and setters
    public int GetNumerator()
    {
        return numerator;
    }
    
    public void SetNumerator(int value)
    {
        numerator = value;
    }
    public int GetDenominator()
    {
        return denominator;
    }
    public void SetDenominator(int value)
    {
        if (value != 0)
        {
            denominator = value;
        }
        else
        {
            Console.WriteLine("Cant be divided by 0");
        }
    }
    //Methods
    public string ShowFraction()
    {
        return $"{numerator}/{denominator}";
    }
    public double ShowDecimal()
    {
        return (double)numerator / denominator;
    }



}

class Program
{
    static void Main(string[] args)
    {
        Fractions Fractions_1 = new Fractions(1);
        Fractions Fractions_2 = new Fractions(5,1);
        Fractions Fractions_3 = new Fractions(3,4);
        Fractions Fractions_4 = new Fractions(1,3);

        Console.WriteLine($"{Fractions_1.ShowFraction()}");
        Console.WriteLine($"{Fractions_1.ShowDecimal()}");

        Console.WriteLine($"{Fractions_2.ShowFraction()}");
        Console.WriteLine($"{Fractions_2.ShowDecimal()}");
        
        Console.WriteLine($"{Fractions_3.ShowFraction()}");
        Console.WriteLine($"{Fractions_3.ShowDecimal()}");
        
        Console.WriteLine($"{Fractions_4.ShowFraction()}");
        Console.WriteLine($"{Fractions_4.ShowDecimal()}");

        
    }

}