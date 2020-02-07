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
		// WHen true = x turn; false = y turn

		int turn_count;
		int Turns = 0;
		int[,] TicTacToeBoard = new int[1, 1];

		


		public TicTacToe()
		{
			InitializeComponent();
		}

		private void msExit_Click(object sender, EventArgs e)
		{
			// Close the program on click.
			this.Close();
		}

		private Bitmap SetImage()
		{
			return (turn) ? Properties.Resources.X : Properties.Resources.O;
		}

		
		private int PictureBoxColumnSum(int columnEquals)
		{
			int sum = 0;

			for (int column = 0; column < TicTacToeBoard.GetLength(1); row++)
			{
				sum += TicTacToeBoard[columnEquals, column];
			}
		}

		private int PictureBoxRowSum(int rowEquals)
		{
			int sum = 0;

			for (int column = 0; column < TicTacToeBoard.GetLength(1); column++)
			{
				sum += TicTacToeBoard[rowEquals, column];
			}

		}



		private void ButtonClicked(object sender, EventArgs e)
		{
			// Cast object to picturebox
			PictureBox button = (PictureBox)sender;

			// Declare if to cooresponding turn to change between O and X/
			if (turn)
				button.Image = SetImage();
			else
				button.Image = SetImage();

			// Disable button after being clicked.
			button.Enabled = false;


			int rowTag = int.Parse(button.Tag.ToString().Substring(1, 1));
			int columnTag = int.Parse(button.Tag.ToString().Substring(3, 1));

			// Flip turn
			
		}

		private void MassSetPictureBoxEnable(bool howToSet)
		{
			foreach (Control controlUsed in Controls)
			{
				if (controlUsed is PictureBox) controlUsed.Enabled = howToSet;
			}
		}

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

		private int SetCountForPlayer()
		{
			return (turn_count == 0) ? 1 : 0;
		}

		private int SetValue()
		{
			return (turn_count == 0) ? 10 : 100;
		}

		private bool CheckForWinner (int row, int column)
		{
			if (PictureBoxRowSum(row) == 30 || PictureBoxRowSum(row) == 300)
			{
				return true;
			}
			else if (PictureBoxColumnSum(column) == 30 || PictureBoxColumnSum(column) == 300)
			{
				return true;
			}
			else if (TicTacToeBoard[0, 0] + TicTacToeBoard[1, 2] + TicTacToeBoard[2, 2] == 30 || TicTacToeBoard[0, 0] + TicTacToeBoard[1, 2] + TicTacToeBoard[2, 2] == 300)
			{
				return true;
			}
			else if (TicTacToeBoard[0, 2] + TicTacToeBoard[1, 1] + TicTacToeBoard[2, 0] == 30 || TicTacToeBoard[0, 1] + TicTacToeBoard[1, 1] + TicTacToeBoard[2, 0] == 300)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void msNewGame_Click(object sender, EventArgs e)
		{
			// Enable first turn
			turn = true;


			MassSetPictureBoxEnable(true);

			MassSetPictureBoxImage();



		}
	}
}

