public class Solution {
    public bool IsValidSudoku(char[][] board) {
        const char EMPTY_SLOT = '.';
        HashSet<char>[] subBoxes = new HashSet<char>[9];

        // Each row
        bool isRowValid = true;
        bool isColValid = true;
        bool isSubBoxValid = true;
        for (int col = 0; col < board.Length; col++)
        {
            HashSet<char> colChar = new HashSet<char>();
            HashSet<char> rowChar = new HashSet<char>();
            
            for (int row = 0; row < board[col].Length; row++)
            {
                char val = board[col][row];

                // Check each row
                if (val != EMPTY_SLOT)
                {
                    bool rowAdded = rowChar.Add(val);
                    if (!rowAdded)
                    {
                        isRowValid = false;
                    }
                }

                // Check each column
                if (board[row][col] != EMPTY_SLOT)
                {
                    bool colAdded = colChar.Add(board[row][col]);
                    if (!colAdded)
                    {
                        isColValid = false;
                    }
                }

                // Check each sub-box
                int boxIndex = (row / 3) * 3 + (col / 3);
                if (subBoxes[boxIndex] == null)
                {
                    subBoxes[boxIndex] = new HashSet<char>();
                }

                if (val != EMPTY_SLOT && !subBoxes[boxIndex].Add(val))
                {
                    isSubBoxValid = false;
                }
            }
        }
        
        return isRowValid && isColValid && isSubBoxValid;
    }
}
