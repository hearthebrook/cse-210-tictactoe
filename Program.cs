class TicTacToe
{
    static void Main(string[] args)
    {

        List<string> board = GetNewBoard();
        string currentPlayer = "x";

        while (!IsGameOver(board))
        {
            DisplayBoard(board);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        DisplayBoard(board);
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>
    static List<string> GetNewBoard()
    {
        List<string> num_list = new List<string>
        {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
        return num_list;
        /* 
        TEACHER SOLUTION
        // create list
        List<string> numList = new List<string>();

        for (int i=1; i <= 9; i++)
        {
            numList.Add(i.ToString());
        }
        return numList
        */
    }

    /// <summary>Displays the board in a 3x3 grid.</summary>
    /// <param name="board">The board</param>
    static void DisplayBoard(List<string> board)
    {
        Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");

    }

    /// <summary>
    /// Determines if the game is over because of a win or a tie.
    /// </summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the game is over</returns>
    static bool IsGameOver(List<string> board)
    {
        if (IsWinner(board, "x"))
        {
            return true;
        }
        if (IsWinner(board, "o"))
        {
            return true;
        }
        if (IsTie(board))
        {
            return true;
        }
        return false;
        // TEACHER ANSWER 
        // return IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board)
    }
    

    /// <summary>Determines if the provided player has a tic tac toe.</summary>
    /// <param name="board">The current board</param>
    /// <param name="player">The player to check for a win</param>
    /// <returns></returns>
    static bool IsWinner(List<string> board, string player)
    {/*
        // MINE IS WRONG AND DOESNT USE PLAYER 
        if (board[0] == board[1] &&
            board[1] == board[2])
            {
            return true;
            }
        if (board[3] == board[4] &&
            board[4] == board[5])
            {
            return true;
            }   
        if (board[6] == board[7] &&
            board[7] == board[8])
            {
            return true;
            }  
        if (board[0] == board[3] &&
            board[3] == board[6])
            {
            return true;
            }  
        if (board[1] == board[4] &&
            board[4] == board[7])
            {
            return true;
            }     
        if (board[2] == board[5] &&
            board[5] == board[8])
            {
            return true;
            }   
        if (board[0] == board[4] &&
            board[4] == board[8])
            {
            return true;
            }  
        if (board[2] == board[4] &&
            board[4] == board[8])
            {
            return true;
            }   
        return false;
        */
        // TEACHER'S ANSWER
        if (board[0] == player && board[1] == player && board[2] == player)
        {
            return true;
        }
        if (board[3] == player && board[4] == player && board[5] == player)
        {
            return true;
        }
        if (board[6] == player && board[7] == player && board[8] == player)
        {
            return true;
        }
        if (board[2] == player && board[4] == player && board[6] == player)
        {
            return true;
        }
        if (board[0] == player && board[4] == player && board[8] == player)
        {
            return true;
        }
        if (board[0] == player && board[3] == player && board[6] == player)
        {
            return true;
        }
        if (board[1] == player && board[4] == player && board[7] == player)
        {
            return true;
        }
        if (board[2] == player && board[5] == player && board[8] == player)
        {
            return true;
        }
        return false;
    }

    /// <summary>Determines if the board is full with no more moves possible.</summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the board is full.</returns>
    static bool IsTie(List<string> board)
    {
        // cycle through list and make sure their are no numbers
        // string to int char.isDigit
        foreach (string place in board)
        {
            bool number = Char.IsDigit(place, 0);
            if (number == true)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>Cycles through the players (from x to o and o to x)</summary>
    /// <param name="currentPlayer">The current players sign (x or o)</param>
    /// <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        if (currentPlayer == "o")
        {
            return "x";
        }
        else
        {
            return "o";
        }
    }

    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    static int GetMoveChoice(string currentPlayer)
    {
        //user input consol.readLine
        // return int
        int playerMove = int.Parse(Console.ReadLine()??"0");
        return playerMove -1;
    }

    /// <summary>
    /// Places the current players mark on the board at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="board">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
        //repace number in list with new current player
        // choice is index
        board[choice] = currentPlayer;
    }
}
