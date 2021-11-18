using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc200
    {
        /// <summary>
        /// BFS
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int result = 0;
            int nr = grid.Length;
            int nc = grid[0].Length;

            for (int r = 0; r < nr; r++) {
                for (int c = 0; c < nc; c++) {
                    if (grid[r][c] == '1') {
                        result += 1;
                        grid[r][c] = '0';
                        Queue<int> neighbors = new Queue<int>();
                        neighbors.Enqueue(r * nc + c);
                        while (neighbors.Count > 0) {
                            int id = neighbors.Dequeue();
                            int row = id / nc;
                            int col = id % nc;
                            if (row - 1 >= 0 && grid[row - 1][col] == '1') {
                                neighbors.Enqueue((row - 1) * nc + col);
                                grid[row - 1][col] = '0';
                            }
                            if (row + 1 < nr && grid[row + 1][col] == '1') {
                                neighbors.Enqueue((row + 1) * nc + col);
                                grid[row + 1][col] = '0';
                            }
                            if (col - 1 >= 0 && grid[row][col - 1] == '1') {
                                neighbors.Enqueue(row * nc + col - 1);
                                grid[row][col - 1] = '0';
                            }
                            if (col + 1 < nc && grid[row][col + 1] == '1') {
                                neighbors.Enqueue(row * nc + col + 1);
                                grid[row][col + 1] = '0';
                            }
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// DFS
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslands1(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int result = 0;
            int nr = grid.Length;
            int nc = grid[0].Length;

            for (int row = 0; row < nr; row++) {
                for (int col = 0; col < nc; col++) {
                    if (grid[row][col] == '1') {
                        result += 1;
                        DFS(grid, row, col);
                    }
                }
            }

            return result;
        }

        public void DFS(char[][] grid, int row, int col)
        {
            grid[row][col] = '0';
            int nr = grid.Length;
            int nc = grid[0].Length;
            if (row - 1 >= 0 && grid[row - 1][col] == '1') {
                DFS(grid, row - 1, col);
            }
            if (row + 1 < nr && grid[row + 1][col] == '1') {
                DFS(grid, row + 1, col);
            }
            if (col - 1 >= 0 && grid[row][col - 1] == '1') {
                DFS(grid, row, col - 1);
            }
            if (col + 1 < nc && grid[row][col + 1] == '1') {
                DFS(grid, row, col + 1);
            }
        }
    }
}
