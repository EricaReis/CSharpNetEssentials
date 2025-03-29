namespace BasicCalculator;
public class Program
{
    public static void Main()
    {
        bool varContinue = true;

        while (varContinue)
        {
            //Inicialização do programa
            Console.WriteLine("=======Basic Calculator====== \n");
            Console.WriteLine("Type the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Selecionar o tipo de operação
            Console.WriteLine("\nChoose:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (*)");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            //Condições
            if (operation == 1)
            {
                result = num1 + num2;
            }
            else if (operation == 2)
            {
                result = num1 - num2;
            }
            else if (operation == 3)
            {
                result = num1 * num2;
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide a number by 0");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }

            Console.WriteLine("\n Result: " + result + "\n");


            Console.WriteLine("\nDo you want to perform another operation (y/n)? ");
            string response = Console.ReadLine();

            if (response != "s")
            {
                varContinue = false;
            }
        }
    }
}