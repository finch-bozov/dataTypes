using System;

namespace nullValues
{
    class nullableValues
    {
        static void Main(string[] args)
        {
            int? notNull = 1;
            double? naGoshoDubala = 1.23;
            Console.WriteLine(notNull);
            Console.WriteLine(naGoshoDubala);
            notNull = null;
            naGoshoDubala = null;
            Console.WriteLine(notNull);
            Console.WriteLine(naGoshoDubala);
            int? quickOperation = notNull + 0;
            Console.WriteLine(quickOperation);
        }
    }
}
