using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDoubleAndFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            float valueFloat = 0.000001f;
            float resultFloat = 0;
            for (int i = 0; i < 1000000; i++)
            {
                resultFloat += valueFloat;
            }
            Console.WriteLine("Result of value with Float:"+ resultFloat);

            double valueDouble = 0.000001;
            double resultDouble = 0;
            for (int i = 0; i < 1000000; i++)
            {
                resultDouble += valueDouble;
            }
            Console.WriteLine("Result of value with Double:" + resultDouble);

        }
    }
}
