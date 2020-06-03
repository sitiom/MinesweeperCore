namespace MinesweeperCore
{
	public partial class Custom
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
			this.height = new System.Windows.Forms.Label();
			this.width = new System.Windows.Forms.Label();
			this.mines = new System.Windows.Forms.Label();
			this.columnsTextBox = new System.Windows.Forms.TextBox();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.totalMine = new System.Windows.Forms.TextBox();
			this.register = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// height
			// 
			this.height.AutoSize = true;
			this.height.Location = new System.Drawing.Point(3, 0);
			this.height.Name = "height";
			this.height.Size = new System.Drawing.Size(69, 25);
			this.height.TabIndex = 0;
			this.height.Text = "Height:";
			this.height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// width
			// 
			this.width.AutoSize = true;
			this.width.Location = new System.Drawing.Point(3, 37);
			this.width.Name = "width";
			this.width.Size = new System.Drawing.Size(64, 25);
			this.width.TabIndex = 1;
			this.width.Text = "Width:";
			this.width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mines
			// 
			this.mines.AutoSize = true;
			this.mines.Location = new System.Drawing.Point(3, 74);
			this.mines.Name = "mines";
			this.mines.Size = new System.Drawing.Size(63, 25);
			this.mines.TabIndex = 8;
			this.mines.Text = "Mines:";
			this.mines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// columnsTextBox
			// 
			this.columnsTextBox.Location = new System.Drawing.Point(78, 3);
			this.columnsTextBox.Name = "columnsTextBox";
			this.columnsTextBox.Size = new System.Drawing.Size(72, 31);
			this.columnsTextBox.TabIndex = 3;
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Location = new System.Drawing.Point(78, 40);
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(72, 31);
			this.rowsTextBox.TabIndex = 4;
			// 
			// totalMine
			// 
			this.totalMine.Location = new System.Drawing.Point(78, 77);
			this.totalMine.Name = "totalMine";
			this.totalMine.Size = new System.Drawing.Size(72, 31);
			this.totalMine.TabIndex = 5;
			// 
			// register
			// 
			this.register.Location = new System.Drawing.Point(212, 39);
			this.register.Name = "register";
			this.register.Size = new System.Drawing.Size(110, 43);
			this.register.TabIndex = 6;
			this.register.Text = "OK";
			this.register.Click += new System.EventHandler(this.Register_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(212, 101);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(110, 43);
			this.cancel.TabIndex = 7;
			this.cancel.Text = "Cancel";
			this.cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.height, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.width, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.mines, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.totalMine, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.columnsTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.rowsTextBox, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 36);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(153, 111);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// Custom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 177);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.register);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Custom";
			this.Text = "Custom Field";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.TextBox columnsTextBox;
		private System.Windows.Forms.Label height;
		private System.Windows.Forms.Label mines;
		private System.Windows.Forms.Button register;
		private System.Windows.Forms.TextBox totalMine;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.Label width;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

