using System;
using System.Windows.Forms;

namespace MinesweeperCore
{
	public partial class BestTime : Form
    {
        private readonly AppSettings _appSettings;
        
        public BestTime(AppSettings settings)
        {
            InitializeComponent();
            _appSettings = settings;
            BeginnerBestTime.Text = $"{_appSettings.BeginnerBestTime} seconds";
            beginnerPlayerName.Text = _appSettings.BeginnerPlayerName;
            IntermediateBestTime.Text = $"{_appSettings.IntermediateBestTime} seconds";
            intermediatePlayerName.Text = _appSettings.IntermediatePlayerName;
            ExpertBestTime.Text = $"{_appSettings.ExpertBestTime} seconds";
            expertPlayerName.Text = _appSettings.ExpertPlayerName;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            _appSettings.BeginnerBestTime = 999;
            _appSettings.BeginnerPlayerName = "Anonymous";
            _appSettings.IntermediateBestTime = 999;
            _appSettings.IntermediatePlayerName = "Anonymous";
            _appSettings.ExpertBestTime = 999;
            _appSettings.ExpertPlayerName = "Anonymous";

            BeginnerBestTime.Text = $"{_appSettings.BeginnerBestTime} seconds";
            beginnerPlayerName.Text = _appSettings.BeginnerPlayerName;
            IntermediateBestTime.Text = $"{_appSettings.IntermediateBestTime} seconds";
            intermediatePlayerName.Text = _appSettings.IntermediatePlayerName;
            ExpertBestTime.Text = $"{_appSettings.ExpertBestTime} seconds";
            expertPlayerName.Text = _appSettings.ExpertPlayerName;
        }
    }
}