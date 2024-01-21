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
using System.IO;
using MySqlX.XDevAPI.Relational;

namespace Cours_Work1
{

    enum RowState
    {
        New,
        Deleted,
        Archivated,
        Existed,
        Modified
    }

    public partial class Interpol_Form : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;

        public Interpol_Form()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("first_name", "Name");
            dataGridView1.Columns.Add("last_name", "Last name");
            dataGridView1.Columns.Add("nickname", "Nickname");
            dataGridView1.Columns.Add("w_eight", "Weight");
            dataGridView1.Columns.Add("height", "Height");
            dataGridView1.Columns.Add("hair", "Hair");
            dataGridView1.Columns.Add("eye", "Eye");
            dataGridView1.Columns.Add("special_signs", "Special signs");
            dataGridView1.Columns.Add("cityzenship", "Cityzenship");
            dataGridView1.Columns.Add("place_of_birth", "place of birth");
            dataGridView1.Columns.Add("date_of_birth", "Date of birth");
            dataGridView1.Columns.Add("last_place_of_residence", "Last place of residence");
            dataGridView1.Columns.Add("knowledge_of_languages", "Knowledge of languages");
            dataGridView1.Columns.Add("criminal_profession", "Criminal profession");
            dataGridView1.Columns.Add("last_case", "Last case");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add
                (
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetInt32(4),
                record.GetInt32(5),
                record.GetString(6),
                record.GetString(7),
                record.GetString(8),
                record.GetString(9),
                record.GetString(10),
                record.GetDateTime(11).ToString("yyyy.MM.dd"), 
                record.GetString(12),
                record.GetString(13),
                record.GetString(14),
                record.GetString(15),
                RowState.New
                );
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string quertyString = $"select * from Criminals";

            SqlCommand command = new SqlCommand(quertyString, dataBase.Get_Connection());

            dataBase.Open_Connection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                Label_FristName.Text = row.Cells[1].Value.ToString();
                Label_LastName.Text = row.Cells[2].Value.ToString();
                Label_Nickname.Text = row.Cells[3].Value.ToString();
                labelDisplayWeight.Text = row.Cells[4].Value.ToString();
                labelDisplayHeight.Text = row.Cells[5].Value.ToString();
                labelDisplayHair.Text = row.Cells[6].Value.ToString();
                labelDisplayEye.Text = row.Cells[7].Value.ToString();
                labelDisplaySigns.Text = row.Cells[8].Value.ToString();
                labelDisplayCityzenship.Text = row.Cells[9].Value.ToString();
                labelDisplayPlaceBirth.Text = row.Cells[10].Value.ToString();
                labelDateOfBirth.Text = row.Cells[11].Value.ToString();
                labelDisplayResidence.Text = row.Cells[12].Value.ToString();
                labelDisplayLanguages.Text = row.Cells[13].Value.ToString();
                labelDisplayProfession.Text = row.Cells[14].Value.ToString();
                labelDisplayCase.Text = row.Cells[15].Value.ToString();
            }
        }

        private void Button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void CreateNew_Button_Click(object sender, EventArgs e)
        {
            FormCreate frmcreate = new FormCreate();
            frmcreate.Show();
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Criminals where concat (id, first_name, last_name, nickname, w_eight, height, hair, eye, special_signs, cityzenship, place_of_birth, date_of_birth, last_place_of_residence, knowledge_of_languages, criminal_profession, last_case) like '%" + textBox_search.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, dataBase.Get_Connection());

            dataBase.Open_Connection();

            SqlDataReader read = command.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Visible == false)
            {
                dataGridView1.Rows[index].Cells[16].Value = RowState.Deleted;
                return;
            }
            else
            {
                MessageBox.Show("no");
                dataGridView1.Rows[index].Cells[16].Value = RowState.Existed;
            }
        }

        private void Save()
        {
            dataBase.Open_Connection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[16].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuary = $"delete from Criminals where id = {id}";

                    var command = new SqlCommand(deleteQuary, dataBase.Get_Connection());
                    command.ExecuteNonQuery();

                    SqlCommand CommandIncrement = new SqlCommand("update Criminals set id = id - 1 where id > " + id + "", dataBase.Get_Connection());
                }

            }
            dataBase.Close_Connection();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete it? To save the changes after deleted, click the \"Save\" button", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                DeleteRow();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            FormEdit frmedit = new FormEdit(selectedRow, row);

            frmedit.Show();
        }
    }
}
