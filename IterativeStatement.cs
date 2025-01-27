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
            while (!int.TryParse(Console.ReadLine(), out  number))
            {
                Console.WriteLine("Enter the correct number");
            }
            sum += number;
            counter++;
        }

        Console.WriteLine($"The sum of numbers is: {sum} ");
        Console.WriteLine($"Entered {counter} numbers");
    }
}