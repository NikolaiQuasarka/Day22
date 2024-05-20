using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class AddGuestForm : Form
    {
        public AddGuestForm()
        {
            InitializeComponent();


            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sqlCommand = "SELECT * FROM Guest";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                sqlDataAdapter.Fill(ds, "Guest");
                dataGridView1.DataSource = ds.Tables["Guest"];
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Gender");
            dt.Rows.Add("Мужской");
            dt.Rows.Add("Женский");
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[3]).DataSource = dt;
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[3]).DisplayMember = "Gender";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[3]).ValueMember = "Gender";

        }
        DataSet ds = new DataSet();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(File.Exists(openFileDialog1.FileName) )
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
            

        private void AddGuestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sqlCommand = "SELECT * FROM Guest";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Update(ds, "Guest");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text != ""&comboBoxGender.Text!="")
            {
                byte[] imageBytes=null;
                if (File.Exists(openFileDialog1.FileName))
                imageBytes = File.ReadAllBytes(string.Join('\\',openFileDialog1.FileName));
                ds.Tables["Guest"].Rows.Add(null, textBoxFullName.Text,dateTimePickerBirthDay.Value,comboBoxGender.Text,imageBytes);
            }
        }
    }
}
