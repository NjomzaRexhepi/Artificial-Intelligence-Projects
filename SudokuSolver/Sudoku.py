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