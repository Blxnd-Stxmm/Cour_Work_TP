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
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Linq;

namespace Cours_Work1
{
    public partial class FormEdit : Form
    {
        DataBase dataBase = new DataBase();
        string id;

        public FormEdit(int selectedRow, DataGridViewRow row)
        {
            InitializeComponent();

            if (selectedRow >= 0)
            {
                id = row.Cells[0].Value.ToString();
                TextBox_FirstName.Text = row.Cells[1].Value.ToString();
                Textbox_LastName.Text = row.Cells[2].Value.ToString();
                TextBox_Nickname.Text = row.Cells[3].Value.ToString();
                TextBox_Weight.Text = row.Cells[4].Value.ToString();
                TextBox_Height.Text = row.Cells[5].Value.ToString();
                TextBox_Hair.Text = row.Cells[6].Value.ToString();
                TextBox_Eye.Text = row.Cells[7].Value.ToString();
                TextBox_SpecSigns.Text = row.Cells[8].Value.ToString();
                TextBox_Cityzenship.Text = row.Cells[9].Value.ToString();
                TextBox_PlaceBirth.Text = row.Cells[10].Value.ToString();
                TextBox_DateBirth.Text = row.Cells[11].Value.ToString();
                TextBox_LastPlace.Text = row.Cells[12].Value.ToString();
                TextBox_KnowLanguage.Text = row.Cells[13].Value.ToString();
                TextBox_Profession.Text = row.Cells[14].Value.ToString();
                TextBox_LastCase.Text = row.Cells[15].Value.ToString();
            }
        }

        private void Edit_Gangster()
        {
            dataBase.Open_Connection();

            var fname = TextBox_FirstName.Text;
            var lname = Textbox_LastName.Text;
            var nick = TextBox_Nickname.Text;
            int weight = 0;
            int height = 0;
            var hair = TextBox_Hair.Text;
            var eye = TextBox_Eye.Text;
            var specSqns = TextBox_SpecSigns.Text;
            var cityzenship = TextBox_Cityzenship.Text;
            var placeBirth = TextBox_PlaceBirth.Text;
            DateTime dateBirth;
            var lastPlace = TextBox_LastPlace.Text;
            var knowLang = TextBox_KnowLanguage.Text;
            var profession = TextBox_Profession.Text;
            var lastCase = TextBox_LastCase.Text;

            if (DateTime.TryParse(TextBox_DateBirth.Text, out dateBirth) && int.TryParse(TextBox_Height.Text, out height) && int.TryParse(TextBox_Weight.Text, out weight))
            {
                var changeQuery = $"update Criminals set first_name = '{fname}', last_name = '{lname}', nickname = '{nick}', w_eight = '{weight}', height = '{height}', hair = '{hair}', eye = '{eye}', special_signs = '{specSqns}', cityzenship = '{cityzenship}', place_of_birth = '{placeBirth}', date_of_birth = '{dateBirth.ToString("yyyy.MM.dd")}', last_place_of_residence = '{lastPlace}', knowledge_of_languages =  '{knowLang}', criminal_profession = '{profession}', last_case = '{lastCase}' where id = '{id}'";
                var command = new SqlCommand(changeQuery, dataBase.Get_Connection());
                command.ExecuteNonQuery();

                MessageBox.Show("Data was edited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error, Check the correctness of the entered values. Weight and height must be non-negative numbers, and the date format is \"DD.MM.YYYY\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.Close_Connection();
            Close();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void Button_Edit_Gangster_Click(object sender, EventArgs e)
        {
            if ((TextBox_Cityzenship.Text != "") && (TextBox_DateBirth.Text != "") && (TextBox_Eye.Text != "") && (TextBox_Hair.Text != "") && (TextBox_Height.Text != "") && (TextBox_Height.Text != "") && (TextBox_LastCase.Text != "") && (TextBox_LastCase.Text != "") && (TextBox_PlaceBirth.Text != "") && (TextBox_Profession.Text != "") && (TextBox_SpecSigns.Text != "") && (TextBox_Height.Text != "") && (TextBox_FirstName.Text != "") && (TextBox_Height.Text != "") && (TextBox_Nickname.Text != ""))
            {
                Edit_Gangster();
            }
            else
            {
                MessageBox.Show("Error - all lines must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
