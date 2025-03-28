namespace AssignmentOperators;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Assignment Operators");

        int x = 10;

        Console.WriteLine("\n Initial Value: " + x);

        //Simple Assignment operator (=):
        x = 20;
        Console.WriteLine("Simple assignment: " + x);

        //Compound Assignment:
        x++;
        Console.WriteLine("Compound Assignment ++: " + x);


        //Compound Assignment (x = x + 10):
        x += 10;
        Console.WriteLine("Compound Assignment +=: " + x);

        //Compound Assignment (x = x - 10):
        x -= 10;
        Console.WriteLine("Compound Assignment -=: " + x);

        //Compound Assignment (x = x * 10):
        x *= 10;
        Console.WriteLine("Compound Assignment *=: " + x);

        //Compound Assignment (x = x / 10):
        x /= 10;
        Console.WriteLine("Compound Assignment /=: " + x);
    }
}