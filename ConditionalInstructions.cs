namespace PodstawyProgramowania;

public class ConditionalInstructions
{
    public void FindLargestNumber()
    {
        Console.WriteLine("Enter any number:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter any number, different from the previous one:");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number, different from the previous one:");
        double num3 = double.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("The largest is: " + num1);
            }
        }
        else if (num2 > num3)
        {
            Console.WriteLine("The largest is: " + num2);
        }
        else
        {
            Console.WriteLine("The largest is: " + num3);
            Console.ReadKey();
        }
    }
    public void SolveQuadraticEquation()
    {
        double a, b, c;
        Console.WriteLine("Enter the coefficient a:");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for a:");
        }

        Console.WriteLine("Enter the coefficient b:");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for b:");
        }

        Console.WriteLine("Enter the coefficient c:");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for c:");
        }

        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Delta is greater than zero, the equation has two solutions: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x0 = -b / (2 * a);
            Console.WriteLine($"Delta is zero, the equation has one solution: x0 = {x0}");
        }
        else
        {
            Console.WriteLine("Delta is less than zero, the equation has no real solutions");
        }
        Console.ReadKey();
    }
}