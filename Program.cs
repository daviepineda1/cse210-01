using System;
using Unit03.Game;

/*
Author: David Pineda
Game: Tic Tac Toe game

*/


namespace Unit03
{
    /// <summary>
    /// The program's entry point.
    /// </summary>


    class Program
    {
  
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();

            var player = nextPlayer("");
            var board = createBoard();

            while ((isWinner(board) || isDraw(board)))
            {
                displayBoard(board)
                makeMove(player, board)
                player = nextPlayer(player)
                displayBoard(board)

            }
            Console.WriteLine("Good game. Thanks for playing!");

        }


        public void createBoard()
        {
            int[] = board;

            foreach (square in range(9))
            {
                board.add(square + 1);
            }
            return board;
        }


        public void displayBoard(board)
        {
            Console.Write();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("+++");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("+++");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.Write();
        }

        public void isDraw(board)
        {
            foreach ( square in range(9))
            {
                if (board[square] != 'x' && board[square] != 'o')
                {
                    return True;
                }
                return False;
            }
        }

        public void isWinner(board)
        {
            return
            (board[0] == board[1] == board[2] ||
            board[3] == board[4] == board[5] ||
            board[6] == board[7] == board[8] ||
            board[0] == board[3] == board[6] ||
            board[1] == board[4] == board[7] ||
            board[2] == board[5] == board[8] ||
            board[0] == board[4] == board[8] ||
            board[2] == board[4] == board[6]);
        }

        public void makeMove(player,board)
        {
            Console.WriteLine($"{player}'s turn to choose a square (1-9): "); 
            int square = Convert.ToInt32(Console.ReadLine());
            board[square - 1] = player;

        }

        public void nextPlayer(current)
        {
            if (current == "" or current == "o")
            {
                return "x";
            }
                
            else{
                current == "x";
            } 
            return "o";
        }
    }

}
