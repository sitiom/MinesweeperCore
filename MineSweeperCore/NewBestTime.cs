using System;
using System.Windows.Forms;

namespace MinesweeperCore
{
    public partial class NewBestTime : Form
    {
        public string LastPlayerName;

        public NewBestTime(string level)
        {
            InitializeComponent();
            descriptionLabel.Text = descriptionLabel.Text.Replace("<level>", level);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            LastPlayerName = playerName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}