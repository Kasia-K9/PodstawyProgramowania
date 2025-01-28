namespace PodstawyProgramowania;

class Program
{
    static void Main(string[] args)
    {
        initializeMenu();
    }

    private static void ShowMenu()
    {
        Console.WriteLine("1.ReachSumOfNumbers ");
        Console.WriteLine("2. CalculateNumbersToReachSum");
        Console.WriteLine("3.CalculatePiUsingLeibnizFormula");
        Console.WriteLine("4. Exit");
    }

    private static void initializeMenu()
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