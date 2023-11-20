namespace OopMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i  = 10;

            /*
            ConsoleHelper.Print("test");

            ConsoleHelper.Print("label", "test");

            ConsoleHelper.Print("test", 3);

            Console.WriteLine(MathHelper.Factorial(5));

            int[] array = { 1, 2, 3, 4, 5 };
            ArrayHelper.IterateAndPrint(array);
            */

            ConsoleHelperWithDefaultArgs.Print("message1");
            ConsoleHelperWithDefaultArgs.Print("message2", "label2");
            ConsoleHelperWithDefaultArgs.Print("message3", "label3", 3);

            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(10));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(15, 3));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(20, 5, 9));
        }
    }
}