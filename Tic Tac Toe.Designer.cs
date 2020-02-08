namespace Tic_Tac_Toe
{
	partial class TicTacToe
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
			this.msStrip = new System.Windows.Forms.MenuStrip();
			this.msOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.msNewGame = new System.Windows.Forms.ToolStripMenuItem();
			this.msExit = new System.Windows.Forms.ToolStripMenuItem();
			this.picBox7 = new System.Windows.Forms.PictureBox();
			this.picBox8 = new System.Windows.Forms.PictureBox();
			this.picBox9 = new System.Windows.Forms.PictureBox();
			this.picBox6 = new System.Windows.Forms.PictureBox();
			this.picBox5 = new System.Windows.Forms.PictureBox();
			this.picBox4 = new System.Windows.Forms.PictureBox();
			this.picBox2 = new System.Windows.Forms.PictureBox();
			this.picBox3 = new System.Windows.Forms.PictureBox();
			this.picBox1 = new System.Windows.Forms.PictureBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.msStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// msStrip
			// 
			this.msStrip.BackColor = System.Drawing.Color.Transparent;
			this.msStrip.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Texture_Tic_Tac_Toe;
			this.msStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOptions});
			this.msStrip.Location = new System.Drawing.Point(0, 0);
			this.msStrip.Name = "msStrip";
			this.msStrip.Size = new System.Drawing.Size(487, 24);
			this.msStrip.TabIndex = 31;
			// 
			// msOptions
			// 
			this.msOptions.BackColor = System.Drawing.Color.Transparent;
			this.msOptions.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Texture_Tic_Tac_Toe;
			this.msOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.msOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msNewGame,
            this.msExit});
			this.msOptions.ForeColor = System.Drawing.Color.White;
			this.msOptions.Image = global::Tic_Tac_Toe.Properties.Resources.options;
			this.msOptions.Name = "msOptions";
			this.msOptions.Size = new System.Drawing.Size(77, 20);
			this.msOptions.Text = "Options";
			// 
			// msNewGame
			// 
			this.msNewGame.BackColor = System.Drawing.Color.Transparent;
			this.msNewGame.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Texture_Tic_Tac_Toe;
			this.msNewGame.ForeColor = System.Drawing.Color.White;
			this.msNewGame.Name = "msNewGame";
			this.msNewGame.Size = new System.Drawing.Size(132, 22);
			this.msNewGame.Text = "New Game";
			this.msNewGame.Click += new System.EventHandler(this.msNewGame_Click);
			// 
			// msExit
			// 
			this.msExit.BackColor = System.Drawing.Color.Transparent;
			this.msExit.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Texture_Tic_Tac_Toe;
			this.msExit.ForeColor = System.Drawing.Color.White;
			this.msExit.Name = "msExit";
			this.msExit.Size = new System.Drawing.Size(132, 22);
			this.msExit.Text = "Exit";
			this.msExit.Click += new System.EventHandler(this.msExit_Click);
			// 
			// picBox7
			// 
			this.picBox7.BackColor = System.Drawing.Color.Transparent;
			this.picBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox7.BackgroundImage")));
			this.picBox7.Location = new System.Drawing.Point(80, 86);
			this.picBox7.Name = "picBox7";
			this.picBox7.Size = new System.Drawing.Size(100, 100);
			this.picBox7.TabIndex = 32;
			this.picBox7.TabStop = false;
			this.picBox7.Tag = "(2,0)";
			this.picBox7.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picBox8
			// 
			this.picBox8.BackColor = System.Drawing.Color.Transparent;
			this.picBox8.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.button;
			this.picBox8.Image = global::Tic_Tac_Toe.Properties.Resources.button;
			this.picBox8.Location = new System.Drawing.Point(186, 86);
			this.picBox8.Name = "picBox8";
			this.picBox8.Size = new System.Drawing.Size(100, 100);
			this.picBox8.TabIndex = 33;
			this.picBox8.TabStop = false;
			this.picBox8.Tag = "(2,1)";
			this.picBox8.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picBox9
			// 
			this.picBox9.BackColor = System.Drawing.Color.Transparent;
			this.picBox9.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.button;
			this.picBox9.Image = global::Tic_Tac_Toe.Properties.Resources.button;
			this.picBox9.Location = new System.Drawing.Point(292, 86);
			this.picBox9.Name = "picBox9";
			this.picBox9.Size = new System.Drawing.Size(100, 100);
			this.picBox9.TabIndex = 34;
			this.picBox9.TabStop = false;
			this.picBox9.Tag = "(2,2)";
			this.picBox9.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picBox6
			// 
			this.picBox6.BackColor = System.Drawing.Color.Transparent;
			this.picBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox6.BackgroundImage")));
			this.picBox6.Location = new System.Drawing.Point(292, 192);
			this.picBox6.Name = "picBox6";
			this.picBox6.Size = new System.Drawing.Size(100, 100);
			this.picBox6.TabIndex = 35;
			this.picBox6.TabStop = false;
			this.picBox6.Tag = "(1,2)";
			this.picBox6.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picBox5
			// 
			this.picBox5.BackColor = System.Drawing.Color.Transparent;
			this.picBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox5.BackgroundImage")));
			this.picBox5.Location = new System.Drawing.Point(186, 192);
			this.picBox5.Name = "picBox5";
			this.picBox5.Size = new System.Drawing.Size(100, 100);
			this.picBox5.TabIndex = 36;
			this.picBox5.TabStop = false;
			this.picBox5.Tag = "(1,1)";
			this.picBox5.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picBox4
			// 
			this.picBox4.BackColor = System.Drawing.Color.Transparent;
			this.picBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox4.BackgroundImage")));
			this.picBox4.Location = new System.Drawing.Point(80, 192);
			this.picBox4.Name = "picBox4";
			this.picBox4.Size = new System.Drawing.Size(100, 100);
			this.picBox4.TabIndex = 37;
			this.picBox4.TabStop = false;
			this.picBox4.Tag = "(1,0)";
			this.picBox4.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picBox2
			// 
			this.picBox2.BackColor = System.Drawing.Color.Transparent;
			this.picBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox2.BackgroundImage")));
			this.picBox2.Location = new System.Drawing.Point(186, 298);
			this.picBox2.Name = "picBox2";
			this.picBox2.Size = new System.Drawing.Size(100, 100);
			this.picBox2.TabIndex = 38;
			this.picBox2.TabStop = false;
			this.picBox2.Tag = "(0,1)";
			this.picBox2.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picBox3
			// 
			this.picBox3.BackColor = System.Drawing.Color.Transparent;
			this.picBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox3.BackgroundImage")));
			this.picBox3.Location = new System.Drawing.Point(292, 298);
			this.picBox3.Name = "picBox3";
			this.picBox3.Size = new System.Drawing.Size(100, 100);
			this.picBox3.TabIndex = 39;
			this.picBox3.TabStop = false;
			this.picBox3.Tag = "(0,2)";
			this.picBox3.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picBox1
			// 
			this.picBox1.BackColor = System.Drawing.Color.Transparent;
			this.picBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox1.BackgroundImage")));
			this.picBox1.Location = new System.Drawing.Point(80, 298);
			this.picBox1.Name = "picBox1";
			this.picBox1.Size = new System.Drawing.Size(100, 100);
			this.picBox1.TabIndex = 40;
			this.picBox1.TabStop = false;
			this.picBox1.Tag = "(0,0)";
			this.picBox1.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// picLogo
			// 
			this.picLogo.BackColor = System.Drawing.Color.Transparent;
			this.picLogo.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Bull_Maque_Logo_3D_with_text;
			this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picLogo.Location = new System.Drawing.Point(162, -15);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(153, 95);
			this.picLogo.TabIndex = 41;
			this.picLogo.TabStop = false;
			// 
			// TicTacToe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Texture_Tic_Tac_Toe;
			this.ClientSize = new System.Drawing.Size(487, 444);
			this.Controls.Add(this.picLogo);
			this.Controls.Add(this.picBox1);
			this.Controls.Add(this.picBox3);
			this.Controls.Add(this.picBox2);
			this.Controls.Add(this.picBox4);
			this.Controls.Add(this.picBox5);
			this.Controls.Add(this.picBox6);
			this.Controls.Add(this.picBox9);
			this.Controls.Add(this.picBox8);
			this.Controls.Add(this.picBox7);
			this.Controls.Add(this.msStrip);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TicTacToe";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe";
			this.msStrip.ResumeLayout(false);
			this.msStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip msStrip;
		private System.Windows.Forms.ToolStripMenuItem msOptions;
		private System.Windows.Forms.ToolStripMenuItem msNewGame;
		private System.Windows.Forms.ToolStripMenuItem msExit;
		private System.Windows.Forms.PictureBox picBox7;
		private System.Windows.Forms.PictureBox picBox8;
		private System.Windows.Forms.PictureBox picBox9;
		private System.Windows.Forms.PictureBox picBox6;
		private System.Windows.Forms.PictureBox picBox5;
		private System.Windows.Forms.PictureBox picBox4;
		private System.Windows.Forms.PictureBox picBox2;
		private System.Windows.Forms.PictureBox picBox3;
		private System.Windows.Forms.PictureBox picBox1;
		private System.Windows.Forms.PictureBox picLogo;
	}
}

