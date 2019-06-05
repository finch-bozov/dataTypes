using System;

namespace exchangeVariables
{
    class exchangeValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("this is a = {0}", a);
            Console.WriteLine("This is b = {0}", b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("this is a = {0}", a);
            Console.WriteLine("This is b = {0}", b);
            //From right to left. C# uses the values after the first operation in the second operation and from the second to third.
        }
    }
}
