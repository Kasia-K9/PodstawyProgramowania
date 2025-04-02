namespace PodstawyProgramowania;

public class ArraysOperations
{
    public void ReadAndDisplayArrayElements()
    {
        try
        {
            Console.WriteLine("Enter the number of array elements:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter an array element:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array elements are:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: {0}", e.Message);
        }
    }

    public void CalculateSumAndAverage()
    {
        int[] arr1 = new int[20];
        int sum = 0;
        int average = 0;
        for (int j = 0; j < 20; j++)
        {
            arr1[j] = j + 1;
            Console.WriteLine(arr1[j]);
            sum += arr1[j];
        }

        average = sum / 20;
        Console.WriteLine("The sum of the array elements is: {0}", sum);
        Console.WriteLine("The average of the array elements is: {0}", average);
    }
}
