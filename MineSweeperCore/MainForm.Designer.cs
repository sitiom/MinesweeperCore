using System;
using System.Windows.Forms;

namespace MinesweeperCore
{
	public partial class MainForm
	{
		private System.ComponentModel.IContainer components;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.leftTopConner = new System.Windows.Forms.PictureBox();
			this.topBg = new System.Windows.Forms.PictureBox();
			this.rightTopConner = new System.Windows.Forms.PictureBox();
			this.leftBg1 = new System.Windows.Forms.PictureBox();
			this.bg1 = new System.Windows.Forms.PictureBox();
			this.rightBg1 = new System.Windows.Forms.PictureBox();
			this.middleLeftConner = new System.Windows.Forms.PictureBox();
			this.middleBg = new System.Windows.Forms.PictureBox();
			this.middleRightConner = new System.Windows.Forms.PictureBox();
			this.leftBg2 = new System.Windows.Forms.PictureBox();
			this.rightBg2 = new System.Windows.Forms.PictureBox();
			this.leftBottomConner = new System.Windows.Forms.PictureBox();
			this.bottomBg = new System.Windows.Forms.PictureBox();
			this.rightBottomConner = new System.Windows.Forms.PictureBox();
			this.face = new System.Windows.Forms.PictureBox();
			this.remainMine = new System.Windows.Forms.PictureBox();
			this.clock = new System.Windows.Forms.PictureBox();
			this.tilesPictureBox = new System.Windows.Forms.PictureBox();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.gameMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.beginnerMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.intermediateMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.expertMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.customMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.markMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.bestTimeMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.contentMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize) (this.leftTopConner)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.topBg)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.rightTopConner)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.leftBg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.bg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.rightBg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.middleLeftConner)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.middleBg)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.middleRightConner)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.leftBg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.rightBg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.leftBottomConner)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.bottomBg)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.rightBottomConner)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.face)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.remainMine)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.clock)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.tilesPictureBox)).BeginInit();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftTopConner
			// 
			this.leftTopConner.Image = global::MinesweeperCore.Properties.Resources.left_top_conner;
			this.leftTopConner.Location = new System.Drawing.Point(0, 0);
			this.leftTopConner.Name = "leftTopConner";
			this.leftTopConner.Size = new System.Drawing.Size(11, 12);
			this.topBg.SizeMode = PictureBoxSizeMode.Zoom;
			this.leftTopConner.TabIndex = 0;
			this.leftTopConner.TabStop = false;
			// 
			// topBg
			// 
			this.topBg.BackgroundImage = global::MinesweeperCore.Properties.Resources.top_bg;
			this.topBg.Location = new System.Drawing.Point(11, 0);
			this.topBg.Name = "topBg";
			this.topBg.Size = new System.Drawing.Size(154, 12);
			this.topBg.SizeMode = PictureBoxSizeMode.Zoom;
			this.topBg.TabIndex = 1;
			this.topBg.TabStop = false;
			// 
			// rightTopConner
			// 
			this.rightTopConner.Image = global::MinesweeperCore.Properties.Resources.right_top_conner;
			this.rightTopConner.Location = new System.Drawing.Point(165, 0);
			this.rightTopConner.Name = "rightTopConner";
			this.rightTopConner.Size = new System.Drawing.Size(7, 12);
			this.rightTopConner.SizeMode = PictureBoxSizeMode.Zoom;
			this.rightTopConner.TabIndex = 2;
			this.rightTopConner.TabStop = false;
			// 
			// leftBg1
			// 
			this.leftBg1.BackgroundImage = global::MinesweeperCore.Properties.Resources.left_bg;
			this.leftBg1.Location = new System.Drawing.Point(0, 12);
			this.leftBg1.Name = "leftBg1";
			this.leftBg1.Size = new System.Drawing.Size(11, 36);
			this.leftBg1.SizeMode = PictureBoxSizeMode.Zoom;
			this.leftBg1.TabIndex = 3;
			this.leftBg1.TabStop = false;
			// 
			// bg1
			// 
			this.bg1.BackgroundImage = global::MinesweeperCore.Properties.Resources.bg;
			this.bg1.Location = new System.Drawing.Point(11, 12);
			this.bg1.Name = "bg1";
			this.bg1.Size = new System.Drawing.Size(154, 36);
			this.bg1.SizeMode = PictureBoxSizeMode.Zoom;
			this.bg1.TabIndex = 4;
			this.bg1.TabStop = false;
			// 
			// rightBg1
			// 
			this.rightBg1.BackgroundImage = global::MinesweeperCore.Properties.Resources.right_bg;
			this.rightBg1.Location = new System.Drawing.Point(165, 12);
			this.rightBg1.Name = "rightBg1";
			this.rightBg1.Size = new System.Drawing.Size(7, 36);
			this.rightBg1.SizeMode = PictureBoxSizeMode.Zoom;
			this.rightBg1.TabIndex = 5;
			this.rightBg1.TabStop = false;
			// 
			// middleLeftConner
			// 
			this.middleLeftConner.Image = global::MinesweeperCore.Properties.Resources.middle_left_conner;
			this.middleLeftConner.Location = new System.Drawing.Point(0, 48);
			this.middleLeftConner.Name = "middleLeftConner";
			this.middleLeftConner.Size = new System.Drawing.Size(11, 11);
			this.middleLeftConner.SizeMode = PictureBoxSizeMode.Zoom;
			this.middleLeftConner.TabIndex = 6;
			this.middleLeftConner.TabStop = false;
			// 
			// middleBg
			// 
			this.middleBg.BackgroundImage = global::MinesweeperCore.Properties.Resources.middle_bg;
			this.middleBg.Location = new System.Drawing.Point(11, 48);
			this.middleBg.Name = "middleBg";
			this.middleBg.Size = new System.Drawing.Size(154, 11);
			this.middleBg.SizeMode = PictureBoxSizeMode.Zoom;
			this.middleBg.TabIndex = 7;
			this.middleBg.TabStop = false;
			// 
			// middleRightConner
			// 
			this.middleRightConner.Image = global::MinesweeperCore.Properties.Resources.middle_right_conner;
			this.middleRightConner.Location = new System.Drawing.Point(165, 48);
			this.middleRightConner.Name = "middleRightConner";
			this.middleRightConner.Size = new System.Drawing.Size(7, 11);
			this.middleRightConner.SizeMode = PictureBoxSizeMode.Zoom;
			this.middleRightConner.TabIndex = 8;
			this.middleRightConner.TabStop = false;
			// 
			// leftBg2
			// 
			this.leftBg2.BackgroundImage = global::MinesweeperCore.Properties.Resources.left_bg;
			this.leftBg2.Location = new System.Drawing.Point(0, 59);
			this.leftBg2.Name = "leftBg2";
			this.leftBg2.Size = new System.Drawing.Size(11, 150);
			this.leftBg2.SizeMode = PictureBoxSizeMode.Zoom;
			this.leftBg2.TabIndex = 9;
			this.leftBg2.TabStop = false;
			// 
			// rightBg2
			// 
			this.rightBg2.BackgroundImage = global::MinesweeperCore.Properties.Resources.right_bg;
			this.rightBg2.Location = new System.Drawing.Point(165, 59);
			this.rightBg2.Name = "rightBg2";
			this.rightBg2.Size = new System.Drawing.Size(7, 150);
			this.rightBg2.SizeMode = PictureBoxSizeMode.Zoom;
			this.rightBg2.TabIndex = 10;
			this.rightBg2.TabStop = false;
			// 
			// leftBottomConner
			// 
			this.leftBottomConner.Image = global::MinesweeperCore.Properties.Resources.left_bottom_conner;
			this.leftBottomConner.Location = new System.Drawing.Point(0, 209);
			this.leftBottomConner.Name = "leftBottomConner";
			this.leftBottomConner.Size = new System.Drawing.Size(12, 8);
			this.leftBottomConner.SizeMode = PictureBoxSizeMode.Zoom;
			this.leftBottomConner.TabIndex = 11;
			this.leftBottomConner.TabStop = false;
			// 
			// bottomBg
			// 
			this.bottomBg.BackgroundImage = global::MinesweeperCore.Properties.Resources.bottom_bg;
			this.bottomBg.Location = new System.Drawing.Point(12, 209);
			this.bottomBg.Name = "bottomBg";
			this.bottomBg.Size = new System.Drawing.Size(153, 8);
			this.bottomBg.SizeMode = PictureBoxSizeMode.Zoom;
			this.bottomBg.TabIndex = 12;
			this.bottomBg.TabStop = false;
			// 
			// rightBottomConner
			// 
			this.rightBottomConner.Image = global::MinesweeperCore.Properties.Resources.right_bottom_conner;
			this.rightBottomConner.Location = new System.Drawing.Point(165, 209);
			this.rightBottomConner.Name = "rightBottomConner";
			this.rightBottomConner.Size = new System.Drawing.Size(7, 8);
			this.rightBottomConner.SizeMode = PictureBoxSizeMode.Zoom;
			this.rightBottomConner.TabIndex = 13;
			this.rightBottomConner.TabStop = false;
			// 
			// face
			// 
			this.face.Image = global::MinesweeperCore.Properties.Resources.nomal;
			this.face.Location = new System.Drawing.Point(76, 18);
			this.face.Name = "face";
			this.face.Size = new System.Drawing.Size(25, 24);
			this.face.SizeMode = PictureBoxSizeMode.Zoom;
			this.face.TabIndex = 14;
			this.face.TabStop = false;
			this.face.Click += new System.EventHandler(this.newMenu_Click);
			this.face.MouseUp += new System.Windows.Forms.MouseEventHandler(this.face_MouseUp);
			this.face.MouseDown += new System.Windows.Forms.MouseEventHandler(this.face_MouseDown);
			// 
			// remainMine
			// 
			this.remainMine.BackgroundImage = global::MinesweeperCore.Properties.Resources.number0;
			this.remainMine.Location = new System.Drawing.Point(18, 18);
			this.remainMine.Name = "remainMine";
			this.remainMine.Size = new System.Drawing.Size(41, 24);
			this.remainMine.SizeMode = PictureBoxSizeMode.Zoom;
			this.remainMine.TabIndex = 15;
			this.remainMine.TabStop = false;
			// 
			// clock
			// 
			this.clock.BackgroundImage = global::MinesweeperCore.Properties.Resources.number0;
			this.clock.Location = new System.Drawing.Point(119, 18);
			this.clock.Name = "clock";
			this.clock.Size = new System.Drawing.Size(41, 24);
			this.clock.SizeMode = PictureBoxSizeMode.Zoom;
			this.clock.TabIndex = 16;
			this.clock.TabStop = false;
			// 
			// tilesPictureBox
			// 
			this.tilesPictureBox.Location = new System.Drawing.Point(11, 59);
			this.tilesPictureBox.Name = "tilesPictureBox";
			this.tilesPictureBox.Size = new System.Drawing.Size(154, 150);
			this.tilesPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			this.tilesPictureBox.TabIndex = 17;
			this.tilesPictureBox.TabStop = false;
			this.tilesPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mineForm_MouseUp);
			this.tilesPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mineForm_MouseMove);
			this.tilesPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mineForm_MouseDown);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Top;
			this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.gameMenu,
				this.helpMenu
			});
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.mainMenuStrip.Size = new System.Drawing.Size(972, 33);
			this.mainMenuStrip.TabIndex = 18;
			// 
			// gameMenu
			// 
			this.gameMenu.DropDownItems.Add(this.newMenu);
			this.gameMenu.DropDownItems.Add(new ToolStripSeparator());
			this.gameMenu.DropDownItems.Add(this.beginnerMenu);
			this.gameMenu.DropDownItems.Add(this.intermediateMenu);
			this.gameMenu.DropDownItems.Add(this.expertMenu);
			this.gameMenu.DropDownItems.Add(this.customMenu);
			this.gameMenu.DropDownItems.Add(new ToolStripSeparator());
			this.gameMenu.DropDownItems.Add(this.markMenu);
			this.gameMenu.DropDownItems.Add(new ToolStripSeparator());
			this.gameMenu.DropDownItems.Add(this.bestTimeMenu);
			this.gameMenu.DropDownItems.Add(new ToolStripSeparator());
			this.gameMenu.DropDownItems.Add(this.exitMenu);
			this.gameMenu.MergeIndex = 0;
			this.gameMenu.Name = "gameMenu";
			this.gameMenu.Size = new System.Drawing.Size(74, 29);
			this.gameMenu.Text = "&Game";
			// 
			// newMenu
			// 
			this.newMenu.MergeIndex = 0;
			this.newMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.newMenu.Text = "&New";
			this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
			// 
			// beginnerMenu
			// 
			this.beginnerMenu.MergeIndex = 2;
			this.beginnerMenu.Name = "beginnerMenu";
			this.beginnerMenu.ShowShortcutKeys = false;
			this.beginnerMenu.Size = new System.Drawing.Size(214, 34);
			this.beginnerMenu.Text = "&Beginner";
			this.beginnerMenu.Click += new System.EventHandler(this.beginnerMenu_Click);
			// 
			// intermediateMenu
			// 
			this.intermediateMenu.MergeIndex = 3;
			this.intermediateMenu.Name = "intermediateMenu";
			this.intermediateMenu.Size = new System.Drawing.Size(214, 34);
			this.intermediateMenu.Text = "&Intermediate";
			this.intermediateMenu.Click += new System.EventHandler(this.intermediateMenu_Click);
			// 
			// expertMenu
			// 
			this.expertMenu.MergeIndex = 4;
			this.expertMenu.Name = "expertMenu";
			this.expertMenu.Size = new System.Drawing.Size(214, 34);
			this.expertMenu.Text = "&Expert";
			this.expertMenu.Click += new System.EventHandler(this.expertMenu_Click);
			// 
			// customMenu
			// 
			this.customMenu.MergeIndex = 5;
			this.customMenu.Name = "customMenu";
			this.customMenu.Size = new System.Drawing.Size(214, 34);
			this.customMenu.Text = "&Custom...";
			this.customMenu.Click += new System.EventHandler(this.customMenu_Click);
			// 
			// markMenu
			// 
			this.markMenu.MergeIndex = 7;
			this.markMenu.Name = "markMenu";
			this.markMenu.Size = new System.Drawing.Size(214, 34);
			this.markMenu.Text = "&Marks (?)";
			this.markMenu.Click += new System.EventHandler(this.markMenu_Click);
			// 
			// bestTimeMenu
			// 
			this.bestTimeMenu.MergeIndex = 9;
			this.bestTimeMenu.Name = "bestTimeMenu";
			this.bestTimeMenu.Size = new System.Drawing.Size(214, 34);
			this.bestTimeMenu.Text = "Best &Times...";
			this.bestTimeMenu.Click += new System.EventHandler(this.bestTimeMenu_Click);
			// 
			// exitMenu
			// 
			this.exitMenu.MergeIndex = 11;
			this.exitMenu.Name = "exitMenu";
			this.exitMenu.Size = new System.Drawing.Size(214, 34);
			this.exitMenu.Text = "E&xit";
			this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.Add(this.contentMenu);
			this.helpMenu.DropDownItems.Add(new ToolStripSeparator());
			this.helpMenu.DropDownItems.Add(this.aboutMenu);
			this.helpMenu.MergeIndex = 1;
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(65, 29);
			this.helpMenu.Text = "&Help";
			// 
			// contentMenu
			// 
			this.contentMenu.MergeIndex = 0;
			this.contentMenu.Name = "contentMenu";
			this.contentMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.contentMenu.Size = new System.Drawing.Size(327, 34);
			this.contentMenu.Text = "&Contents";
			this.contentMenu.Click += new System.EventHandler(this.contentMenu_Click);
			// 
			// aboutMenu
			// 
			this.aboutMenu.MergeIndex = 2;
			this.aboutMenu.Name = "aboutMenu";
			this.aboutMenu.Size = new System.Drawing.Size(327, 34);
			this.aboutMenu.Text = "&About Minesweeper Core...";
			this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Enabled = false;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F,15F);
			this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(189, 260);
			this.Controls.Add(this.tilesPictureBox);
			this.Controls.Add(this.clock);
			this.Controls.Add(this.remainMine);
			this.Controls.Add(this.face);
			this.Controls.Add(this.rightBottomConner);
			this.Controls.Add(this.bottomBg);
			this.Controls.Add(this.leftBottomConner);
			this.Controls.Add(this.rightBg2);
			this.Controls.Add(this.leftBg2);
			this.Controls.Add(this.middleRightConner);
			this.Controls.Add(this.middleBg);
			this.Controls.Add(this.middleLeftConner);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.rightBg1);
			this.Controls.Add(this.bg1);
			this.Controls.Add(this.leftBg1);
			this.Controls.Add(this.rightTopConner);
			this.Controls.Add(this.topBg);
			this.Controls.Add(this.leftTopConner);
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Minesweeper";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			((System.ComponentModel.ISupportInitialize) (this.leftTopConner)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.topBg)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.rightTopConner)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.leftBg1)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.bg1)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.rightBg1)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.middleLeftConner)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.middleBg)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.middleRightConner)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.leftBg2)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.rightBg2)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.leftBottomConner)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.bottomBg)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.rightBottomConner)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.face)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.remainMine)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.clock)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.tilesPictureBox)).EndInit();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
		private System.Windows.Forms.ToolStripMenuItem aboutMenu;
		private System.Windows.Forms.ToolStripMenuItem beginnerMenu;
		private System.Windows.Forms.ToolStripMenuItem bestTimeMenu;
		private System.Windows.Forms.PictureBox bg1;
		private System.Windows.Forms.PictureBox bottomBg;
		private System.Windows.Forms.PictureBox clock;
		private System.Windows.Forms.ToolStripMenuItem contentMenu;
		private System.Windows.Forms.ToolStripMenuItem customMenu;
		private System.Windows.Forms.ToolStripMenuItem exitMenu;
		private System.Windows.Forms.ToolStripMenuItem expertMenu;
		private System.Windows.Forms.PictureBox face;
		private System.Windows.Forms.ToolStripMenuItem gameMenu;
		private System.Windows.Forms.ToolStripMenuItem helpMenu;
		private System.Windows.Forms.ToolStripMenuItem intermediateMenu;
		private System.Windows.Forms.PictureBox leftBg1;
		private System.Windows.Forms.PictureBox leftBg2;
		private System.Windows.Forms.PictureBox leftBottomConner;
		private System.Windows.Forms.PictureBox leftTopConner;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem markMenu;
		private System.Windows.Forms.PictureBox middleLeftConner;
		private System.Windows.Forms.PictureBox middleRightConner;
		private System.Windows.Forms.PictureBox tilesPictureBox;
		private System.Windows.Forms.ToolStripMenuItem newMenu;
		private System.Windows.Forms.PictureBox middleBg;
		private System.Windows.Forms.PictureBox remainMine;
		private System.Windows.Forms.PictureBox rightBg1;
		private System.Windows.Forms.PictureBox rightBg2;
		private System.Windows.Forms.PictureBox rightBottomConner;
		private System.Windows.Forms.PictureBox rightTopConner;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.PictureBox topBg;
	}
}
