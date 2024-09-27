class Program
{
    public static void Main()
    {
        Console.WriteLine(CanCapture(new int[,] {
  { 0, 0, 0, 1, 0, 0, 0, 0 },
  { 0, 0, 0, 0, 0, 0, 0, 0 },
  { 0, 1, 0, 0, 0, 1, 0, 0 },
  { 0, 0, 0, 0, 1, 0, 1, 0 },
  { 0, 1, 0, 0, 0, 1, 0, 0 },
  { 0, 0, 0, 0, 0, 0, 0, 0 },
  { 0, 1, 0, 0, 0, 0, 0, 1 },
  { 0, 0, 0, 0, 1, 0, 0, 0 }
}));
    }
    public static bool CanCapture(int[,] board)
    {
        for (int y = 0; y < board.GetLength(0); y++)
        {
            for (int x = 0; x < board.GetLength(1); x++)
            {
                if (board[0, 0] == 1)
                {
                    if (board[1, 2] == 1 || board[2, 1] == 1) { return true; }
                }
                else if (board[board.GetLength(0) - 1, board.GetLength(1) - 1] == 1)
                {
                    if (board[6, 5] == 1 || board[5, 6] == 1) { return true; }
                }
                else if (board[0, board.GetLength(1) - 1] == 1)
                {
                    if (board[1, 5] == 1 || board[2, 6] == 1) { return true; }
                }
                else if (board[board.GetLength(0) - 1, 0] == 1)
                {
                    if (board[5, 1] == 1 || board[6, 2] == 1) { return true; }
                }
                else if (board[0, 1] == 1)
                {
                    if (board[1, 3] == 1 || board[2, 2] == 1 || board[2, 0] == 1) { return true; }
                }
                else if (board[1, 1] == 1)
                {
                    if (board[0, 3] == 1 || board[2, 3] == 1 || board[3, 2] == 1 || board[3, 0] == 1) { return true; }
                }
                else if (board[6, 1] == 1)
                {
                    if (board[7, 3] == 1 || board[5, 3] == 1 || board[4, 2] == 1 || board[4, 0] == 1) { return true; }
                }
                else if (board[6, 6] == 1)
                {
                    if (board[7, 4] == 1 || board[5, 4] == 1 || board[5, 4] == 1 || board[4, 7] == 1) { return true; }
                }
                else if (board[1, 6] == 1)
                {
                    if (board[0, 4] == 1 || board[2, 4] == 1 || board[3, 5] == 1 || board[3, 7] == 1) { return true; }
                }
                else if (board[1, 7] == 1)
                {
                    if (board[0, 5] == 1 || board[2, 5] == 1 || board[3, 6] == 1) { return true; }
                }
                else if (board[6, 7] == 1)
                {
                    if (board[4, 6] == 1 || board[5, 5] == 1 || board[7, 5] == 1) { return true; }
                }
                else if (board[7, 6] == 1)
                {
                    if (board[6, 4] == 1 || board[5, 5] == 1 || board[5, 7] == 1) { return true; }
                }
                else if (board[0, 6] == 1)
                {
                    if (board[1, 4] == 1 || board[2, 5] == 1 || board[2, 7] == 1) { return true; }
                }
                else if (board[0, 1] == 1)
                {
                    if (board[2, 0] == 1 || board[2, 3] == 1 || board[1, 3] == 1) { return true; }
                }
                else if (board[7, 1] == 1)
                {
                    if (board[5, 0] == 1 || board[5, 3] == 1 || board[6, 4] == 1) { return true; }
                }
                else if (x == 1 && board[y, x] == 1)
                {
                    if (board[y - 2, x - 1] == 1 || board[y + 2, x - 1] == 1 || board[y - 2, x + 1] == 1 || board[y + 1, x + 2] == 1 || board[y + 2, x + 1] == 1) { return true; }
                }
                else if (board[y, x] == 1 && y == 0)
                {
                    if (board[y + 1, x - 2] == 1 || board[y + 2, x - 1] == 1 || board[y + 2, x + 1] == 1 || board[y + 1, x + 2] == 1) { return true; }
                }
                else if (board[y, x] == 1 && y == 1)
                {
                    if (board[y + 2, x - 1] == 1 || board[y + 1, x - 2] == 1 || board[y - 1, x - 2] == 1 || board[y - 1, x + 2] == 1 || board[y + 1, x + 2] == 1 || board[y + 2, x + 1] == 1) { return true; }
                }
                else if (x == 7 && board[y, x] == 1)
                {
                    if (board[y - 2, x - 1] == 1 || board[y - 1, x - 2] == 1 || board[y + 1, x - 2] == 1 || board[y + 2, x - 1] == 1) { return true; }
                }
                else if (x == 0 && board[y, x] == 1)
                {
                    if (board[y - 2, x + 1] == 1 || board[y - 1, x + 2] == 1 || board[y + 1, x + 2] == 1 || board[y + 2, x + 1] == 1) { return true; }
                }
                else if (board[y, x] == 1 && y == 6)
                {
                    if (board[y + 1, x - 2] == 1 || board[y - 1, x - 2] == 1 || board[y - 2, x - 1] == 1 || board[y - 2, x + 1] == 1 || board[y - 1, x + 2] == 1 || board[y + 1, x + 2] == 1) { return true; }
                }
                else if (board[y, x] == 1)
                {
                    if (board[y - 2, x - 1] == 1 || board[y - 1, x - 2] == 1 || board[y + 1, x - 2] == 1 || board[y + 2, x - 1] == 1 || board[y + 2, x + 1] == 1 || board[y + 1, x + 2] == 1 || board[y - 1, x + 2] == 1 || board[y - 2, x + 1] == 1) { return true; }
                }
            }
        }
        return false;

    }
}