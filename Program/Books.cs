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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            BookInfo formBookInfo = new BookInfo();
            formBookInfo.ShowDialog();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            AddBook formBookChange = new AddBook();
            formBookChange.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddBook formBookAdd = new AddBook();
            formBookAdd.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //MessageBox -Удалить книгу -(да/нет)
        }
    }
}
