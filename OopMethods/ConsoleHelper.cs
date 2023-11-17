using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    internal static class ConsoleHelper
    {
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
