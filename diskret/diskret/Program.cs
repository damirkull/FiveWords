using System;
using System.IO;

namespace diskret
{
    class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("matrix.txt");
            int n = int.Parse(lines[0]);

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] nums = lines[i + 1].Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(nums[j]);
                }
            }

            //1
            bool isSmej = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && matrix[i, j] == 1)
                    {
                        isSmej = false;
                        break;
                    }
                    if (matrix[i, j] != matrix[j, i])
                    {
                        isSmej = false;
                        break;
                    }
                }
                if (!isSmej) break;
            }

            if (isSmej)
                Console.WriteLine("1.YES");

            else
                Console.WriteLine("1.NO");

            //2
            bool hasLoop = false;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] == 1)
                {
                    hasLoop = true;
                    break;
                }
            }

            if (hasLoop)
                Console.WriteLine("2.YES");
            else
                Console.WriteLine("2.NO");
        }
    }
}