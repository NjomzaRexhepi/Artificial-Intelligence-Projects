using System;
using System.Linq;

class LatinSquare
{
    private int[,] square;
    private int n;

    public LatinSquare(int n)
    {
        this.n = n;
        this.square = new int[n, n];
    }

    public bool Solve()
    {
        for (int depth = 1; depth <= n * n; depth++)
        {
            if (IDDFS(0, depth))
                return true;
        }
        return false;
    }

    private bool IDDFS(int index, int depthLimit)
    {
        if (index == n * n)
            return true; // Solved entire square.

        if (depthLimit == 0)
            return false; // Reached depth limit.

        int row = index / n;
        int col = index % n;

        // Skip prefilled cells
        if (square[row, col] != 0)
            return IDDFS(index + 1, depthLimit - 1);

        for (int num = 1; num <= n; num++)
        {
            if (IsSafe(row, col, num))
            {
                square[row, col] = num; // Place number
                if (IDDFS(index + 1, depthLimit - 1))
                    return true; // Move to the next cell.
                square[row, col] = 0; // Backtrack
            }
        }
        return false; // No valid number found at this depth.
    }

    private bool IsSafe(int row, int col, int num)
    {
        // Check row and column for the same number
        for (int i = 0; i < n; i++)
        {
            if (square[row, i] == num || square[i, col] == num)
                return false;
        }
        return true;
    }

    public void PrintSquare()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{square[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        int n = 4; // Order of the Latin Square
        LatinSquare latinSquare = new LatinSquare(n);

        if (latinSquare.Solve())
        {
            Console.WriteLine("Latin Square Solved:");
            latinSquare.PrintSquare();
        }
        else
        {
            Console.WriteLine("No solution found for the given Latin Square.");
        }
    }
}
