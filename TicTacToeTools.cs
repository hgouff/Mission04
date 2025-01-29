namespace TicTacToe;


    internal class TicTacToeTools
    {
        public void PrintBoard(string[] boardArray)
        {
            for (int i = 0; i < boardArray.Length; i++)
            {
                // Draw out the board
                Console.Write($"[{boardArray[i]}]");
                // Every three lines, write a new line so the board actually looks correct
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        public int CheckWinner(string[] boardArray)
        {
            // Default winner to none (0)
            int winner = 0;
            // Check if anyone won
            if (boardArray[0] == boardArray[1] && boardArray[1] == boardArray[2])
            {
                if (boardArray[0] == "X")
                {
                    winner = 1;
                }
                else if (boardArray[0] == "O")
                {
                    winner = 2;
                }
            }
            else if (boardArray[3] == boardArray[4] && boardArray[4] == boardArray[5])
            {
                if (boardArray[3] == "X")
                {
                    winner = 1;
                }
                else if (boardArray[3] == "O")
                {
                    winner = 2;
                }
            }
            else if (boardArray[6] == boardArray[7] && boardArray[7] == boardArray[8])
            {
                if (boardArray[6] == "X")
                {
                    winner = 1;
                }
                else if (boardArray[6] == "O")
                {
                    winner = 2;
                }
            }
            else if (boardArray[0] == boardArray[3] && boardArray[3] == boardArray[6])
            {
                if (boardArray[0] == "X")
                {
                    winner = 1;
                }
                else if (boardArray[0] == "O")
                {
                    winner = 2;
                }
            }
            else if (boardArray[1] == boardArray[4] && boardArray[4] == boardArray[7])
            {
                if (boardArray[1] == "X")
                {
                    winner = 1;
                }
                else if (boardArray[1] == "O")
                {
                    winner = 2;
                }
            }
            else if (boardArray[2] == boardArray[5] && boardArray[5] == boardArray[8])
            {
                if (boardArray[2] == "X")
                {
                    winner = 1;
                }
                else if (boardArray[2] == "O")
                {
                    winner = 2;
                }
            }
            else if (boardArray[0] == boardArray[4] && boardArray[4] == boardArray[8])
            {
                if (boardArray[0] == "X")
                {
                    winner = 1;
                }
                else if (boardArray[0] == "O")
                {
                    winner = 2;
                }
            }
            else if (boardArray[2] == boardArray[4] && boardArray[4] == boardArray[6])
            {
                if (boardArray[2] == "X")
                {
                    winner = 1;
                }
                else if (boardArray[2] == "O")
                {
                    winner = 2;
                }
            }
            return winner;
        }
    }

    
