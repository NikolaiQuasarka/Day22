using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace DBProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (Program.connectionString == null)
            {
                string sqlDBCreation = "CREATE TABLE [dbo].[Guest] (\r\n    [IdGuest]  INT        NOT NULL IDENTITY,\r\n    [FullName] NCHAR (30) NOT NULL,\r\n    [BirthDay] DATE       NOT NULL,\r\n    [Gender]   NCHAR (10) NOT NULL,\r\n    PRIMARY KEY CLUSTERED ([IdGuest] ASC)\r\n);" +
                    "CREATE TABLE [dbo].[Room] (\r\n    [IdRoom]       INT NOT NULL IDENTITY(1, 1),\r\n    [IdGuest]      INT NULL,\r\n    [ComfortLevel] INT NOT NULL,\r\n    [GuestCount]   INT NOT NULL,\r\n    [Price]        INT NOT NULL,\r\n    PRIMARY KEY CLUSTERED ([IdRoom] ASC),\r\n    CONSTRAINT [FK_Room_Guest] FOREIGN KEY ([IdGuest]) REFERENCES [dbo].[Guest] ([IdGuest])\r\n);" +
                    "CREATE TABLE [dbo].[RoomGuest] (\r\n    [IdRoomGuest]  INT NOT NULL IDENTITY,\r\n    [IdRoom]       INT NOT NULL,\r\n    [IdGuest]      INT NOT NULL,\r\n    [LengthOfStay] INT NOT NULL,\r\n    PRIMARY KEY CLUSTERED ([IdRoomGuest] ASC),\r\n    CONSTRAINT [FK_RoomGuest_Guest] FOREIGN KEY ([IdGuest]) REFERENCES [dbo].[Guest] ([IdGuest]),\r\n    CONSTRAINT [FK_RoomGuest_Room] FOREIGN KEY ([IdRoom]) REFERENCES [dbo].[Room] ([IdRoom])\r\n);";
                SqlCommand command = new SqlCommand(sqlDBCreation);
                command.ExecuteNonQuery();
            }

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sqlCommand = "SELECT * FROM Room";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                sqlDataAdapter.Fill(ds, "Room");
                dataGridView1.DataSource = ds.Tables["Room"];

                sqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM Guest";
                sqlDataAdapter.Fill(ds, "Guest");
                comboBoxChangeClient.DataSource = ds.Tables["Guest"];
                comboBoxChangeClient.DisplayMember = "FullName";
                comboBoxChangeClient.ValueMember = "IdGuest";

            }
        }
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int num) & int.TryParse(textBoxComfortLevel.Text, out int level) & int.TryParse(textBoxPrice.Text, out int price))
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    string sqlCommand = "SELECT * FROM Room";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                    ds.Tables["Room"].Rows.Add(null, num, null, 0, level, price);
                    sqlDataAdapter.Update(ds, "Room");


                }

            }
        }
        /*private void UpdateDGV()
        {
            string sqlCommand = "SELECT * FROM Room";
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                ds.Tables["Room"].Clear();
                sqlDataAdapter.Fill(ds, "Room");
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            AddGuestForm addGuestForm = new AddGuestForm();
            addGuestForm.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    string sqlCommand = "SELECT * FROM Guest";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                    ds.Tables["Guest"].Clear();
                    sqlDataAdapter.Fill(ds, "Guest");
                    comboBoxChangeClient.DataSource = ds.Tables["Guest"];
                    comboBoxChangeClient.DisplayMember = "FullName";
                    comboBoxChangeClient.ValueMember = "IdGuest";
                }
                
            };
            addGuestForm.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                string sqlCommand = "SELECT * FROM Room";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Update(ds, "Room");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    string sqlCommand = "SELECT * FROM Room";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    sqlDataAdapter.Update(ds, "Room");
                }
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxChangeNumber.Text, out int num) & int.TryParse(textBoxChangeComfortLevel.Text, out int level) & int.TryParse(textBoxChangePrice.Text, out int price)&int.TryParse(textBoxChangeCount.Text,out int count))
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    string sqlCommand = "SELECT * FROM Room";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                    //ds.Tables["Room"].Rows.Add(null, num, null, 0, level, price);
                    dataGridView1.SelectedRows[0].Cells[1].Value = num;
                    dataGridView1.SelectedRows[0].Cells[2].Value = comboBoxChangeClient.SelectedValue;
                    dataGridView1.SelectedRows[0].Cells[3].Value = count;
                    dataGridView1.SelectedRows[0].Cells[4].Value = level;
                    dataGridView1.SelectedRows[0].Cells[5].Value = price;
                    textBoxChangeNumber.Focus();
                    sqlDataAdapter.Update(ds, "Room");


                }

            }
        }
    }
}