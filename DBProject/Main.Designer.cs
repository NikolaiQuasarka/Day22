namespace DBProject
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            buttonAddRoom = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            textBoxNumber = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBoxPrice = new TextBox();
            textBoxComfortLevel = new TextBox();
            groupBox3 = new GroupBox();
            buttonSaveChanges = new Button();
            comboBoxChangeClient = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            textBoxChangePrice = new TextBox();
            textBoxChangeComfortLevel = new TextBox();
            textBoxChangeNumber = new TextBox();
            buttonDelete = new Button();
            textBoxChangeCount = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(476, 449);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "IdRoom";
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Number";
            Column2.HeaderText = "Номер комнаты";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.DataPropertyName = "IdGuest";
            Column3.HeaderText = "Арендатор";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.Width = 114;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "GuestCount";
            Column4.HeaderText = "Число жителей";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ComfortLevel";
            Column5.HeaderText = "Уровень комфорта";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Price";
            Column6.HeaderText = "Цена";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 475);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Номера гостиницы";
            // 
            // buttonAddRoom
            // 
            buttonAddRoom.Location = new Point(90, 141);
            buttonAddRoom.Name = "buttonAddRoom";
            buttonAddRoom.Size = new Size(206, 29);
            buttonAddRoom.TabIndex = 2;
            buttonAddRoom.Text = "Добавить новую комнату";
            buttonAddRoom.UseVisualStyleBackColor = true;
            buttonAddRoom.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(9, 493);
            button2.Name = "button2";
            button2.Size = new Size(198, 29);
            button2.TabIndex = 3;
            button2.Text = "Добавить нового гостя";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxNumber);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxPrice);
            groupBox2.Controls.Add(textBoxComfortLevel);
            groupBox2.Controls.Add(buttonAddRoom);
            groupBox2.Location = new Point(500, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 197);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Новый номер";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(170, 26);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(159, 27);
            textBoxNumber.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 11;
            label1.Text = "Номер комнаты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 92);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 10;
            label4.Text = "Цена";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 8;
            label2.Text = "Уровень комфорта";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(170, 92);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(159, 27);
            textBoxPrice.TabIndex = 6;
            // 
            // textBoxComfortLevel
            // 
            textBoxComfortLevel.Location = new Point(170, 59);
            textBoxComfortLevel.Name = "textBoxComfortLevel";
            textBoxComfortLevel.Size = new Size(159, 27);
            textBoxComfortLevel.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxChangeCount);
            groupBox3.Controls.Add(buttonSaveChanges);
            groupBox3.Controls.Add(comboBoxChangeClient);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBoxChangePrice);
            groupBox3.Controls.Add(textBoxChangeComfortLevel);
            groupBox3.Controls.Add(textBoxChangeNumber);
            groupBox3.Location = new Point(500, 215);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(367, 307);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Изменение данных";
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(151, 272);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(94, 29);
            buttonSaveChanges.TabIndex = 11;
            buttonSaveChanges.Text = "Сохранить";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // comboBoxChangeClient
            // 
            comboBoxChangeClient.FormattingEnabled = true;
            comboBoxChangeClient.Location = new Point(170, 79);
            comboBoxChangeClient.Name = "comboBoxChangeClient";
            comboBoxChangeClient.Size = new Size(159, 28);
            comboBoxChangeClient.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 214);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 9;
            label8.Text = "Цена";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 168);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 8;
            label7.Text = "Уровень комфорта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 82);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 6;
            label5.Text = "Арендатор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 43);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 5;
            label3.Text = "Номер комнаты";
            // 
            // textBoxChangePrice
            // 
            textBoxChangePrice.Location = new Point(170, 211);
            textBoxChangePrice.Name = "textBoxChangePrice";
            textBoxChangePrice.Size = new Size(159, 27);
            textBoxChangePrice.TabIndex = 4;
            // 
            // textBoxChangeComfortLevel
            // 
            textBoxChangeComfortLevel.Location = new Point(170, 165);
            textBoxChangeComfortLevel.Name = "textBoxChangeComfortLevel";
            textBoxChangeComfortLevel.Size = new Size(159, 27);
            textBoxChangeComfortLevel.TabIndex = 3;
            // 
            // textBoxChangeNumber
            // 
            textBoxChangeNumber.Location = new Point(170, 40);
            textBoxChangeNumber.Name = "textBoxChangeNumber";
            textBoxChangeNumber.Size = new Size(159, 27);
            textBoxChangeNumber.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(345, 493);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(146, 29);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить комнату";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxChangeCount
            // 
            textBoxChangeCount.Location = new Point(170, 122);
            textBoxChangeCount.Name = "textBoxChangeCount";
            textBoxChangeCount.Size = new Size(159, 27);
            textBoxChangeCount.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 125);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 13;
            label6.Text = "Количество жителей";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 540);
            Controls.Add(buttonDelete);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Main_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button buttonAddRoom;
        private Button button2;
        private GroupBox groupBox2;
        private TextBox textBoxComfortLevel;
        private TextBox textBoxPrice;
        private Label label4;
        private Label label2;
        private TextBox textBoxNumber;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox textBoxChangePrice;
        private TextBox textBoxChangeComfortLevel;
        private TextBox textBoxChangeNumber;
        private ComboBox comboBoxChangeClient;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label3;
        private Button buttonSaveChanges;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label6;
        private TextBox textBoxChangeCount;
    }
}
