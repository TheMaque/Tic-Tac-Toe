﻿using System;
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
		bool turn = true;


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

		static void ExtractRowAndColumn()
		{

		}

		static void UpdateThe2DArray()
		{

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
			turn = !turn;
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
	private void msNewGame_Click(object sender, EventArgs e)
	{
		// Enable first turn
		turn = true;

		
		MassSetPictureBoxEnable(true);

		MassSetPictureBoxImage();


	}
}
	}

