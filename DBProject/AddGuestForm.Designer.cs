namespace DBProject
{
    partial class AddGuestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            comboBoxGender = new ComboBox();
            dateTimePickerBirthDay = new DateTimePicker();
            textBoxFullName = new TextBox();
            buttonAddClient = new Button();
            buttonDelete = new Button();
            openFileDialog1 = new OpenFileDialog();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewComboBoxColumn();
            Column5 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 180;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(587, 440);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 466);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Клиенты";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxGender);
            groupBox2.Controls.Add(dateTimePickerBirthDay);
            groupBox2.Controls.Add(textBoxFullName);
            groupBox2.Controls.Add(buttonAddClient);
            groupBox2.Location = new Point(611, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 416);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Новый клиент";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(49, 126);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 250);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Фотография";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 95);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 11;
            label4.Text = "Пол";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 64);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 10;
            label3.Text = "Дата рождения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 8;
            label1.Text = "ФИО";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Мужской", "Женский" });
            comboBoxGender.Location = new Point(187, 92);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(122, 28);
            comboBoxGender.TabIndex = 7;
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthDay.Location = new Point(187, 59);
            dateTimePickerBirthDay.MinDate = new DateTime(1939, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(122, 27);
            dateTimePickerBirthDay.TabIndex = 6;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(187, 26);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(122, 27);
            textBoxFullName.TabIndex = 4;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Location = new Point(132, 382);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(94, 29);
            buttonAddClient.TabIndex = 3;
            buttonAddClient.Text = "Добавить";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(640, 434);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg |Image files (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "IdGuest";
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 28;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FullName";
            Column2.FillWeight = 97.68271F;
            Column2.HeaderText = "ФИО";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 71;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BirthDay";
            Column3.FillWeight = 97.68271F;
            Column3.HeaderText = "Дата рождения";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 145;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Gender";
            Column4.FillWeight = 97.68271F;
            Column4.HeaderText = "Пол";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Width = 66;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.DataPropertyName = "FaceImage";
            Column5.FillWeight = 106.951874F;
            Column5.HeaderText = "Фотография";
            Column5.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AddGuestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 503);
            Controls.Add(buttonDelete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AddGuestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddGuestForm";
            FormClosed += AddGuestForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonAddClient;
        private Button buttonDelete;
        private TextBox textBoxFullName;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerBirthDay;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewComboBoxColumn Column4;
        private DataGridViewImageColumn Column5;
    }
}