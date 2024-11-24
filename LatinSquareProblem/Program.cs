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
        return Backtrack(0, 0);
    }

    private bool Backtrack(int row, int col)
    {
        if (row == n) return true; // Base case: All rows are filled

        // Calculate the next cell
        int nextRow = col == n - 1 ? row + 1 : row;
        int nextCol = col == n - 1 ? 0 : col + 1;

        // Create a random list of numbers to try
        List<int> candidates = new List<int>();
        for (int num = 1; num <= n; num++)
        {
            if (!rowUsed[row, num] && !colUsed[col, num])
                candidates.Add(num);
        }

        // Randomly shuffle the candidates
        Random rng = new Random();
        for (int i = candidates.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (candidates[i], candidates[j]) = (candidates[j], candidates[i]);
        }

        // Try placing the numbers in a random order
        foreach (var num in candidates)
        {
            // Place the number and mark it used
            square[row, col] = num;
            rowUsed[row, num] = colUsed[col, num] = true;

            // Recurse with the next cell
            if (Backtrack(nextRow, nextCol))
                return true;

            // Undo the placement if it didn't work
            square[row, col] = 0;
            rowUsed[row, num] = colUsed[col, num] = false;
        }

        return false; // No valid candidate found, backtrack
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
                break; // Valid input
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
