namespace PodstawyProgramowania;

class Program
{
    static void Main(string[] args)
    {
        InitializeMenu();
    }

    private static void ShowMainMenu()
    {
        Console.WriteLine("1. Interactive statement");
        Console.WriteLine("2. Conditional instructions");
        Console.WriteLine("3. Exit");
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
        Console.WriteLine("9. DrawPatternWithSquaresAndDiagonals");
        Console.WriteLine("10. FindPerfectNumbersInRange");
        Console.WriteLine("11. Exit");
    }

    private static void ShowConditionalInstructionsMenu()
    {
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. FindLargestNumber");
        Console.WriteLine("2. SolveQuadraticEquation");
        Console.WriteLine("3. ComparePowerResults");
        Console.WriteLine("4. CheckLeapYear");
        Console.WriteLine("5. DetermineMiddleValue");
        Console.WriteLine("6. FindAndSortThreeNumbers");
        Console.WriteLine("7. PerformArithmeticOperation");
        Console.WriteLine("8. CheckDivisibilityByThree");
    }

    private static void InitializeMenu()
    {
        bool exit = false;
        while (!exit)
        {
            ShowMainMenu();
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Interactive statement starting...");
                    InitializeInteractiveStatementMenu();
                    break;
                case "2":
                    Console.WriteLine("Conditional instructions starting...");
                    InitializeConditionalInstructions();
                    break;
                case "3":
                    Console.WriteLine("Exiting");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    private static void InitializeInteractiveStatementMenu()
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
                    Console.WriteLine("DrawPatternWithSquaresAndDiagonals starting...");
                    interactiveStatement.DrawPatternWithSquaresAndDiagonals();
                    break;
                case "10":
                    Console.WriteLine("FindPerfectNumbersInRange starting...");
                    interactiveStatement.FindPerfectNumbersInRange();
                    break;
                case "11":
                    Console.WriteLine("Exiting");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    private static void InitializeConditionalInstructions()
    {
        ConditionalInstructions conditionalInstructions = new ConditionalInstructions();
        bool exit = false;
        while (!exit)
        {
            ShowConditionalInstructionsMenu();
            string option = Console.ReadLine();
            switch (option)
            {
                case "0" :
                    Console.WriteLine("Exiting");
                    exit = true;
                    break;
                case "1":
                    Console.WriteLine("FindLargestNumber starting...");
                    conditionalInstructions.FindLargestNumber();
                    break;
                case "2":
                    Console.WriteLine("SolveQuadraticEquation starting...");
                    conditionalInstructions.SolveQuadraticEquation();
                    break;
                case "3":
                    Console.WriteLine("ComparePowerResults");
                    conditionalInstructions.ComparePowerResults();
                    break;
                case "4":
                    Console.WriteLine("CheckLeapYear");
                    conditionalInstructions.CheckLeapYear();
                    break;
                case "5":
                    Console.WriteLine("DetermineMiddleValue");
                    conditionalInstructions.DetermineMiddleValue();
                    break;  
                case "6":
                    Console.WriteLine("FindAndSortThreeNumbers");
                    conditionalInstructions.FindAndSortThreeNumbers();
                    break;
                case "7":
                    Console.WriteLine("PerformArithmeticOperation");
                    conditionalInstructions.PerformArithmeticOperation();
                    break;
                case "8":
                    Console.WriteLine("CheckDivisibilityByThree");
                    conditionalInstructions.CheckDivisibilityByThree();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}