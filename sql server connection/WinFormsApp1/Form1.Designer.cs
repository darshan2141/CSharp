namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1No = new TextBox();
            textBox2Name = new TextBox();
            textBox3Mobile = new TextBox();
            comboBox1City = new ComboBox();
            radioButton1Male = new RadioButton();
            radioButton1Female = new RadioButton();
            button1Insert = new Button();
            button1Update = new Button();
            dataGridView1 = new DataGridView();
            Update = new DataGridViewLinkColumn();
            Delete = new DataGridViewLinkColumn();
            textBox4Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 0;
            label1.Text = "No : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(484, 11);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 1;
            label2.Text = "Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 62);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 2;
            label3.Text = "Mobile : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(503, 58);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 3;
            label4.Text = "City : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 126);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 4;
            label5.Text = "Gender : ";
            // 
            // textBox1No
            // 
            textBox1No.Location = new Point(120, 13);
            textBox1No.Name = "textBox1No";
            textBox1No.Size = new Size(274, 27);
            textBox1No.TabIndex = 5;
            textBox1No.KeyPress += textBox1No_KeyPress;
            // 
            // textBox2Name
            // 
            textBox2Name.Location = new Point(603, 12);
            textBox2Name.Name = "textBox2Name";
            textBox2Name.Size = new Size(274, 27);
            textBox2Name.TabIndex = 6;
            textBox2Name.KeyPress += textBox2Name_KeyPress;
            // 
            // textBox3Mobile
            // 
            textBox3Mobile.Location = new Point(120, 66);
            textBox3Mobile.Name = "textBox3Mobile";
            textBox3Mobile.Size = new Size(274, 27);
            textBox3Mobile.TabIndex = 7;
            textBox3Mobile.KeyPress += textBox3Mobile_KeyPress;
            // 
            // comboBox1City
            // 
            comboBox1City.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1City.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1City.ForeColor = SystemColors.ActiveCaptionText;
            comboBox1City.FormattingEnabled = true;
            comboBox1City.Items.AddRange(new object[] { "Junagadh", "Rajkot", "Surat", "Baroda", "Ahemdabad", "Gandhinagar" });
            comboBox1City.Location = new Point(602, 62);
            comboBox1City.Name = "comboBox1City";
            comboBox1City.Size = new Size(275, 36);
            comboBox1City.TabIndex = 8;
            // 
            // radioButton1Male
            // 
            radioButton1Male.AutoSize = true;
            radioButton1Male.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1Male.Location = new Point(122, 131);
            radioButton1Male.Name = "radioButton1Male";
            radioButton1Male.Size = new Size(64, 24);
            radioButton1Male.TabIndex = 9;
            radioButton1Male.TabStop = true;
            radioButton1Male.Text = "Male";
            radioButton1Male.UseVisualStyleBackColor = true;
            // 
            // radioButton1Female
            // 
            radioButton1Female.AutoSize = true;
            radioButton1Female.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1Female.Location = new Point(229, 131);
            radioButton1Female.Name = "radioButton1Female";
            radioButton1Female.Size = new Size(80, 24);
            radioButton1Female.TabIndex = 10;
            radioButton1Female.TabStop = true;
            radioButton1Female.Text = "Female";
            radioButton1Female.UseVisualStyleBackColor = true;
            // 
            // button1Insert
            // 
            button1Insert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1Insert.Location = new Point(344, 119);
            button1Insert.Name = "button1Insert";
            button1Insert.Size = new Size(141, 42);
            button1Insert.TabIndex = 11;
            button1Insert.Text = "Insert";
            button1Insert.UseVisualStyleBackColor = true;
            button1Insert.Click += button1Insert_Click;
            // 
            // button1Update
            // 
            button1Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1Update.Location = new Point(344, 119);
            button1Update.Name = "button1Update";
            button1Update.Size = new Size(141, 42);
            button1Update.TabIndex = 12;
            button1Update.Text = "Update";
            button1Update.UseVisualStyleBackColor = true;
            button1Update.Visible = false;
            button1Update.Click += button1Update_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Update, Delete });
            dataGridView1.Location = new Point(11, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(903, 256);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Update
            // 
            Update.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Update.HeaderText = "Update";
            Update.MinimumWidth = 6;
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.Text = "Update";
            Update.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Delete";
            Delete.UseColumnTextForLinkValue = true;
            // 
            // textBox4Search
            // 
            textBox4Search.Location = new Point(536, 119);
            textBox4Search.Name = "textBox4Search";
            textBox4Search.PlaceholderText = "Search By Name";
            textBox4Search.Size = new Size(341, 27);
            textBox4Search.TabIndex = 14;
            textBox4Search.TextChanged += textBox4Search_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 450);
            Controls.Add(textBox4Search);
            Controls.Add(dataGridView1);
            Controls.Add(button1Update);
            Controls.Add(button1Insert);
            Controls.Add(radioButton1Female);
            Controls.Add(radioButton1Male);
            Controls.Add(comboBox1City);
            Controls.Add(textBox3Mobile);
            Controls.Add(textBox2Name);
            Controls.Add(textBox1No);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1No;
        private TextBox textBox2Name;
        private TextBox textBox3Mobile;
        private ComboBox comboBox1City;
        private RadioButton radioButton1Male;
        private RadioButton radioButton1Female;
        private Button button1Insert;
        private Button button1Update;
        private DataGridView dataGridView1;
        private TextBox textBox4Search;
        private DataGridViewLinkColumn Update;
        private DataGridViewLinkColumn Delete;
    }
}