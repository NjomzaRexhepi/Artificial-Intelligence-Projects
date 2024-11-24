using System;
using System.Collections.Generic;

class LatinSquare
{
    private int[,] square;
    private bool[,] rowUsed, colUsed;
    private int n;

    public LatinSquare(int size)
    {
        n = size;
        square = new int[n, n];
        rowUsed = new bool[n, n + 1];
        colUsed = new bool[n, n + 1];
    }

    public bool SolveSquare()
    {
        for (int depth = 1; depth <= n * n; depth++)
        {
            Console.WriteLine($"Trying depth limit: {depth}");
            if (Backtrack(0, 0, depth, 0))
                return true;
        }
        return false;
    }

    private bool Backtrack(int row, int col, int depthLimit, int currentDepth)
    {
        if (currentDepth == depthLimit) return false;
        if (row == n) return true;

        int nextRow = col == n - 1 ? row + 1 : row;
        int nextCol = col == n - 1 ? 0 : col + 1;

        for (int num = 1; num <= n; num++)
        {
            if (!rowUsed[row, num] && !colUsed[col, num])
            {
                square[row, col] = num;
                rowUsed[row, num] = colUsed[col, num] = true;

                if (Backtrack(nextRow, nextCol, depthLimit, currentDepth + 1))
                    return true;

                square[row, col] = 0;
                rowUsed[row, num] = colUsed[col, num] = false;
            }
        }

        return false;
    }

    public void PrintSquare()
    {
        Console.WriteLine("Latin Square:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{square[i, j],2} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Enter the size of the Latin Square (n x n): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out n) || n < 2)
            {
                Console.WriteLine("Invalid input. Please enter an integer greater than or equal to 2.");
            }
            else
            {
                break;
            }
        }

        var latinSquare = new LatinSquare(n);

        Console.WriteLine($"Creating a {n}x{n} Latin Square...");
        if (latinSquare.SolveSquare())
        {
            latinSquare.PrintSquare();
        }
        else
        {
            Console.WriteLine("No solution found for the given Latin Square.");
        }
    }
}
