using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Dustin Johnson
 * 
 */

namespace ProgrammingProject4
{
    public partial class ticTacToeForm : Form
    {
        public ticTacToeForm()
        {
            InitializeComponent();
            newGameButton.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //initialize variables
            resultLabel.Text = " ";
            const int ROWS = 3;
            const int COLS = 3;
            string xWin = "X Wins!";
            string oWin = "O Wins!";
            string draw = "Draw!";
            int x = 0;
            int o = 0;

            //initialize 2D array for game
            int[,] gameGrid = new int[ROWS, COLS];

            // fill array 
            Generate(gameGrid);

            // output array to labels
            output1.Text = LabelOutput(gameGrid[0, 0]);
            output2.Text = LabelOutput(gameGrid[0, 1]);
            output3.Text = LabelOutput(gameGrid[0, 2]);
            output4.Text = LabelOutput(gameGrid[1, 0]);
            output5.Text = LabelOutput(gameGrid[1, 1]);
            output6.Text = LabelOutput(gameGrid[1, 2]);
            output7.Text = LabelOutput(gameGrid[2, 0]);
            output8.Text = LabelOutput(gameGrid[2, 1]);
            output9.Text = LabelOutput(gameGrid[2, 2]);

            // checks for X wins
            if ((CheckAcrossTop(gameGrid) == 0) || (CheckAcrossMid(gameGrid) == 0) || (CheckAcrossBottom(gameGrid) == 0) ||
                (CheckLeftDown(gameGrid) == 0) || (CheckMidDown(gameGrid) == 0) || (CheckRightDown(gameGrid) == 0) ||
                (CheckDiagLeft(gameGrid) == 0) || (CheckDiagRight(gameGrid) == 0))
            {
                x = 1;
            }

            // checks for O wins
            if ((CheckAcrossTop(gameGrid) == 1) || (CheckAcrossMid(gameGrid) == 1) || (CheckAcrossBottom(gameGrid) == 1) ||
                (CheckLeftDown(gameGrid) == 1) || (CheckMidDown(gameGrid) == 1) || (CheckRightDown(gameGrid) == 1) ||
                (CheckDiagLeft(gameGrid) == 1) || (CheckDiagRight(gameGrid) == 1))
            {
                o = 1;
            }

            // display if neither won
            if (x == 0 && o == 0)
            {
                resultLabel.Text = draw;

            }
            // display if X won
            else if (x == 1 && o == 0)
            {
                resultLabel.Text = xWin;

            }
            // display if O won
            else if (o == 1 && x == 0)
            {
                resultLabel.Text = oWin;
            }
            // displays if both X and O won
            else if (x == 1 && o == 1)
            {
                resultLabel.Text = "You're both winners in my book XOXO";
            }
        }

        // fill 2D int array with elements randomly with either 0s or 1s
        void Generate(int[,] grid)
        {
            Random rand = new Random();

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = rand.Next(0, 2);
                }
            }
        }

        // uses input to determine whether element is an X or O
        string LabelOutput(int i)
        {
            string output = "";
            if (i == 0)
            {
                output = "X";
            }
            else
            {
                output = "O";
            }
            return output;
        }

        // all check methods utilize an indicator to differentiate between X and O matches, returns 2 if no match found
        // checks top row for matches
        int CheckAcrossTop(int[,] grid)
        {
            int indicator = 2;

            if ((grid[0, 0] == 0) && (grid[0, 1] == 0) && (grid[0, 2] == 0))
            {
                indicator = 0;
            }
            else if ((grid[0, 0] == 1) && (grid[0, 1] == 1) && (grid[0, 2] == 1))
            {
                return indicator = 1;
            }

            return indicator;

        }

        // checks middle row for matches
        int CheckAcrossMid(int[,] grid)
        {

            int indicator = 2;

            if ((grid[1, 0] == 0) && (grid[1, 1] == 0) && (grid[1, 2] == 0))
            {
                indicator = 0;
            }
            else if ((grid[1, 0] == 1) && (grid[1, 1] == 1) && (grid[1, 2] == 1))
            {
                return indicator = 1;
            }

            return indicator;


        }

        // checks bottom row for matches
        int CheckAcrossBottom(int[,] grid)
        {
            int indicator = 2;

            if ((grid[2, 0] == 0) && (grid[2, 1] == 0) && (grid[2, 2] == 0))
            {
                indicator = 0;
            }
            else if ((grid[2, 0] == 1) && (grid[2, 1] == 1) && grid[2, 2] == 1)
            {
                return indicator = 1;
            }

            return indicator;
        }

        // checks left column for mathches
        int CheckLeftDown(int[,] grid)
        {
            int indicator = 2;

            if ((grid[0, 0] == 0) && (grid[1, 0] == 0) && (grid[2, 0] == 0))
            {
                indicator = 0;
            }
            else if ((grid[0, 0] == 1) && (grid[1, 0] == 1) && (grid[2, 0] == 1))
            {
                return indicator = 1;
            }

            return indicator;
        }

        // checks middle column for matches
        int CheckMidDown(int[,] grid)
        {
            int indicator = 2;

            if ((grid[0, 1] == 0) && (grid[1, 1] == 0) && (grid[2, 1] == 0))
            {
                indicator = 0;
            }
            else if ((grid[0, 1] == 1) && (grid[1, 1] == 1) && (grid[2, 1] == 1))
            {
                return indicator = 1;
            }

            return indicator;
        }

        // checks right column for matches
        int CheckRightDown(int[,] grid)
        {
            int indicator = 2;

            if ((grid[0, 2] == 0) && (grid[1, 2] == 0) && (grid[2, 2] == 0))
            {
                indicator = 0;
            }
            else if ((grid[0, 2] == 1) && (grid[1, 2] == 1) && (grid[2, 2] == 1))
            {
                return indicator = 1;
            }

            return indicator;
        }

        // checks diagonally top left to bottom right for matches
        int CheckDiagLeft(int[,] grid)
        {
            int indicator = 2;

            if ((grid[0, 0] == 0) && grid[1, 1] == 0 && grid[2, 2] == 0)
            {
                indicator = 0;
            }
            else if ((grid[0, 0] == 1) && (grid[1, 1] == 1) && (grid[2, 2] == 1))
            {
                return indicator = 1;
            }

            return indicator;
        }

        // checks diagonally top right to bottom left for matches
        int CheckDiagRight(int[,] grid)
        {
            int indicator = 2;

            if ((grid[0, 2] == 0) && (grid[1, 1] == 0) && (grid[2, 0] == 0))
            {
                indicator = 0;
            }
            else if ((grid[0, 2] == 1) && (grid[1, 1] == 1) && (grid[2, 0] == 1))
            {
                return indicator = 1;
            }

            return indicator;
        }
    }

}

