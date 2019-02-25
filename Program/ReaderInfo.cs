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
    public partial class ReaderInfo : Form
    {
        public ReaderInfo()
        {
            InitializeComponent();
        }

        private void btn_CurrentBooks_Click(object sender, EventArgs e)
        {
            CurrentBooks formBooks = new CurrentBooks();
            formBooks.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
