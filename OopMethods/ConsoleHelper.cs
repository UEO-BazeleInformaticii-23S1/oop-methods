namespace OopMethods
{
    internal static class ConsoleHelper
    {
        /// <summary>
        /// Prints a message
        /// </summary>
        /// <param name="message">The message to print</param>
        public static void Print(string message) 
        {
            Print(string.Empty, message, 1);
        }

        public static void Print(string label, string message)
        {
            Print(label, message, 1);
        }

        public static void Print(string message, int count)
        {
            Print(string.Empty, message, count);
        }

        private static void Print(string label, string message, int count)
        {
            if (!string.IsNullOrEmpty(label))
            {
                Console.WriteLine($"{label}: ");
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
