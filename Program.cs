using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int number1;
        int number2;
        string symbol;


        Console.WriteLine("Ilk reqemi daxil edin");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Simvolu daxil edin(-+/*)");
        symbol = Console.ReadLine();

        Console.WriteLine("ikinci reqemi daxil edin");
        number2 = int.Parse(Console.ReadLine());


        switch (symbol)
        {
            case "+":
            Console.WriteLine($"Berbardir={number1+number2}");
            break;

            case "-":
            Console.WriteLine($"Berbardir={number1 - number2}");
            break;
            
            case "*":
            Console.WriteLine($"Berbardir={number1 *number2}");
            break;

            case "/":
            Console.WriteLine($"Berbardir={number1 /number2}");
            break;

            default:
            Console.WriteLine("Dogru simvol daxil edilmeyib");
            break;
        }

    }
}