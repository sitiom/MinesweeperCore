namespace MinesweeperCore
{
	public partial class AboutUs
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
			this.content = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// content
			// 
			this.content.AutoSize = true;
			this.content.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.content.Location = new System.Drawing.Point(115, 15);
			this.content.Name = "content";
			this.content.Size = new System.Drawing.Size(279, 41);
			this.content.TabIndex = 0;
			this.content.Text = "Minesweeper Core";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(34, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(530, 84);
			this.label1.TabIndex = 1;
			this.label1.Text = " It is a program like Windows Minesweeper of Microsoft\r\nThis is the first program" +
    " of mine in C# and Visual Studio.Net\r\nVersion 2.0.0 (Ported to .NET Core)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(124, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(350, 84);
			this.label2.TabIndex = 2;
			this.label2.Text = "Copyright By Dau Quoc Chung IT6 K48\r\nHanoi University of Technology\r\nEmail:quocch" +
    "ungvnn@yahoo.com";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AboutUs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(598, 358);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.content);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AboutUs";
			this.Text = "About Minesweeper";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.Label content;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

