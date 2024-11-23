using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose difficulty level: ");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Hard");

        int level;
        while (true)
        {
            Console.Write("Your choice (1/2/3): ");
            if (int.TryParse(Console.ReadLine(), out level) && (level == 1 || level == 2 || level == 3))
                break;

            Console.WriteLine("Please choose a valid number (1, 2, or 3).");
        }

        int[,] easyGrid = {
            {5, 3, 0, 0, 7, 0, 0, 0, 0},
            {6, 0, 0, 1, 9, 5, 0, 0, 0},
            {0, 9, 8, 0, 0, 0, 0, 6, 0},
            {8, 0, 0, 0, 6, 0, 0, 0, 3},
            {4, 0, 0, 8, 0, 3, 0, 0, 1},
            {7, 0, 0, 0, 2, 0, 0, 0, 6},
            {0, 6, 0, 0, 0, 0, 2, 8, 0},
            {0, 0, 0, 4, 1, 9, 0, 0, 5},
            {0, 0, 0, 0, 8, 0, 0, 7, 9}
        };

        int[,] mediumGrid = {
            {0, 0, 0, 0, 0, 0, 0, 1, 2},
            {0, 0, 0, 3, 0, 5, 0, 0, 0},
            {0, 0, 1, 0, 2, 0, 4, 0, 0},
            {0, 3, 0, 0, 0, 0, 0, 9, 0},
            {0, 0, 0, 7, 0, 8, 0, 0, 0},
            {0, 2, 0, 0, 0, 0, 0, 6, 0},
            {0, 0, 5, 0, 9, 0, 8, 0, 0},
            {0, 0, 0, 2, 0, 6, 0, 0, 0},
            {9, 4, 0, 0, 0, 0, 0, 0, 0}
        };

        int[,] hardGrid = {
    {8, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 3, 6, 0, 0, 0, 0, 0},
    {0, 7, 0, 0, 9, 0, 2, 0, 0},
    {0, 5, 0, 0, 0, 7, 0, 0, 0},
    {0, 0, 0, 0, 4, 5, 7, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 3, 0},
    {0, 0, 1, 0, 0, 0, 0, 6, 8},
    {0, 0, 8, 5, 0, 0, 0, 1, 0},
    {0, 9, 0, 0, 0, 0, 4, 0, 0}
};


        int[,] grid = level switch
        {
            1 => easyGrid,
            2 => mediumGrid,
            3 => hardGrid,
            _ => throw new Exception("Invalid level")
        };

        Console.WriteLine("\nGiven Sudoku:");
        SudokuProblem.PrintSudoku(grid);

        var solution = SudokuProblem.BfsBacktrackingSudoku(grid);
        if (solution != null)
        {
            Console.WriteLine("Solved Sudoku:");
            SudokuProblem.PrintSudoku(solution);
        }
        else
        {
            Console.WriteLine("No solution found for this Sudoku.");
        }
    }
}
