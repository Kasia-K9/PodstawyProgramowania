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
}