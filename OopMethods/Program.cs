namespace OopMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ConsoleHelper.Print("test");

            ConsoleHelper.Print("label", "test");

            ConsoleHelper.Print("test", 3);

            Console.WriteLine(MathHelper.Factorial(5));

            int[] array = { 1, 2, 3, 4, 5 };
            ArrayHelper.IterateAndPrint(array);
            */

            /*
            ConsoleHelperWithDefaultArgs.Print("message1");
            ConsoleHelperWithDefaultArgs.Print("message2", "label2");
            ConsoleHelperWithDefaultArgs.Print("message3", "label3", 3);

            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(unitPrice: 10));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(unitPrice: 15, quantity: 3));
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(unitPrice: 20, quantity: 5, vatPercent: 9));

            // mixing positional arguments with named arguments
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(20, vatPercent: 9));


            // named-arguments allow skipping parameters
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(unitPrice: 20, vatPercent: 9));
            // or even changing the parameters order
            Console.WriteLine("Price=" + PriceCalculator.CalculatePrice(vatPercent: 9, quantity: 5, unitPrice: 20));
            */

            /*
            int i = 10;
            Console.WriteLine($"Before calling increment: {i}");
            Increment(i);
            Console.WriteLine($"After calling increment: {i}");
            */

            Person p = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Console.WriteLine($"Before calling SayHello: {p.LastName} {p.FirstName}");
            SayHello2( p );
            Console.WriteLine($"After calling SayHello: {p.LastName} {p.FirstName}");
        }

        private static void Increment(int i)
        {
            Console.WriteLine($"Before increment: {i}");
            i = i + 1;
            Console.WriteLine($"After increment: {i}");
        }

        private static void SayHello(Person p)
        {
            Console.WriteLine($"Before SayHello change name: {p.LastName} {p.FirstName}");
            p.LastName = "Changed";
            Console.WriteLine($"After SayHello change name: {p.LastName} {p.FirstName}");
        }

        private static void SayHello2(Person p)
        {
            Console.WriteLine($"Before SayHello change name: {p.LastName} {p.FirstName}");
            p = new Person
            {
                FirstName = "John",
                LastName = "Changed"
            };
            Console.WriteLine($"After SayHello change name: {p.LastName} {p.FirstName}");
        }
    }
}