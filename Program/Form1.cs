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
    public partial class Authorization : Form
    {
        public static MainMenu menu;
        public Authorization()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {          
            
            menu.Show();
            MainMenu.enter = this;
            this.Hide();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            //menu.Close();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            MainMenu mainform = new MainMenu();
            menu = mainform;
        }
    }
}
