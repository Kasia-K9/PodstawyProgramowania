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
}