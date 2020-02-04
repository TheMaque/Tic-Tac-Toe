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
		bool turn = true;

		// Count user input to declare winner
		int turn_count = 0;

		public TicTacToe()
		{
			InitializeComponent();
		}

		private void msExit_Click(object sender, EventArgs e)
		{
			// Close the program on click.
			this.Close();
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
				button.Image = Properties.Resources.X;
			else
				button.Image = Properties.Resources.O;

			// Disable button after being clicked.
			button.Enabled = false;
			
			
			// Flip turn
			turn = !turn;
		}

		private void msNewGame_Click(object sender, EventArgs e)
		{
			// Enable first turn
			turn = true;

			// Reset count
			turn_count = 0;

			// Clearing and reseting each picture box. 
			picBox1.Image = null;
			picBox2.Image = null;
			picBox3.Image = null;
			picBox4.Image = null;
			picBox5.Image = null;
			picBox6.Image = null;
			picBox7.Image = null;
			picBox8.Image = null;
			picBox9.Image = null;

			// Enabling the picture boxes to be clicked.
			picBox1.Enabled = true;
			picBox2.Enabled = true;
			picBox3.Enabled = true;
			picBox4.Enabled = true;
			picBox5.Enabled = true;
			picBox6.Enabled = true;
			picBox7.Enabled = true;
			picBox8.Enabled = true;
			picBox9.Enabled = true;
			
		}
	}
	}

