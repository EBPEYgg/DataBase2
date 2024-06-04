using DataBase2.Properties;
using System;
using System.Windows.Forms;
using DataBase2.View;

namespace DataBase2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(
                "Вы хотите закрыть программу?",
                "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КСУП, Фатуев Алексей Владимирович, 572-3, 2024", 
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void RoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsListForm.roomsListForm.ShowForm();
        }

        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffListForm.staffListForm.ShowForm();
        }

        private void GuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestsListForm.guestsListForm.ShowForm();
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersListForm.ordersListForm.ShowForm();
        }

        private void SQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLForm sqlForm = new SQLForm();
            sqlForm.Show();
        }
    }
}