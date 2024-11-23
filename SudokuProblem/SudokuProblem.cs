using System;
using System.Collections.Generic;

public static class SudokuProblem
{
    public static void PrintSudoku(int[,] grid)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(grid[i, j] == 0 ? ". " : $"{grid[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static bool IsValidMove(int[,] grid, int row, int col, int num)
    {
        for (int i = 0; i < 9; i++)
        {
            if (grid[row, i] == num || grid[i, col] == num)
                return false;
        }

        int startRow = (row / 3) * 3;
        int startCol = (col / 3) * 3;
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (grid[i, j] == num)
                    return false;
            }
        }

        return true;
    }

    public static int[,] BfsBacktrackingSudoku(int[,] grid)
    {
        var queue = new Queue<(int[,], int, int)>();
        queue.Enqueue((grid, 0, 0));

        while (queue.Count > 0)
        {
            var (currentGrid, row, col) = queue.Dequeue();

            if (row == 9)
                return currentGrid;

            if (currentGrid[row, col] != 0)
            {
                int nextRow = col < 8 ? row : row + 1;
                int nextCol = col < 8 ? col + 1 : 0;
                queue.Enqueue((currentGrid, nextRow, nextCol));
            }
            else
            {
                for (int num = 1; num <= 9; num++)
                {
                    if (IsValidMove(currentGrid, row, col, num))
                    {
                        int[,] newGrid = (int[,])currentGrid.Clone();
                        newGrid[row, col] = num;

                        int nextRow = col < 8 ? row : row + 1;
                        int nextCol = col < 8 ? col + 1 : 0;

                        queue.Enqueue((newGrid, nextRow, nextCol));
                    }
                }
            }
        }

        return null;
    }
}
