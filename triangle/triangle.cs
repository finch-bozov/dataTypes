using System;

namespace triangle
{
    class triangle
    {
        static void Main(string[] args)
        {
            char triangle = '\u0040';
            Console.WriteLine("    {0}", triangle);
            Console.WriteLine("   {0} {0}", triangle);
            Console.WriteLine(" {0}   {0}", triangle);
            Console.WriteLine("{0} {0} {0} {0}", triangle);
            // Should print something that looks like a triangle
        }
    }
}
