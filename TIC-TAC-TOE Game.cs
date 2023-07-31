
using System;

class Program
{
    static char[,] board = {{'1','2','3'},{'4','5','6'},{'7','8','9'}};

    static int choice;
    static int row,column;
    static char turn = 'X';
    static bool draw = false;

    static void Main(string[] args)
    {
        display_board();
        while (!draw)
        {
            player_turn();
            display_board();
            if (check_win())
            {
                break;
            }
            toggle_turn();
        }
        if (draw)
        {
            Console.WriteLine("The game is a draw!");
        }
        else
        {
            toggle_turn();
            Console.WriteLine("Player " + turn + " wins!");
        }
    }

    static void display_board()
    {
        Console.WriteLine("PLAYER - 1 [X]\tPLAYER - 2 [O]\n");
        Console.WriteLine("\t     |     |     ");
        Console.WriteLine("\t  " + board[0,0] + "  |  " + board[0,1] + "  |  " + board[0,2] + "  ");
        Console.WriteLine("\t_____|_____|_____");
        Console.WriteLine("\t     |     |     ");
        Console.WriteLine("\t  " + board[1,0] + "  |  " + board[1,1] + "  |  " + board[1,2] + "  ");
        Console.WriteLine("\t_____|_____|_____");
        Console.WriteLine("\t     |     |     ");
        Console.WriteLine("\t  " + board[2,0] + "  |  " + board[2,1] + "  |  " + board[2,2] + "  ");
        Console.WriteLine("\t     |     |     ");
    }

    static void player_turn()
    {
        if (turn == 'X')
        {
            Console.Write("\nPlayer - 1 [X] turn : ");
        }
        else if (turn == 'O')
        {
            Console.Write("\nPlayer - 2 [O] turn : ");
        }
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: row=0; column=0; break;
            case 2: row=0; column=1; break;
            case 3: row=0; column=2; break;
            case 4: row=1; column=0; break;
            case 5: row=1; column=1; break;
            case 6: row=1; column=2; break;
            case 7: row=2; column=0; break;
            case 8: row=2; column=1; break;
            case 9: row=2; column=2; break;
        }

        if (board[row,column] != 'X' && board[row,column] != 'O')
        {
            board[row,column] = turn;
        }
        else
        {
            Console.WriteLine("Sorry, the row {0} column {1} is already marked with an {2}.", row, column, board[row,column]);
            player_turn();
        }
    }

    static void toggle_turn()
    {
        if (turn == 'X')
        {
            turn = 'O';
        }
        else
        {
            turn = 'X';
        }
    }

    static bool check_win()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i,0] == board[i,1] && board[i,1] == board[i,2] ||
                board[0,i] == board[1,i] && board[1,i] == board[2,i])
            {
                return true;
            }
        }
        if (board[0,0] == board[1,1] && board[1,1] == board[2,2] ||
            board[0,2] == board[1,1] && board[1,1] == board[2,0])
        {
            return true;
        }
        if (board[0,0] != '1' && board[0,1] != '2' && board[0,2] != '3' &&
            board[1,0] != '4' && board[1,1] != '5' && board[1,2] != '6' &&
            board[2,0] != '7' && board[2,1] != '8' && board[2,2] != '9')
        {
            draw = true;
        }
        return false;
    }
}
