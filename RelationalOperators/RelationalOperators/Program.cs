namespace RelationalOperators
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("Relational Operators: \n");
            Console.WriteLine("Type the first number:");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            //Equality Operator (==):
            if (x == y)
            {
                result = "x is equal to y";
            } else
            {
                result = "x is different from y";
            }

            Console.WriteLine("\n (==): " + result);

            if (x != y)
            {
                result = "x is different from y";
            } else
            {
                result = "x is equal to y";
            }

            Console.WriteLine("\n (!=): " + result);

            //Bigger than (>):
            if (x > y)
            {
                result = "x is greater than y";
            } else
            {
                result = "x is not greater than y";
            }

            Console.WriteLine("\n (>): " + result);

            //Greater than or equal to (>=):
            if (x >= y)
            {
                result = "x is less than y";
            }
            else
            {
                result = "x is not less than y";
            }

            Console.WriteLine("\n (>): " + result);

        }
    }
}