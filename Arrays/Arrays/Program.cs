namespace Arrays;
public class Program
{
    public static void Main()
    {
        string separator = "----------------";

        string[] fruits = { "Apple", "Banana", "Watermelon", "Mango" };


        Console.WriteLine(fruits[0]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        Console.WriteLine("Quantity: " + fruits.Length);

        Console.WriteLine(separator);

        fruits[1] = "Grape";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        int[] numbers = new int[4];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}