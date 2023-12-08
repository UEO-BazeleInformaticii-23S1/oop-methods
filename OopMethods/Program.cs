﻿namespace OopMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumber = new int[10];
            Rectangle[] arrayOfRectangles = new Rectangle[10];

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

            int i = 10;
            Console.WriteLine($"Before calling increment: {i}");
            IncrementWithOut(i, out i);
            Console.WriteLine($"After calling increment: {i}");

            Point pt1 = new Point();
            Point pt2 = new Point
            {
                X = 100,
                Y = 200
            };

            
            Person p = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(2000, 11, 27)
            };

            //Rectangle r = new Rectangle(new Point(100, 100), 50, 70);

            /*
            Person p = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Console.WriteLine($"Before calling SayHello: {p.LastName} {p.FirstName}");
            SayHello2(ref p);
            Console.WriteLine($"After calling SayHello: {p.LastName} {p.FirstName}");
            */
        }

        private static void Increment(ref int i)
        {
            Console.WriteLine($"Before increment: {i}");
            i = i + 1;
            Console.WriteLine($"After increment: {i}");
        }

        private static void IncrementWithOut(int prevValue, out int afterIncrementValue)
        {
            Console.WriteLine($"Before increment: {prevValue}");
            afterIncrementValue = prevValue + 1;
            Console.WriteLine($"After increment: {afterIncrementValue}");
        }

        private static void SayHello(ref Person p)
        {
            Console.WriteLine($"Before SayHello change name: {p.LastName} {p.FirstName}");
            p.LastName = "Changed";
            Console.WriteLine($"After SayHello change name: {p.LastName} {p.FirstName}");
        }

        private static void SayHello2(ref Person p)
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