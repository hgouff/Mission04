//Jessica Lasson, Dawson Newell, Hannah Gouff, Kayden Stuart

using TicTacToe;// create TicTacToeTools object
TicTacToeTools t = new TicTacToeTools();
// create board
//int[] board = Enumerable.Range(1, 9).ToArray();
string choice = "";
string player1 = "X";
string player2 = "O";
int gameStatus = 0;
int turn = 2;
string activePlayer = "";
int numericChoice = 0;
string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine($"Player 1 is {player1} and Player 2 is {player2}");
// print board
do
{
    t.PrintBoard(board);
    if (turn % 2 == 0)
    {
        Console.WriteLine("Player 1, choose your box (1-9):");
        activePlayer = player1;
    }
    else
    {
        Console.WriteLine("Player 2, choose your box (1-9):");
        activePlayer = player2;
    }
    do
    {
        choice = Console.ReadLine();
        if (!int.TryParse(choice, out numericChoice) || numericChoice < 1 || numericChoice > 9 ||
            board[numericChoice - 1] != (numericChoice).ToString() || board[numericChoice - 1] == "X" ||
            board[numericChoice - 1] == "O")
        {
            Console.WriteLine("Choose a valid input");
        }
            
    } while (!int.TryParse(choice, out numericChoice) || numericChoice < 1 || numericChoice > 9 || board[numericChoice - 1] != (numericChoice).ToString() || board[numericChoice - 1] == "X" || board[numericChoice - 1] =="O");
    numericChoice = int.Parse(choice) - 1;
    board[numericChoice] = activePlayer;
    // change player's turn
    turn++;
    // check for winner
    gameStatus = t.CheckWinner(board);
    if (turn -2 == 9 && gameStatus == 0)
    {
        gameStatus = 3;
    }
} while ( gameStatus == 0);
if (gameStatus == 3)
{
    Console.WriteLine("It's a draw!");
}
else
{
    t.PrintBoard(board);
    Console.WriteLine($"Player {gameStatus} wins!");
}