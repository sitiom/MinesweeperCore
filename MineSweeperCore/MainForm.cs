using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MinesweeperCore.Properties;
using Newtonsoft.Json;

namespace MinesweeperCore
{
	public partial class MainForm : Form
	{
		private readonly Image[] _arrayMineStatus;
		private readonly Image[] _arrayNumber;

		private readonly AppSettings _appSettings;

		private bool _enableTime;
		private int _time;
		private bool _gameStart;

		private readonly ImgMouseEventHandler _ime;
		private readonly MathBase _mb;
		private readonly GraphicsItem _mf;

		public MainForm()
		{
			//apply settings
			_appSettings = File.Exists("settings.json") ? JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText("settings.json")) : new AppSettings();

			_arrayMineStatus = new Image[]
			{
				Resources.nomine0,
				Resources.nomine1,
				Resources.nomine2,
				Resources.nomine3,
				Resources.nomine4,
				Resources.nomine5,
				Resources.nomine6,
				Resources.nomine7,
				Resources.nomine8,
				Resources.nolabeled,
				Resources.minelabel,
				Resources.undefinemine,
				Resources.mineclicked,
				Resources.nominecheckmine,
				Resources.mineuncheck
			};
			_arrayNumber = new Image[]
			{
				Resources.number0,
				Resources.number1,
				Resources.number2,
				Resources.number3,
				Resources.number4,
				Resources.number5,
				Resources.number6,
				Resources.number7,
				Resources.number8,
				Resources.number9,
				Resources.sub
			};

			_time = 0;
			_gameStart = true;
			_enableTime = false;
			int itemHeight = 32;
			int itemWidth = 32;
			_ime = new ImgMouseEventHandler(_appSettings.LatestColumns, _appSettings.LatestRows, itemWidth + .6, itemHeight + .6);
			_ime.Event += ime_IEvent;
			_mb = new MathBase(_appSettings.LatestColumns, _appSettings.LatestRows, _appSettings.LatestMines)
			{
				Mark =
				_appSettings.Mark
			};
			_mf = new GraphicsItem(Resources.nolabeled, _appSettings.LatestColumns, _appSettings.LatestRows, itemWidth, itemHeight);
			InitializeComponent();
			#region Initialize Component
			int width = (int)Math.Ceiling((itemWidth * _appSettings.LatestColumns) / 1.88);
			int height = (int)Math.Ceiling((itemHeight * _appSettings.LatestRows) / 1.92);
			switch (_appSettings.LatestLevel)
			{
				case "Beginner":
					beginnerMenu.Checked = true;
					break;
				case "Intermediate":
					intermediateMenu.Checked = true;
					break;
				case "Expert":
					expertMenu.Checked = true;
					break;
				default:
					customMenu.Checked = true;
					break;
			}

			markMenu.Checked = _appSettings.Mark;
			topBg.Size = new Size(width, 12);
			rightTopConner.Location = new Point(width + 11, 0);
			bg1.Size = new Size(width, 36);
			rightBg1.Location = new Point(width + 11, 12);
			middleBg.Size = new Size(width, 11);
			middleRightConner.Location = new Point(width + 11, 48);
			leftBg2.Size = new Size(11, height);
			rightBg2.Location = new Point(width + 11, 59);
			rightBg2.Size = new Size(7, height);
			leftBottomConner.Location = new Point(0, height + 59);
			bottomBg.Location = new Point(12, height + 59);
			bottomBg.Size = new Size(width - 1, 8);
			rightBottomConner.Location = new Point(width + 11, height + 59);
			face.Location = new Point((int)Math.Floor(Convert.ToDecimal(width / 2 - 1)), 18);
			clock.Location = new Point(width - 35, 18);
			tilesPictureBox.Image = _mf.Img;
			tilesPictureBox.Size = new Size(width, height);
			ClientSize = new Size(width + 35, height + 110);
			remainMine.Image = DrawNumber(_appSettings.LatestMines);
			clock.Image = DrawNumber(0);
			
			//Give space for MenuStrip
			foreach (Control control in Controls)
			{
				control.Top += mainMenuStrip.Size.Height / 2;
			}

			//Properly scales the application
			Scale(new SizeF(1.5f, 1.5f));
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			#endregion
		}

