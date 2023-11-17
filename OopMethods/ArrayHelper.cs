using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    internal static class ArrayHelper
    {
        public static void IterateAndPrint(int[] array)
        {
            IterateAndPrint(array, 0);
        }

        private static void IterateAndPrint(int[] array, int index)
        {
            if (array is null || array.Length == 0)
            {
                return;
            }

            if (index >= 0 && index < array.Length)
            {
                Console.WriteLine(array[index]);

                if (index < array.Length - 1)
                {
                    IterateAndPrint(array, ++index);
                }
            }
        }
    }
}
