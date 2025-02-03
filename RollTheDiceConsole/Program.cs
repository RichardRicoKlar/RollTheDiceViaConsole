using RollTheDice.Core;

Console.ForegroundColor = ConsoleColor.White;
while (true)
{
    Console.Clear();
    Console.WriteLine("Set the maximum roll first, then hit Enter to roll the virtual dice.");
    Console.WriteLine();

    try
    {
        Randomiser randomiser = new Randomiser(int.Parse(Console.ReadLine()));
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Rolling between 1 and " + (randomiser.MaxValue -1).ToString());
            Console.WriteLine("I rolled number: " + randomiser.RollTheValue());
            Console.WriteLine();
            Console.Write("Hit");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Enter ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("to roll the dice.");
            Console.ReadLine();
        };
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.ToString());
    }
    catch (Exception ex)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please use numbers");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
    }
}