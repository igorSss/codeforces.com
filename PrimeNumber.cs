using System;

namespace TMP
{
    class PrimeNumber
    {
        public void GetPrimeNumbers()
        {
            var inputArray = GetInputArray();
            Console.WriteLine("\r\n GetPrimeNumbers");
            for (var i = 0; i < inputArray.Length; i++)
            {
                bool isPrime = true;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.Write(inputArray[i] + " ");
                }
            }
        }

        private int[] GetInputArray()
        {
            int[] inputArray = new int[100];
            Console.WriteLine("Input array");
            for (var i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = i + 1;
                Console.Write(inputArray[i] + " ");
            }
            return inputArray;
        }
    }
}
