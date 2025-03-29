namespace LogicalOperators;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Logical operators: ");

        bool isLogged = true;
        bool hasAdminAccess = false;

        Console.WriteLine("User info:");
        Console.WriteLine("Is user logged? " + isLogged);
        Console.WriteLine("Is user admin? " + hasAdminAccess);

    
        //Operator (||) - or:
        if (isLogged || hasAdminAccess)
        {
            Console.WriteLine("Successful Access");
        }
        else
        {
            Console.WriteLine("Denied Access");
        }


        // Operator (&&) - and:
        if (isLogged && hasAdminAccess)
        {
            Console.WriteLine("Successful Accesso");
        }
        else
        {
            Console.WriteLine("Denied Access");
        }

        //Operator (!) - not:
        if (!isLogged)
        {
            Console.WriteLine("User is not logged");
        }
        else
        {
            Console.WriteLine("User is logged");
        }
    }
}