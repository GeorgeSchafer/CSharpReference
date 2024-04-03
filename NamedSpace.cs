using System;
using System.Collections.Generic;

namespace Named
{
    public class Space
    {
        int integer;
        bool boolean;
        long longInteger;

        public Space()
        {
            int integer = 1;
            bool boolean = true;
            long longInteger = 1111111111111111111;

            Console.WriteLine($"{integer}, {boolean}, {longInteger}");
        }


    }

}