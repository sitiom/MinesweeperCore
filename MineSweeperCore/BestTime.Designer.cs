namespace MinesweeperCore
{
	public partial class BestTime
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.beginnerLevel = new System.Windows.Forms.Label();
			this.BeginnerBestTime = new System.Windows.Forms.Label();
			this.beginnerPlayerName = new System.Windows.Forms.Label();
			this.intermediateLevel = new System.Windows.Forms.Label();
			this.IntermediateBestTime = new System.Windows.Forms.Label();
			this.intermediatePlayerName = new System.Windows.Forms.Label();
			this.expertLevel = new System.Windows.Forms.Label();
			this.ExpertBestTime = new System.Windows.Forms.Label();
			this.expertPlayerName = new System.Windows.Forms.Label();
			this.resetScoresButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// beginnerLevel
			// 
			this.beginnerLevel.AutoSize = true;
			this.beginnerLevel.Location = new System.Drawing.Point(3, 0);
			this.beginnerLevel.Name = "beginnerLevel";
			this.beginnerLevel.Size = new System.Drawing.Size(85, 25);
			this.beginnerLevel.TabIndex = 0;
			this.beginnerLevel.Text = "Beginner:";
			this.beginnerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BeginnerBestTime
			// 
			this.BeginnerBestTime.AutoSize = true;
			this.BeginnerBestTime.Location = new System.Drawing.Point(125, 0);
			this.BeginnerBestTime.Name = "BeginnerBestTime";
			this.BeginnerBestTime.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
			this.BeginnerBestTime.Size = new System.Drawing.Size(142, 25);
			this.BeginnerBestTime.TabIndex = 1;
			this.BeginnerBestTime.Text = "999 seconds";
			this.BeginnerBestTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// beginnerPlayerName
			// 
			this.beginnerPlayerName.AutoSize = true;
			this.beginnerPlayerName.Location = new System.Drawing.Point(273, 0);
			this.beginnerPlayerName.Name = "beginnerPlayerName";
			this.beginnerPlayerName.Size = new System.Drawing.Size(109, 25);
			this.beginnerPlayerName.TabIndex = 2;
			this.beginnerPlayerName.Text = "Anonymous";
			this.beginnerPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// intermediateLevel
			// 
			this.intermediateLevel.AutoSize = true;
			this.intermediateLevel.Location = new System.Drawing.Point(3, 25);
			this.intermediateLevel.Name = "intermediateLevel";
			this.intermediateLevel.Size = new System.Drawing.Size(116, 25);
			this.intermediateLevel.TabIndex = 3;
			this.intermediateLevel.Text = "Intermediate:";
			this.intermediateLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// IntermediateBestTime
			// 
			this.IntermediateBestTime.AutoSize = true;
			this.IntermediateBestTime.Location = new System.Drawing.Point(125, 25);
			this.IntermediateBestTime.Name = "IntermediateBestTime";
			this.IntermediateBestTime.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
			this.IntermediateBestTime.Size = new System.Drawing.Size(142, 25);
			this.IntermediateBestTime.TabIndex = 4;
			this.IntermediateBestTime.Text = "999 seconds";
			this.IntermediateBestTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// intermediatePlayerName
			// 
			this.intermediatePlayerName.AutoSize = true;
			this.intermediatePlayerName.Location = new System.Drawing.Point(273, 25);
			this.intermediatePlayerName.Name = "intermediatePlayerName";
			this.intermediatePlayerName.Size = new System.Drawing.Size(109, 25);
			this.intermediatePlayerName.TabIndex = 5;
			this.intermediatePlayerName.Text = "Anonymous";
			this.intermediatePlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// expertLevel
			// 
			this.expertLevel.AutoSize = true;
			this.expertLevel.Location = new System.Drawing.Point(3, 50);
			this.expertLevel.Name = "expertLevel";
			this.expertLevel.Size = new System.Drawing.Size(65, 25);
			this.expertLevel.TabIndex = 6;
			this.expertLevel.Text = "Expert:";
			this.expertLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ExpertBestTime
			// 
			this.ExpertBestTime.AutoSize = true;
			this.ExpertBestTime.Location = new System.Drawing.Point(125, 50);
			this.ExpertBestTime.Name = "ExpertBestTime";
			this.ExpertBestTime.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
			this.ExpertBestTime.Size = new System.Drawing.Size(142, 25);
			this.ExpertBestTime.TabIndex = 7;
			this.ExpertBestTime.Text = "999 seconds";
			this.ExpertBestTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// expertPlayerName
			// 
			this.expertPlayerName.AutoSize = true;
			this.expertPlayerName.Location = new System.Drawing.Point(273, 50);
			this.expertPlayerName.Name = "expertPlayerName";
			this.expertPlayerName.Size = new System.Drawing.Size(109, 25);
			this.expertPlayerName.TabIndex = 8;
			this.expertPlayerName.Text = "Anonymous";
			this.expertPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// resetScoresButton
			// 
			this.resetScoresButton.Location = new System.Drawing.Point(69, 142);
			this.resetScoresButton.Name = "resetScoresButton";
			this.resetScoresButton.Size = new System.Drawing.Size(135, 43);
			this.resetScoresButton.TabIndex = 9;
			this.resetScoresButton.Text = "Reset Scores";
			this.resetScoresButton.Click += new System.EventHandler(this.Reset_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(272, 142);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(91, 43);
			this.okButton.TabIndex = 10;
			this.okButton.Text = "OK";
			this.okButton.Click += new System.EventHandler(this.Close_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.beginnerLevel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.intermediateLevel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.expertLevel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.expertPlayerName, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.intermediatePlayerName, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.IntermediateBestTime, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.ExpertBestTime, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.beginnerPlayerName, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.BeginnerBestTime, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 32);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 75);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// BestTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(432, 203);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.resetScoresButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BestTime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Fastest Mine Sweepers";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.Label BeginnerBestTime;
		private System.Windows.Forms.Label beginnerLevel;
		private System.Windows.Forms.Label beginnerPlayerName;
		private System.Windows.Forms.Label ExpertBestTime;
		private System.Windows.Forms.Label expertLevel;
		private System.Windows.Forms.Label expertPlayerName;
		private System.Windows.Forms.Label IntermediateBestTime;
		private System.Windows.Forms.Label intermediateLevel;
		private System.Windows.Forms.Label intermediatePlayerName;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button resetScoresButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

