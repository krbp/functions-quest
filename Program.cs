using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("First operand: ");
            string a = Console.ReadLine();
            Console.Write("Second operand: ");
            string b = Console.ReadLine();
            Console.Write("Which operation do you choose: ");
            string c = Console.ReadLine();

            if (c == "add")
            {
                Console.WriteLine($"{a} + {b} = {Add((float)Convert.ToDecimal(a), (float)Convert.ToDecimal(b))}");
            }
            else if (c == "subtract")
            {
                Console.WriteLine($"{a} - {b} = {Subtract((float)Convert.ToDecimal(a), (float)Convert.ToDecimal(b))}");
            }
            else if (c == "multiply")
            {
                Console.WriteLine($"{a} * {b} = {Multiply((float)Convert.ToDecimal(a), (float)Convert.ToDecimal(b))}");
            }
            else if (c == "divide")
            {
                Console.WriteLine($"{a} / {b} = {Divide((float)Convert.ToDecimal(a), (float)Convert.ToDecimal(b))}");
            }
            else if (c == "modulo")
            {
                Console.WriteLine($"{a} % {b} = {Modulo(Convert.ToInt32(a), Convert.ToInt32(b))}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
    public static float Add(float a, float b)
    {
        return a + b;
    }

    public static float Subtract(float a, float b)
    {
        return a - b;
    }

    public static float Multiply(float a, float b)
    {
        return a * b;
    }

    public static float Divide(float a, float b)
    {
        return a / b;
    }

    public static int Modulo(int a, int b)
    {
        return a % b;
    }
}
