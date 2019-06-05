using System;

namespace stringsAndObjects
{
    class typeCasting
    {
        static void Main(string[] args)
        {
            string beginning = "Hello";
            string ending = "World!";
            object concat = beginning + " " + ending;
            string afterConcat = (string) concat;
            Console.WriteLine(afterConcat);
        }
    }
}