using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class MainMenu : Form
    {
        public static Authorization enter;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            enter.Close();
        }

        private void TSM_Books_OpenBase_Click(object sender, EventArgs e)
        {
            Books formBooks = new Books();
            formBooks.ShowDialog();
        }

        private void TSM_Librarian_Change_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //enter = new Authorization();
            enter.Show();
            this.Hide();
        }

        private void TSM_Librarian_Profile_Click(object sender, EventArgs e)
        {
            Librarian_Account formAccount = new Librarian_Account();
            formAccount.ShowDialog();
        }

        private void TSM_Librarian_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSM_Readers_CurrentPenalty_Click(object sender, EventArgs e)
        {
            Penalty formPenalties = new Penalty();
            formPenalties.ShowDialog();
        }

        private void TSM_Readers_CurrentBooks_Click(object sender, EventArgs e)
        {
            CurrentBooks formBooks = new CurrentBooks();
            formBooks.ShowDialog();
        }

        private void TSM_Books_Give_Click(object sender, EventArgs e)
        {
            GiveBook formGive = new GiveBook();
            formGive.ShowDialog();
        }

        private void TSM_books_get_Click(object sender, EventArgs e)
        {
            GetBook formGet = new GetBook();
            formGet.ShowDialog();
        }

        private void TSM_Books_Journal_Click(object sender, EventArgs e)
        {
            Journal formJournal = new Journal();
            formJournal.ShowDialog();
        }
    }
}
