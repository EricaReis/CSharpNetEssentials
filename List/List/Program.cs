namespace List;

public class Program
{
    public static void Main()
    {
        string separator = "--------------";

        List<string> fruits = new List<string>()
        {
            "Mango",
            "Avocado",
            "Pear"
        };

        Console.WriteLine(fruits[2]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.Add("Lemon");
        fruits.Add("Orange");

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        fruits.Remove("Lemon");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        Console.WriteLine("Fruits quantity: " + fruits.Count);

        fruits[3] = "Passion fruit";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        fruits.Clear();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        List<int> numbers = new List<int>();

        numbers.Add(1);
        numbers.Add(22);
        numbers.Add(32);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}