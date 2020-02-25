using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
	/* Name: Reggie Telemaque
	 * Date: 01/19/2020
	 * 
	 * Program: Tic Tac Toe
	 * 
	 * Purpose: A tic tac toe program that takes user input and changes pictureboxes corresponding to the users choice.
	 */

	public partial class TicTacToe : Form
	{
		// Global Variables
		int turn_count;
		int Turns = 0;
		int[,] TicTacToeBoard = new int[3, 3];


		public TicTacToe()
		{
			InitializeComponent();
		}

		private void msExit_Click(object sender, EventArgs e)
		{
			// Close the program on click.
			this.Close();
		}

		// Proceduere to set image based on turn count
		private Bitmap SetImage()
		{
			return (turn_count == 0) ? Properties.Resources.X : Properties.Resources.O;
		}

		// Add values to each column of array of checking a winner
		private int PictureBoxColumnSum(int columnEquals)
		{
			int sum = 0;

			for (int column = 0; column < TicTacToeBoard.GetLength(1); column++)
			{
				sum += TicTacToeBoard[column,columnEquals];
			}
			return sum;
		}

		// Add values to each row of array of checking a winner
		private int PictureBoxRowSum(int rowEquals)
		{
			int sum = 0;

			for (int col = 0; col < TicTacToeBoard.GetLength(1); col++)
			{
				sum += TicTacToeBoard[rowEquals, col];
			}
			return sum;

		}

		// Send a messagebox to state a winner
		private string TellTheWinner()
		{
			return (turn_count == 0) ? "X has won!" : " O has won!";
		}

		private void ButtonClicked(object sender, EventArgs e)
		{
			// Cast object to picturebox
			PictureBox button = (PictureBox)sender;


			// Set string to find tag in picture box
			int row = int.Parse(button.Tag.ToString().Substring(1, 1));
			int column = int.Parse(button.Tag.ToString().Substring(3, 1));

			// Declare if to cooresponding turn to change between O and X/
			button.Image = SetImage();

			TicTacToeBoard[row, column] = SetValue();

			// Disable button after being clicked.
			button.Enabled = false;


			// Check for if there was a draw
			if (CheckForWinner(row, column))
			{
				MessageBox.Show(TellTheWinner());
				MassSetPictureBoxEnable(false);
			}
			else if (Turns == 8)
			{
				MessageBox.Show("There has been a draw!", "Oops.");
			}
			else
			{
				turn_count = SetCountForPlayer();
				Turns++;
			}

			//turn = !turn;
		}
		
		// Reset turns
		private void TurnCountReset()
		{
			turn_count = 0;
		}

		// Procedure for enabling or disabing a picture box to be clicked or whe  game is reset
		private void MassSetPictureBoxEnable(bool howToSet)
		{
			foreach (Control controlUsed in Controls)
			{
				if (controlUsed is PictureBox) controlUsed.Enabled = howToSet;
			}
		}

		// Procedure for clearing of picture boxes when game is rest
		private void MassSetPictureBoxImage()
		{
			foreach (Control controlUsed in Controls)
			{
				if (controlUsed is PictureBox)
				{
					((PictureBox)controlUsed).Image = null;
				}
			}

		}

		// Set a count for each player
		private int SetCountForPlayer()
		{
			return (turn_count == 0) ? 1 : 0;
		}

		// set number value to each turn
		private int SetValue()
		{
			return (turn_count == 0) ? 10 : 100;
		}

		// Find winner depending on the sum of the users selection
		private bool CheckForWinner(int row, int column)
		{
			if (PictureBoxRowSum(row) == 30 || PictureBoxRowSum(row) == 300)
			{
				return true;
			}
			else if (PictureBoxColumnSum(column) == 30 || PictureBoxColumnSum(column) == 300)
			{
				return true;
			}
			else if (TicTacToeBoard[0, 0] + TicTacToeBoard[1, 1] + TicTacToeBoard[2, 2] == 30 || TicTacToeBoard[0, 0] + TicTacToeBoard[1, 1] + TicTacToeBoard[2, 2] == 300)
			{
				return true;
			}
			else if (TicTacToeBoard[0, 2] + TicTacToeBoard[1, 1] + TicTacToeBoard[2, 0] == 30 || TicTacToeBoard[0, 2] + TicTacToeBoard[1, 1] + TicTacToeBoard[2, 0] == 300)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		//Reset the array when game is reset
		private void ResetArray()
		{
			for (int row = 0; row < TicTacToeBoard.GetLength(0); row++)
			{
				for (int column = 0; column < TicTacToeBoard.GetLength(1); column++)
				{
					TicTacToeBoard[row, column] = 0;
				}
			}
		}

		private void msNewGame_Click(object sender, EventArgs e)
		{
			
			// Calling back to procedures when game are reset
			MassSetPictureBoxEnable(true);
			MassSetPictureBoxImage();
			TurnCountReset();
			ResetArray();

			// Reset turn to 0
			Turns = 0;

		}
	}
}