		private void ime_IEvent(object sender, ImgEventArgs iea)
		{
			if (_gameStart)
				switch (iea.Event)
				{
					case EventList.LeftDown:
						_mb.LeftDown(iea.X, iea.Y);
						DrawGraphics();
						break;
					case EventList.BothDown:
						_mb.BothDown(iea.X, iea.Y);
						DrawGraphics();
						break;
					case EventList.LeftMove:
						_mb.LeftMove(iea.X, iea.Y);
						DrawGraphics();
						break;
					case EventList.BothMove:
						_mb.BothMove(iea.X, iea.Y);
						DrawGraphics();
						break;
					case EventList.LeftOut:
						_mb.LeftOut(iea.X, iea.Y);
						DrawGraphics();
						break;
					case EventList.BothOut:
						_mb.BothOut(iea.X, iea.Y);
						DrawGraphics();
						break;
					case EventList.LeftClick:
						if (_enableTime == false)
						{
							_enableTime = true;
							timer.Enabled = true;
							_mb.MakeMineMap(iea.Y * _appSettings.LatestColumns + iea.X);
							_mb.LeftClick(iea.X, iea.Y);
							DrawGraphics();
						}
						else
						{
							_mb.LeftClick(iea.X, iea.Y);
							if (_mb.IsFinished) _mb.Finished();
							if (_mb.IsWin) _mb.Win();
							DrawGraphics();
						}
						break;
					case EventList.BothClick:
						_mb.BothClick(iea.X, iea.Y);
						if (_mb.IsFinished) _mb.Finished();
						if (_mb.IsWin) _mb.Win();
						DrawGraphics();
						break;
					case EventList.RightClick:
						_mb.RightClick(iea.X, iea.Y);
						DrawGraphics();
						break;
				}
		}

		private void newMenu_Click(object sender, EventArgs e)
		{
			_gameStart = true;
			_enableTime = false;
			timer.Enabled = false;
			_mb.RestartAttributeGame();
			_mf.ResetBeginImage(Resources.nolabeled);
			tilesPictureBox.Image = _mf.Img;
			remainMine.Image = DrawNumber(_appSettings.LatestMines);
			clock.Image = DrawNumber(0);
			_time = 0;
			clock.Image = DrawNumber(_time);
			face.Image = Resources.nomal;
		}

		#region Change level
		private void beginnerMenu_Click(object sender, EventArgs e)
		{
			_appSettings.LatestLevel = "Beginner";
			_appSettings.LatestColumns = 9;
			_appSettings.LatestRows = 9;
			_appSettings.LatestMines = 10;
			beginnerMenu.Checked = true;
			Restart();
		}

		private void intermediateMenu_Click(object sender, EventArgs e)
		{
			_appSettings.LatestLevel = "Intermediate";
			_appSettings.LatestColumns = 16;
			_appSettings.LatestRows = 16;
			_appSettings.LatestMines = 40;
			intermediateMenu.Checked = true;
			Restart();
		}

		private void expertMenu_Click(object sender, EventArgs e)
		{
			_appSettings.LatestLevel = "Expert";
			_appSettings.LatestColumns = 30;
			_appSettings.LatestRows = 16;
			_appSettings.LatestMines = 99;
			expertMenu.Checked = true;
			Restart();
		}

		private void customMenu_Click(object sender, EventArgs e)
		{
			Custom customForm = new Custom();

			if (customForm.ShowDialog() == DialogResult.OK)
			{
				_appSettings.LatestLevel = "Custom";
				_appSettings.LatestColumns = customForm.Columns;
				_appSettings.LatestRows = customForm.Rows;
				_appSettings.LatestMines = customForm.TotalMines;
				Restart();
			}
		}
		#endregion

		private void markMenu_Click(object sender, EventArgs e)
		{
			_mb.Mark = !markMenu.Checked;
			markMenu.Checked = !markMenu.Checked;
			_appSettings.Mark = markMenu.Checked;
		}

		private void bestTimeMenu_Click(object sender, EventArgs e)
		{
			UseBestTime();
		}

		private void exitMenu_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void contentMenu_Click(object sender, EventArgs e)
		{
			ContentsHelp contentsForm = new ContentsHelp();
			contentsForm.ShowDialog();
		}

		private void aboutMenu_Click(object sender, EventArgs e)
		{
			AboutUs aboutUsForm = new AboutUs();
			aboutUsForm.ShowDialog();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			_time++;
			clock.Image = DrawNumber(_time);
		}

		private void face_MouseDown(object sender, MouseEventArgs e)
		{
			face.Image = Resources.down;
		}

		private void face_MouseUp(object sender, MouseEventArgs e)
		{
			if (_gameStart) face.Image = Resources.nomal;
		}

