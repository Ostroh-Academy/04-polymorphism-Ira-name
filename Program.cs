using System;

public class Function
{
    protected double a1, a0, b1, b0;

    public Function(double a1, double a0, double b1, double b0)
    {
        this.a1 = a1;
        this.a0 = a0;
        this.b1 = b1;
        this.b0 = b0;
    }

    public virtual void SetCoefficients(double a1, double a0, double b1, double b0)
    {
        this.a1 = a1;
        this.a0 = a0;
        this.b1 = b1;
        this.b0 = b0;
    }

    public virtual void PrintCoefficients()
    {
        Console.WriteLine($"a1 = {a1}, a0 = {a0}, b1 = {b1}, b0 = {b0}");
    }

    public virtual double Calculation(double x)
    {
        return (a1 * x + a0) / (b1 * x + b0);
    }
}

public class Function2 : Function
{
    private double a2, b2;

    public Function2(double a2, double a1, double a0, double b2, double b1, double b0)
        : base(a1, a0, b1, b0)
    {
        this.a2 = a2;
        this.b2 = b2;
    }

    public override void SetCoefficients(double a1, double a0, double b1, double b0)
    {
        base.SetCoefficients(a1, a0, b1, b0);
    }

    public override void PrintCoefficients()
    {
        base.PrintCoefficients();
        Console.WriteLine($"a2 = {a2}, b2 = {b2}");
    }

    public override double Calculation(double x)
    {
        return (a2 * x * x + a1 * x + a0) / (b2 * x * x + b1 * x + b0);
    }
}

public static class FunctionFactory
{
    public static Function CreateFunction(int choice)
    {
        if (choice == 1)
            return new Function(2, 3, 4, 5);
        else if (choice == 2)
            return new Function2(1, 2, 3, 4, 5, 6);
        else
            throw new ArgumentException("Invalid choice.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter '1' for Function, '2' for Function2:");
        int choice = int.Parse(Console.ReadLine());

        Function function = FunctionFactory.CreateFunction(choice);

        Console.WriteLine("Enter '1' to print Function coefficients, '2' to print Function2 coefficients:");
        int printChoice = int.Parse(Console.ReadLine());

        switch (printChoice)
        {
            case 1:
                if (function is Function2)
                {
                    Console.WriteLine("Selected function is not Function.");
                }
                else
                {
                    Console.WriteLine("Function coefficients:");
                    function.PrintCoefficients();
                }
                break;
            case 2:
                if (function is Function2)
                {
                    Console.WriteLine("Function2 coefficients:");
                    ((Function2)function).PrintCoefficients();
                }
                else
                {
                    Console.WriteLine("Selected function is not Function2.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        double x = 2.5;
        Console.WriteLine($"Value of Function at x = {x}: {function.Calculation(x)}");
    }
}
