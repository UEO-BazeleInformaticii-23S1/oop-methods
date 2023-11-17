namespace OopMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i  = 10;

            ConsoleHelper.Print("test");

            ConsoleHelper.Print("label", "test");

            ConsoleHelper.Print("test", 3);

            Console.WriteLine(MathHelper.Factorial(5));
        }
    }
}