		private void mineForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (_gameStart) face.Image = Resources.clicking;
			_ime.MouseDown(sender, e);
			remainMine.Image = DrawNumber(_mb.RemainMine);
			tilesPictureBox.Image = _mf.Img;
		}

		private void mineForm_MouseMove(object sender, MouseEventArgs e)
		{
			_ime.MouseMove(sender, e);
			tilesPictureBox.Image = _mf.Img;
		}

		private void mineForm_MouseUp(object sender, MouseEventArgs e)
		{
			if (_gameStart) face.Image = Resources.nomal;
			_ime.MouseUp(sender, e);
			tilesPictureBox.Image = _mf.Img;
			if (_mb.IsWin || _mb.IsFinished) StopGame();
		}

		//<summary>
		//Saves game settings upon close (or restart)
		//</summary>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			File.WriteAllText("settings.json", JsonConvert.SerializeObject(_appSettings));
		}

		#region  Methods to enable game functionality

		private void DrawGraphics()
		{
			while (_mb.ThisQueue.Count != 0)
			{
				DrawQueue dq = (DrawQueue)_mb.ThisQueue.Dequeue();
				DrawItem(dq);
			}
		}

		private void DrawItem(DrawQueue dq)
		{
			//process change image of item
			_mf.DrawItem(_arrayMineStatus[dq.NImg], dq.X, dq.Y);
		}

		private Image DrawNumber(int n)
		{
			GraphicsItem numberForm = new GraphicsItem(Resources.number0, 3, 1, 26, 46);
			int t;
			if (n >= 0)
			{
				for (int i = 0; i < 3; i++)
				{
					t = n % 10;
					numberForm.DrawItem(_arrayNumber[t], 2 - i, 0);
					n = (int)Math.Floor((double)n / 10);
				}
			}
			else
			{
				numberForm.DrawItem(Resources.sub, 0, 0);
				n = Math.Abs(n);
				for (int i = 0; i < 2; i++)
				{
					t = n % 10;
					numberForm.DrawItem(_arrayNumber[t], 2 - i, 0);
					n = (int)Math.Floor((double)n / 10);
				}
			}
			return numberForm.Img;
		}

		private void StopGame()
		{
			_enableTime = false;
			timer.Enabled = false;
			_gameStart = false;
			if (_mb.IsWin)
			{
				remainMine.Image = DrawNumber(_mb.RemainMine);
				face.Image = Resources.win;
				switch (_appSettings.LatestLevel)
				{
					case "Beginner":
						if (_time < _appSettings.BeginnerBestTime)
							UseNewBestTime();
						break;

					case "Intermediate":
						if (_time < _appSettings.IntermediateBestTime)
							UseNewBestTime();
						break;

					case "Expert":
						if (_time < _appSettings.ExpertBestTime)
							UseNewBestTime();
						break;

					default:
						return;
				}

			}
			else
			{
				face.Image = Resources.miss;
			}
		}

		#endregion

		private void UseBestTime()
		{
			BestTime bestTime = new BestTime(_appSettings);
			bestTime.ShowDialog();
		}

		private void UseNewBestTime()
		{

			NewBestTime newBestTime = new NewBestTime(_appSettings.LatestLevel.ToLower());

			if (newBestTime.ShowDialog() == DialogResult.OK)
			{
				switch (_appSettings.LatestLevel)
				{
					case "Beginner":
						_appSettings.BeginnerPlayerName = newBestTime.LastPlayerName;
						_appSettings.BeginnerBestTime = _time;
						break;
					case "Intermediate":
						_appSettings.IntermediatePlayerName = newBestTime.LastPlayerName;
						_appSettings.IntermediateBestTime = _time;
						break;
					case "Expert":
						_appSettings.ExpertPlayerName = newBestTime.LastPlayerName;
						_appSettings.ExpertBestTime = _time;
						break;
					default:
						return;
				}
			}
			UseBestTime();
		}
		//<summary>
		//See https://github.com/dotnet/winforms/issues/2769
		//</summary>
		private void Restart()
		{
			string[] arguments = Environment.GetCommandLineArgs();
			Debug.Assert(arguments != null && arguments.Length > 0);
			StringBuilder sb = new StringBuilder((arguments.Length - 1) * 16);
			for (int argumentIndex = 1; argumentIndex < arguments.Length - 1; argumentIndex++)
			{
				sb.Append('"');
				sb.Append(arguments[argumentIndex]);
				sb.Append("\" ");
			}

			if (arguments.Length > 1)
			{
				sb.Append('"');
				sb.Append(arguments[^1]);
				sb.Append('"');
			}

			ProcessStartInfo currentStartInfo = new ProcessStartInfo
			{
				FileName = Path.ChangeExtension(Application.ExecutablePath, "exe")
			};
			if (sb.Length > 0)
			{
				currentStartInfo.Arguments = sb.ToString();
			}

			Application.Exit();
			Process.Start(currentStartInfo);
		}
	}
}
