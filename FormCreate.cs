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
using System.Collections;

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
            int Counter = 0;
            var fname = TextBox_FirstName.Text;
            var lname = TextBox_LastName.Text;
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
                MessageBox.Show("Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var Query = "SELECT max_counter FROM ID_table";
                SqlCommand command = new SqlCommand(Query, dataBase.Get_Connection());
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Counter = Convert.ToInt32(reader["max_counter"]);
                }
                reader.Close();

                Query = $"UPDATE ID_table SET max_counter = '{++Counter}'";
                SqlCommand insertCommand = new SqlCommand(Query, dataBase.Get_Connection());
                insertCommand.ExecuteNonQuery();

                Query = $"insert into Criminals (id, first_name, last_name, nickname, w_eight, height, hair, eye, special_signs, cityzenship, place_of_birth, date_of_birth, last_place_of_residence, knowledge_of_languages, criminal_profession, last_case) values ('{Counter}', '{fname}', '{lname}', '{nick}', '{weight}', '{height}', '{hair}', '{eye}', '{specSqns}', '{cityzenship}', '{placeBirth}', '{dateBirth.ToString("yyyy.MM.dd")}', '{lastPlace}', '{knowLang}', '{profession}', '{lastCase}' )";
                command = new SqlCommand(Query, dataBase.Get_Connection());
                command.ExecuteNonQuery();

                dataBase.Close_Connection();
                Close();
            }
            else
            {
                MessageBox.Show("Error, Check the correctness of the entered values. Date format is \"yyyy.MM.dd\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Create_Gangster_Click(object sender, EventArgs e)
        {
            if ((TextBox_Cityzenship.Text != "") && (TextBox_DateBirth.Text != "") && (TextBox_Eye.Text != "") && (TextBox_Hair.Text != "") && (TextBox_Height.Text != "") && (TextBox_Height.Text != "") && (TextBox_LastCase.Text != "") && (TextBox_LastCase.Text != "") && (TextBox_PlaceBirth.Text != "") && (TextBox_Profession.Text != "") && (TextBox_SpecSigns.Text != "") && (TextBox_Height.Text != "") && (TextBox_FirstName.Text != "") && (TextBox_Height.Text != "") && (TextBox_Nickname.Text != ""))
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
