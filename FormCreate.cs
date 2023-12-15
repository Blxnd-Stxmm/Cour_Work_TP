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

namespace Cours_Work1
{
    public partial class FormCreate : Form
    {
        DataBase dataBase = new DataBase();

        public FormCreate()
        {
            InitializeComponent();
        }

        private void Create_Gangster()
        {
            dataBase.Open_Connection();
            var fname = TextBoxFirstName.Text;
            var lname = Textbox_LastName.Text;
            var nick = TextBox_Nickname.Text;
            int weight = 0;
            int height = 0;
            var hair = textBoxHair.Text;
            var eye = textBoxEye.Text;
            var specSqns = textBoxSpecSqns.Text;
            var cityzenship = textBoxCityzenship.Text;
            var placeBirth = textBoxPlaceBirth.Text;
            DateTime dateBirth;
            var lastPlace = textBoxLastPlace.Text;
            var knowLang = textBoxKnowlanguage.Text;
            var Profession = textBoxProfession.Text;
            var lastCase = textBoxLastCase.Text;

            if (DateTime.TryParse(textBoxDateBirth.Text, out dateBirth) && int.TryParse(textBoxHeight.Text, out height) && int.TryParse(textBoxWeight.Text, out weight))
            {
                var addQuery = $"insert into Criminals (first_name, last_name, nickname, w_eight, height, hair, eye, special_signs, cityzenship, place_of_birth, date_of_birth, last_place_of_residence, knowledge_of_languages, criminal_profession, last_case) values ('{fname}', '{lname}', '{nick}', '{weight}', '{height}', '{hair}', '{eye}', '{specSqns}', '{cityzenship}', '{placeBirth}', '{dateBirth.ToString("dd.MM.yyyy")}', '{lastPlace}', '{knowLang}', '{Profession}', '{lastCase}' )";
                var command = new SqlCommand(addQuery, dataBase.Get_Connection());
                command.ExecuteNonQuery();

                MessageBox.Show("Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Error, Check the correctness of the entered values. Weight and height must be non-negative numbers, and the date format is \"dd.MM.yyyy\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.Close_Connection();

        }

        private void Button_Create_Gangster_Click(object sender, EventArgs e)
        {
            if ((textBoxCityzenship.Text != "") && (textBoxDateBirth.Text != "") && (textBoxEye.Text != "") && (textBoxHair.Text != "") && (textBoxHeight.Text != "") && (textBoxHeight.Text != "") && (textBoxLastCase.Text != "") && (textBoxLastCase.Text != "") && (textBoxPlaceBirth.Text != "") && (textBoxProfession.Text != "") && (textBoxSpecSqns.Text != "") && (textBoxHeight.Text != "") && (TextBoxFirstName.Text != "") && (textBoxHeight.Text != "") && (TextBox_Nickname.Text != ""))
            {
                Create_Gangster();
            }
            else
            {
                MessageBox.Show("Error - all lines must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Разрешение на ввод только цифр
            }

            if (textBox != null && textBox.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Отклоняем ввод, если количество символов достигло трех
            }
        }

        private void TextBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отклоняем ввод символа, если это цифра 
            }
        }
    }
}
