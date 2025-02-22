

public class Program
{
    public static void Main(string[] args)
    {
        var exit = false;
        Console.Clear();

        while (!exit)
        {
            Console.WriteLine("What type of operation you need to do?");
            Console.WriteLine("1.- Add");
            Console.WriteLine("2.- Substract");
            Console.WriteLine("3.- Multiplication");
            Console.WriteLine("4.- Division");
            Console.WriteLine("0.- Exit the program");

            switch (Console.ReadLine())
            { 
                case "0":
                    exit = true;
                    break;
                case "1":
                    Console.WriteLine("ADD");
                    break;
                case "2":
                    Console.WriteLine("SUBSTRACT");
                    break;
                case "3":
                    Console.WriteLine("MULTIPLICATION");
                    break;
                case "4":
                    Console.WriteLine("DIVISION");
                    break;
            }
        }

        Console.Clear();
        Console.WriteLine("Thanks for using Term Calculator");
    }

}