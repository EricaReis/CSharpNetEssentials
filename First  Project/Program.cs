namespace BasicSyntax;

public class Program
{
    public static void Main ()
    {
        Console.WriteLine("Type a number:");

        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2;

        if (result == 0) 
        {
            Console.WriteLine("Even");
        } else
        {
            Console.WriteLine("Odd");
        }

    }
}


