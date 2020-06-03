using System;
using System.Windows.Forms;

namespace MinesweeperCore
{
    public partial class Custom : Form
    {
        public int Columns;
        public int Rows;
        public int TotalMines;

        public Custom()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (int.TryParse(columnsTextBox.Text, out int columns) && int.TryParse(rowsTextBox.Text, out int rows) &&
                int.TryParse(totalMine.Text, out int totalMines))
            {
                if (columns != 0 && rows != 0 && totalMines != 0 && totalMines <= columns * rows / 2)
                {
                    Columns = columns;
                    Rows = rows;
                    TotalMines = totalMines;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}