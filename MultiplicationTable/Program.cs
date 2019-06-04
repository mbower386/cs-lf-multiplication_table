using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main (string[] args)
        {
            int[, ] mTable = new int[10, 10];

            for (int x = 0; x < mTable.GetLength (0); x++)
            {
                for (int y = 0; y < mTable.GetLength (1); y++)
                {
                    mTable[x, y] = (x + 1) * (y + 1);
                }
            }

             for (int x = 0; x < mTable.GetLength (0); x++)
            {
                for (int y = 0; y < mTable.GetLength (1); y++)
                {
                    mTable[x, y] = (x + 1) * (y + 1);
                }
            }
        }

    }
}