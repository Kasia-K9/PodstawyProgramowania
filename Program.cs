﻿namespace PodstawyProgramowania;

class Program
{
    static void Main(string[] args)
    {
        InitializeMenu();
    }

    private static void ShowMenu()
    {
        Console.WriteLine("1.ReachSumOfNumbers ");
        Console.WriteLine("2. CalculateNumbersToReachSum");
        Console.WriteLine("3.CalculatePiUsingLeibnizFormula");
        Console.WriteLine("4.CalculationOfInterest");
        Console.WriteLine("5.CalculatePowerOfNumber");
        Console.WriteLine("6.ProcessNumbers");
        Console.WriteLine("7. CalculateWaysToWithdrawTenZloty ");
        Console.WriteLine("8. FindTwinPrimesInRange");
        Console.WriteLine("9. Exit");
    }

    private static void InitializeMenu()
    {
        IterativeStatement interactiveStatement = new IterativeStatement();
        bool exit = false;
        while (!exit)
        {
            ShowMenu();
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("ReachSumOfNumbers starting...");
                    interactiveStatement.ReachSumOfNumbers();
                    break;
                case "2":
                    Console.WriteLine("CalculateNumbersToReachSum starting...");
                    interactiveStatement.CalculateNumbersToReachSum();
                    break;
                case "3":
                    Console.WriteLine("CalculatePiUsingLeibnizFormula starting...");
                    interactiveStatement.CalculatePiUsingLeibnizFormula();
                    break;
                case "4":
                    Console.WriteLine("CalculationOfInterest starting...");
                    interactiveStatement.CalculationOfInterest();
                    break;
                case "5":
                    Console.WriteLine("CalculatePowerOfNumber starting...");
                    interactiveStatement.CalculatePowerOfNumber();
                    break;
                case "6":
                    Console.WriteLine("ProcessNumbers starting...");
                    interactiveStatement.ProcessNumbers();
                    break;
                case "7":
                    Console.WriteLine("CalculateWaysToWithdrawTenZloty starting...");
                    interactiveStatement.CalculateWaysToWithdrawTenZloty();
                    break;
                case "8":
                    Console.WriteLine("FindTwinPrimesInRange starting...");
                    interactiveStatement.FindTwinPrimesInRange();
                    break;
                case "9":
                    Console.WriteLine("Exiting");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}