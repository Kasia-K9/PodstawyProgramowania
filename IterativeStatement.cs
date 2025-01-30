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

    public void CalculatePowerOfNumber()
    {
        Console.WriteLine("Enter the base number for the power: ");
        int baseNumber  = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the exponent for the power:");
        int exponent = int.Parse(Console.ReadLine());
        int result = 1;
        int counter = 0;
        while (counter < exponent)
        {
            result *= baseNumber ;
            counter++;
        }

        Console.WriteLine(result);
    }
    public void ProcessNumbers()
    {
        double x;
        do
        {
            Console.WriteLine("Enter any number:");
            x = double.Parse(Console.ReadLine());
        } while (Math.Abs(x) <= 2 || Math.Abs(x) >= 3);

        Console.WriteLine("The number {0} meets the condition 2<|x|<3", x);

        Console.WriteLine("Enter a number to find its divisors:");
        int y = int.Parse(Console.ReadLine());
        int z = y;
        do
        {
            if (y % z == 0)
            {
                Console.WriteLine("The number {0} is a divisor of {1}", z, y);
            }

            z--;
        } while (z > 0);
    }
    public void CalculateWaysToWithdrawTenZloty()
    {
        Console.WriteLine("Possible ways to withdraw 10 zloty in coins of denominations 1 zloty, 2 zloty, and 5 zloty:");
        for (int m5 = 0; m5 <= 2; m5++)
        {
            for (int m2 = 0; m2 <= 5; m2++)
            {
                for (int m1 = 0; m1 <= 10; m1++)
                {
                    if (m5 * 5 + m2 * 2 + m1 == 10)
                    {
                        Console.WriteLine("Way to withdraw 10 zloty in coins: {0} x 5 zloty + {1} x 2 zloty + {2} x 1 zloty", m5, m2, m1);
                    }
                }
            }
        }
    }
    public void FindTwinPrimesInRange()
   {
            Console.WriteLine("Twin primes in the range <1; 100>:");
            for (int p = 2; p <= 98; p++)
            {
                bool isFirstTwinPrime = true;
                bool isSecondTwinPrime = true;
                for (int q = 2; q <= Math.Sqrt(p); q++)
                {
                    if (p % q == 0)
                    {
                        isFirstTwinPrime = false;
                        break;
                    }
                }

                if (isFirstTwinPrime)
                {
                    int twinPrime2 = p + 2;
                    for (int w = 2; w <= Math.Sqrt(twinPrime2); w++)
                    {
                        if (twinPrime2 % w == 0)
                        {
                            isSecondTwinPrime = false;
                            break;
                        }
                    }

                    if (isSecondTwinPrime)
                    {
                        Console.WriteLine("The twin primes are: {0}, {1}", p, twinPrime2);
                    }
                }
            }
        }
    }
