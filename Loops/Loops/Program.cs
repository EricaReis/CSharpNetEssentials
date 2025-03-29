namespace Loops;

public class Program
{
    public static void Main()
    {
        int i = 0;

        double budget = 100;

        while (budget > 0)
        {
            Console.WriteLine(budget);
       
            budget--;
        }

        int j = 1;

        do
        {
            Console.WriteLine(j);
            j++;
        } while (j <= 10);


    }
}