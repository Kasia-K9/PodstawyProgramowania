namespace PodstawyProgramowania;

public class IterativeStatement
{
    public void ReachSumOfNumbers()
    {
        Console.WriteLine("Enter the next numbers until their sum exceeds 100");
        int sum = 0;
        int counter = 0;
        while (sum <= 100)
        {
            Console.WriteLine("Enter a number");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Enter the correct number");
            }

            sum += number;
            counter++;
        }

        Console.WriteLine($"The sum of numbers is: {sum} ");
        Console.WriteLine($"Entered {counter} numbers");
    }

    public void CalculateNumbersToReachSum()
    {
        int i = 100;
        int count = 0;
        int s = 0;
        while (s < i)
        {
            count++;
            s += count;
        }

        Console.WriteLine("You need to provide {0} numbers to reach the result {1}", count, i);
    }
    public void CalculatePiUsingLeibnizFormula()
    {
        int infinity = 100;
        double pi = 0.0;
        for (int g = 0; g < infinity; g++)
        {
            if (g % 2 == 0)
            {
                pi += 4.0 / (2 * g + 1);
            }
            else
            {
                pi -= 4.0 / (2 * g + 1);
            }
        }
        Console.WriteLine("From the given Leibniz formula, assuming the number 100 as infinity, the value of pi is: " + pi);
    }

    public void CalculationOfInterest()
    {
        double principalAmount = 10000.0;
        double totalAmoun = 10000.0;
        int numberOfMonths = 12;
        double annualInterestRate = 0.05;
        double  interest = 0;
        for (int index = 0; index < numberOfMonths; index++)
        {
            totalAmoun += totalAmoun * (annualInterestRate / numberOfMonths);
        }

        interest = totalAmoun - principalAmount;
        Console.WriteLine("The interest is: {0}",  interest);
    }
}