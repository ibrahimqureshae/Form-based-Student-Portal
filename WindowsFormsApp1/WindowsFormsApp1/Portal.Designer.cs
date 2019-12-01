namespace WindowsFormsApp1
{
    partial class Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MarkAttButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ListAllRadioButton = new System.Windows.Forms.RadioButton();
            this.Top3RadioButton = new System.Windows.Forms.RadioButton();
            this.NameRadioButton = new System.Windows.Forms.RadioButton();
            this.IDRadioButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EnterRecButton = new System.Windows.Forms.Button();
            this.CGPABox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeptBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SemBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UniBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.MarkAttButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.ListAllRadioButton);
            this.panel1.Controls.Add(this.Top3RadioButton);
            this.panel1.Controls.Add(this.NameRadioButton);
            this.panel1.Controls.Add(this.IDRadioButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EnterRecButton);
            this.panel1.Controls.Add(this.CGPABox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.DeptBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SemBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.UniBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.IDBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 459);
            this.panel1.TabIndex = 0;
            // 
            // MarkAttButton
            // 
            this.MarkAttButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkAttButton.Location = new System.Drawing.Point(945, 112);
            this.MarkAttButton.Margin = new System.Windows.Forms.Padding(2);
            this.MarkAttButton.Name = "MarkAttButton";
            this.MarkAttButton.Size = new System.Drawing.Size(103, 25);
            this.MarkAttButton.TabIndex = 24;
            this.MarkAttButton.Text = "Mark Attendance";
            this.MarkAttButton.UseVisualStyleBackColor = true;
            this.MarkAttButton.Click += new System.EventHandler(this.MarkAttButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(776, 57);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(63, 44);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ListAllRadioButton
            // 
            this.ListAllRadioButton.AutoSize = true;
            this.ListAllRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAllRadioButton.Location = new System.Drawing.Point(522, 122);
            this.ListAllRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ListAllRadioButton.Name = "ListAllRadioButton";
            this.ListAllRadioButton.Size = new System.Drawing.Size(54, 17);
            this.ListAllRadioButton.TabIndex = 22;
            this.ListAllRadioButton.TabStop = true;
            this.ListAllRadioButton.Text = "List All";
            this.ListAllRadioButton.UseVisualStyleBackColor = true;
            this.ListAllRadioButton.CheckedChanged += new System.EventHandler(this.ListAllRadioButton_CheckedChanged);
            // 
            // Top3RadioButton
            // 
            this.Top3RadioButton.AutoSize = true;
            this.Top3RadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Top3RadioButton.Location = new System.Drawing.Point(440, 122);
            this.Top3RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.Top3RadioButton.Name = "Top3RadioButton";
            this.Top3RadioButton.Size = new System.Drawing.Size(71, 17);
            this.Top3RadioButton.TabIndex = 21;
            this.Top3RadioButton.TabStop = true;
            this.Top3RadioButton.Text = "List Top 3";
            this.Top3RadioButton.UseVisualStyleBackColor = true;
            this.Top3RadioButton.CheckedChanged += new System.EventHandler(this.Top3RadioButton_CheckedChanged);
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.AutoSize = true;
            this.NameRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameRadioButton.Location = new System.Drawing.Point(363, 122);
            this.NameRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new System.Drawing.Size(67, 17);
            this.NameRadioButton.TabIndex = 20;
            this.NameRadioButton.TabStop = true;
            this.NameRadioButton.Text = "By Name";
            this.NameRadioButton.UseVisualStyleBackColor = true;
            // 
            // IDRadioButton
            // 
            this.IDRadioButton.AutoSize = true;
            this.IDRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDRadioButton.Location = new System.Drawing.Point(303, 122);
            this.IDRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.IDRadioButton.Name = "IDRadioButton";
            this.IDRadioButton.Size = new System.Drawing.Size(50, 17);
            this.IDRadioButton.TabIndex = 19;
            this.IDRadioButton.TabStop = true;
            this.IDRadioButton.Text = "By ID";
            this.IDRadioButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(829, 291);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(706, 57);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(57, 44);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(490, 71);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(200, 20);
            this.SearchBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(437, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 15;
            // 
            // EnterRecButton
            // 
            this.EnterRecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterRecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterRecButton.Location = new System.Drawing.Point(17, 289);
            this.EnterRecButton.Margin = new System.Windows.Forms.Padding(2);
            this.EnterRecButton.Name = "EnterRecButton";
            this.EnterRecButton.Size = new System.Drawing.Size(67, 24);
            this.EnterRecButton.TabIndex = 14;
            this.EnterRecButton.Text = "Enter";
            this.EnterRecButton.UseVisualStyleBackColor = true;
            this.EnterRecButton.Click += new System.EventHandler(this.EnterRecButton_Click);
            // 
            // CGPABox
            // 
            this.CGPABox.Location = new System.Drawing.Point(82, 250);
            this.CGPABox.Margin = new System.Windows.Forms.Padding(2);
            this.CGPABox.Name = "CGPABox";
            this.CGPABox.Size = new System.Drawing.Size(146, 20);
            this.CGPABox.TabIndex = 13;
            this.CGPABox.TextChanged += new System.EventHandler(this.CGPABox_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(15, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "CGPA";
            // 
            // DeptBox
            // 
            this.DeptBox.Location = new System.Drawing.Point(82, 222);
            this.DeptBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeptBox.Name = "DeptBox";
            this.DeptBox.Size = new System.Drawing.Size(146, 20);
            this.DeptBox.TabIndex = 11;
            this.DeptBox.TextChanged += new System.EventHandler(this.DeptBox_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Department";
            // 
            // SemBox
            // 
            this.SemBox.Location = new System.Drawing.Point(82, 192);
            this.SemBox.Margin = new System.Windows.Forms.Padding(2);
            this.SemBox.Name = "SemBox";
            this.SemBox.Size = new System.Drawing.Size(146, 20);
            this.SemBox.TabIndex = 9;
            this.SemBox.TextChanged += new System.EventHandler(this.SemBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Semester";
            // 
            // UniBox
            // 
            this.UniBox.Location = new System.Drawing.Point(82, 164);
            this.UniBox.Margin = new System.Windows.Forms.Padding(2);
            this.UniBox.Name = "UniBox";
            this.UniBox.Size = new System.Drawing.Size(146, 20);
            this.UniBox.TabIndex = 7;
            this.UniBox.TextChanged += new System.EventHandler(this.UniBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "University";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(82, 136);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(146, 20);
            this.NameBox.TabIndex = 5;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(82, 109);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(146, 20);
            this.IDBox.TabIndex = 3;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Portal";
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 451);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Portal";
            this.Text = "Portal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EnterRecButton;
        private System.Windows.Forms.TextBox CGPABox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DeptBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SemBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UniBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MarkAttButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RadioButton ListAllRadioButton;
        private System.Windows.Forms.RadioButton Top3RadioButton;
        private System.Windows.Forms.RadioButton NameRadioButton;
        private System.Windows.Forms.RadioButton IDRadioButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}