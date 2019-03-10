using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Program
{
    public partial class Librarians : Form
    {
        bool[] ChosenColumns = new bool[6];
        bool[] ChosenFilters = new bool[6];
        public static string SelectedUser = "1";
        string LastQuery = "";
        string[] Cols = { "Staff_Number", "FIO", "Birthday", "Phone_Number", "Email", "Hiring_Date" };
        string[] ColsForUser = { @"'№'", "'ФИО'", "'Дата рождения'", "'Номер телефона'", "'Email'", "'Дата принятия'" };

        public Librarians()
        {
            InitializeComponent();
        }

        private void Librarians_Load(object sender, EventArgs e)
        {            
            ChosenColumns[0] = true;
            ChosenColumns[1] = true;
            ChosenColumns[2] = true;
            ChosenColumns[5] = true;
            OutputLibrarians("");
        }

        private void CB_StaffNumber_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[0] = CB_StaffNumber.Checked;
        }

        private void CB_Name_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[1] = CB_Name.Checked;
        }

        private void CB_Birthday_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[2] = CB_Birthday.Checked;
        }

        private void CB_Phone_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[3] = CB_Phone.Checked;
        }

        private void CB_Email_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[4] = CB_Email.Checked;
        }

        private void CB_Hiring_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[5] = CB_Hiring.Checked;
        }

        private void CB_Filter_Library_Code_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[0] = CB_Filter_Library_Code.Checked;
        }

        private void CB_Filter_FIO_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[1] = CB_Filter_FIO.Checked;
        }

        private void CB_Filter_Date_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[2] = CB_Filter_Date.Checked;
        }

        private void CB_Filter_Phone_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[3] = CB_Filter_Phone.Checked;
        }

        private void CB_Filter_Email_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[4] = CB_Filter_Email.Checked;
        }

        private void CB_Filter_Hiring_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[5] = CB_Filter_Email.Checked;
        }

        private void btn_ApplyFilter_Click(object sender, EventArgs e)
        {
            string[] values = new string[6];
            values[0] = TB_LibrarianCode.Text;
            values[1] = TB_FIO.Text;
            values[2] = DTP_Birth.Value.Year + "-" + DTP_Birth.Value.Month + "-" + DTP_Birth.Value.Day;
            values[3] = TB_PhoneNumber.Text;
            values[4] = TB_Email.Text;
            values[5] = DTP_Hiring.Value.Year + "-" + DTP_Hiring.Value.Month + "-" + DTP_Hiring.Value.Day;
            string FilterCode = "";
            for (int i = 0; i < values.Length; i++)
            {
                if (ChosenFilters[i])
                    if (i == 1)
                    {
                        FilterCode += " and " + Cols[i] + " like '%" + values[i] + "%'";
                    }
                    else
                    {
                        FilterCode += " and " + Cols[i] + "= '" + values[i] + "'";
                    }
            }
            LastQuery = FilterCode;
            OutputLibrarians(LastQuery);
        }
        private void OutputLibrarians(string filter)
        {
            string Columns = "";
            bool AtLeastOne = false;//->false
            for (int i = 0; i < ChosenColumns.Length; i++)
            {
                if (ChosenColumns[i])
                {
                    if (!AtLeastOne)
                    {
                        Columns += Cols[i] + " as " + ColsForUser[i];
                        AtLeastOne = true;
                    }
                    else
                    {
                        Columns += ", " + Cols[i] + " as " + ColsForUser[i];
                    }
                }
            }
            if (Columns != "")
            {
                string Readers = "select Staff_Number, " + Columns + " from Librarian, Person, Address where Librarian.Person_Code=Person.Person_ID and Person.Address_Code=Address.Address_ID and Privilege=0 and Librarian.Deleted=0" + filter;
                DbDataReader reader = Control.ExecCommand(Readers);
                if (reader.HasRows)
                {
                    DGV_Workers.Rows.Clear();
                    DGV_Workers.Columns.Clear();
                    DGV_Workers.Columns.Add("ID", "ID");
                    DGV_Workers.Columns[0].Visible = false;
                    for (int i = 1; i < reader.FieldCount; i++)
                    {
                        string str = reader.GetName(i);
                        DGV_Workers.Columns.Add(str, str);
                    }
                    reader.Read();
                    object[] temp = new object[reader.FieldCount];
                    reader.GetValues(temp);
                    for (int i = 0; i < reader.FieldCount; i++)//Удаление ЧЧ:ММ из DateTime
                    {
                        if (temp[i] is DateTime)
                        {
                            temp[i] = temp[i].ToString().Substring(0, temp[i].ToString().IndexOf(' '));
                        }
                    }
                    DGV_Workers.Rows.Add(temp);
                    while (reader.Read())
                    {
                        temp = new object[reader.FieldCount];
                        reader.GetValues(temp);
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (temp[i] is DateTime)
                            {
                                temp[i] = temp[i].ToString().Substring(0, temp[i].ToString().IndexOf(' '));
                            }
                        }
                        DGV_Workers.Rows.Add(temp);
                    }
                    reader.Close();
                    btn_Info.Enabled = true;
                    btn_Change.Enabled = true;
                    btn_Delete.Enabled = true;
                }
                else
                {
                    reader.Close();
                    DGV_Workers.Rows.Clear();
                    DGV_Workers.Columns.Clear();
                    MessageBox.Show("По данным фильтрам не найдено ни одного библиотекаря!");
                    btn_Info.Enabled = false;
                    btn_Change.Enabled = false;
                    btn_Delete.Enabled = false;
                }
            }
            else
            {
                DGV_Workers.Rows.Clear();
                DGV_Workers.Columns.Clear();
                MessageBox.Show("По данным фильтрам не найдено ни одного библиотекаря!");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OutputLibrarians(LastQuery);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddLib add = new AddLib();
            add.ShowDialog();
            OutputLibrarians(LastQuery);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            AddLib ChangeForm = new AddLib(true);
            ChangeForm.ShowDialog();
            OutputLibrarians(LastQuery);
        }

        private void DGV_Workers_SelectionChanged(object sender, EventArgs e)
        {
            SelectedUser = DGV_Workers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            Librarian_Info InfoForm = new Librarian_Info();
            InfoForm.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить данного библиотекаря?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Control.DeleteLib(SelectedUser);
                OutputLibrarians(LastQuery);
            }
        }

        private void btn_FilterReset_Click(object sender, EventArgs e)
        {
            CB_StaffNumber.Checked = true;
            CB_Name.Checked = true;
            CB_Birthday.Checked = true;
            CB_Phone.Checked = false;
            CB_Email.Checked = false;
            CB_Hiring.Checked = true;
            CB_Filter_Date.Checked = false;
            CB_Filter_Email.Checked = false;
            CB_Filter_FIO.Checked = false;
            CB_Filter_Hiring.Checked = false;
            CB_Filter_Library_Code.Checked = false;
            CB_Filter_Phone.Checked = false;
            TB_Email.Text = "";
            TB_FIO.Text = "";
            TB_LibrarianCode.Text = "";
            TB_PhoneNumber.Text = "";
            DTP_Birth.Value = DateTime.Today;
            DTP_Hiring.Value = DateTime.Today;
            LastQuery = "";
            OutputLibrarians(LastQuery);
        }
    }
}
