using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2D Spiral Array
             */
            SpiralArray spiral = new SpiralArray();
            var result = spiral.GetSpiral(4);

            for(int r = 0; r < result.GetLength(1); r++)
            {
                for (int c = 0; c < result.GetLength(0); c++)
                    Console.Write($" {result[r, c]} ");
                Console.WriteLine();
            }
        }
    }
}
