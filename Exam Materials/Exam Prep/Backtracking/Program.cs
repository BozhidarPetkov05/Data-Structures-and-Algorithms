namespace Backtracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueenProblem(4, 4);
        }

        public static void QueenProblem(int size, int queens)
        {
            char[,] board = new char[size, size];
            for (int r = 0; r < size; r++)
                for (int c = 0; c < size; c++)
                    board[r, c] = '-';

            List<char[,]> solutions = new List<char[,]>();
            SolveQueens(0, board, size, solutions);

            foreach (var solution in solutions)
            {
                PrintBoard(solution);
                Console.WriteLine();
            }
        }

        public static void SolveQueens(int row, char[,] board, int size, List<char[,]> solutions)
        {
            if (row == size)
            {
                char[,] copy = new char[size, size];
                Array.Copy(board, copy, board.Length);
                solutions.Add(copy);
                return;
            }

            for (int col = 0; col < size; col++)
            {
                if (IsSafePosition(board, size, row, col))
                {
                    board[row, col] = 'Q'; 
                    SolveQueens(row + 1, board, size, solutions);
                    board[row, col] = '-';
                }
            }
        }

        public static bool IsSafePosition(char[,] board, int size, int row, int col)
        {
            //Check for safe row
            for (int i = 0; i < size; i++)
            {
                if (board[row, i] == 'Q')
                {
                    return false;
                }
            }

            //Check for safe column
            for (int i = 0; i < size; i++)
            {
                if (board[i, col] == 'Q')
                {
                    return false;
                }
            }

            //Check for safe diagonals
            int x = row;
            int y = col;

            //top left
            while (x >= 0 && y >= 0)
            {
                if (board[x, y] == 'Q')
                {
                    return false;
                }
                x--;
                y--;
            }

            //top right
            int x1 = row;
            int y1 = col;
            while (x1 < size && y1 >= 0)
            {
                if (board[x1, y1] == 'Q')
                {
                    return false;
                }
                x1++;
                y1--;
            }

            //bottom left
            int x2 = row;
            int y2 = col;
            while (x2 >= 0 && y2 < size)
            {
                if (board[x2, y2] == 'Q')
                {
                    return false;
                }
                x2--;
                y2++;
            }

            //bottom right
            int x3 = row;
            int y3 = col;
            while (x3 < size && y3 < size)
            {
                if (board[x3, y3] == 'Q')
                {
                    return false;
                }
                x3++;
                y2++;
            }

            return true;
        }

        public static void PrintBoard(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(0); col++)
                {
                    if (board[row, col] != 'Q')
                    {
                        Console.Write('-' + " ");
                    }
                    else
                    {
                        Console.Write(board[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}