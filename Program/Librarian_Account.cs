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
    public partial class Librarian_Account : Form
    {
        public Librarian_Account()
        {
            InitializeComponent();
        }

        private void Librarian_Account_Load(object sender, EventArgs e)
        {
            TB_Name.Text = MainMenu.CurrentLibrarian.FIO;
            TB_Birth.Text = MainMenu.CurrentLibrarian.Birth;
            TB_Phone.Text = MainMenu.CurrentLibrarian.Phone;
            TB_Email.Text = MainMenu.CurrentLibrarian.Email;
            RTB_Address.Text = MainMenu.CurrentLibrarian.Address;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {            
            Close();
        }
    }
}
