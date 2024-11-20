from collections import deque

def print_sudoku(grid):
    for row in grid:
        print(" ".join(str(num) if num != 0 else "." for num in row))
    print()

def is_valid_move(grid, row, col, num):
    for i in range(9):
        if grid[row][i] == num or grid[i][col] == num:
            return False
        
    start_row, start_col = 3 * (row // 3), 3 * (col // 3)
    for i in range(start_row, start_row + 3):
        for j in range(start_col, start_col + 3):
            if grid[i][j] == num:
                return False
    
    return True

def bfs_backtracking_sudoku(grid):
    queue = deque([(grid, 0, 0)])  
    while queue:
        current_grid, row, col = queue.popleft()

        if row == 9:  
            return current_grid
        
        if current_grid[row][col] != 0: 
            next_row, next_col = (row, col + 1) if col < 8 else (row + 1, 0)
            queue.append((current_grid, next_row, next_col))
        else:
            for num in range(1, 10):
                if is_valid_move(current_grid, row, col, num):
                    new_grid = [r[:] for r in current_grid]  
                    new_grid[row][col] = num
                    next_row, next_col = (row, col + 1) if col < 8 else (row + 1, 0)
                    queue.append((new_grid, next_row, next_col))
    
    return None 

def main():
    print("Zgjidhni nivelin e vështirësisë: ")
    print("1. Lehtë")
    print("2. Mesatar")
    print("3. Vështirë")
    
    while True:
        try:
            level = int(input("Zgjedhja juaj (1/2/3): "))
            if level in [1, 2, 3]:
                break
            else:
                print("Ju lutem zgjidhni një numër të vlefshëm (1, 2 ose 3).")
        except ValueError:
            print("Ju lutem shkruani vetëm numra!")
            
            
            
        easy_grid = [
        [5, 3, 0, 0, 7, 0, 0, 0, 0],
        [6, 0, 0, 1, 9, 5, 0, 0, 0],
        [0, 9, 8, 0, 0, 0, 0, 6, 0],
        [8, 0, 0, 0, 6, 0, 0, 0, 3],
        [4, 0, 0, 8, 0, 3, 0, 0, 1],
        [7, 0, 0, 0, 2, 0, 0, 0, 6],
        [0, 6, 0, 0, 0, 0, 2, 8, 0],
        [0, 0, 0, 4, 1, 9, 0, 0, 5],
        [0, 0, 0, 0, 8, 0, 0, 7, 9]
    ]

    medium_grid = [
        [0, 0, 0, 0, 0, 0, 0, 1, 2],
        [0, 0, 0, 3, 0, 5, 0, 0, 0],
        [0, 0, 1, 0, 2, 0, 4, 0, 0],
        [0, 3, 0, 0, 0, 0, 0, 9, 0],
        [0, 0, 0, 7, 0, 8, 0, 0, 0],
        [0, 2, 0, 0, 0, 0, 0, 6, 0],
        [0, 0, 5, 0, 9, 0, 8, 0, 0],
        [0, 0, 0, 2, 0, 6, 0, 0, 0],
        [9, 4, 0, 0, 0, 0, 0, 0, 0]
    ]

    hard_grid = [
        [0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 3, 0, 0, 0, 0, 1],
        [0, 0, 0, 0, 0, 0, 0, 5, 0],
        [0, 0, 8, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 7, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 6],
        [0, 0, 0, 0, 0, 0, 2, 0, 0],
        [0, 0, 0, 0, 8, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 7, 0]
    ]

    if level == 1:
        grid = easy_grid
    elif level == 2:
        grid = medium_grid
    else:
        grid = hard_grid

    print("\nSudoku i dhënë:")
    print_sudoku(grid)

    solution = bfs_backtracking_sudoku(grid)
    if solution:
        print("Zgjidhja e Sudoku:")
        print_sudoku(solution)
    else:
        print("Nuk ka zgjidhje për këtë Sudoku.")

if __name__ == "__main__":
    main()