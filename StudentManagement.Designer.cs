namespace DatabaseApp
{
    partial class StudentManagement
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDbox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.mnameBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.nationBox = new System.Windows.Forms.TextBox();
            this.IDNumBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.startYear = new System.Windows.Forms.TextBox();
            this.deptIDBox = new System.Windows.Forms.TextBox();
            this.classIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.majorBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(539, 533);
            this.dataGridView1.TabIndex = 14;
            // 
            // studentIDbox
            // 
            this.studentIDbox.Location = new System.Drawing.Point(154, 29);
            this.studentIDbox.Name = "studentIDbox";
            this.studentIDbox.Size = new System.Drawing.Size(263, 22);
            this.studentIDbox.TabIndex = 0;
            this.studentIDbox.Validating += new System.ComponentModel.CancelEventHandler(this.studentIDbox_Validating);
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(154, 69);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(263, 22);
            this.fnameBox.TabIndex = 1;
            this.fnameBox.Validating += new System.ComponentModel.CancelEventHandler(this.fnameBox_Validating);
            // 
            // mnameBox
            // 
            this.mnameBox.Location = new System.Drawing.Point(154, 108);
            this.mnameBox.Name = "mnameBox";
            this.mnameBox.Size = new System.Drawing.Size(263, 22);
            this.mnameBox.TabIndex = 2;
            this.mnameBox.Validating += new System.ComponentModel.CancelEventHandler(this.mnameBox_Validating);
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(154, 145);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(263, 22);
            this.lnameBox.TabIndex = 3;
            this.lnameBox.Validating += new System.ComponentModel.CancelEventHandler(this.lnameBox_Validating);
            // 
            // nationBox
            // 
            this.nationBox.Location = new System.Drawing.Point(154, 224);
            this.nationBox.Name = "nationBox";
            this.nationBox.Size = new System.Drawing.Size(263, 22);
            this.nationBox.TabIndex = 6;
            this.nationBox.Validating += new System.ComponentModel.CancelEventHandler(this.nationBox_Validating);
            // 
            // IDNumBox
            // 
            this.IDNumBox.Location = new System.Drawing.Point(154, 264);
            this.IDNumBox.Name = "IDNumBox";
            this.IDNumBox.Size = new System.Drawing.Size(263, 22);
            this.IDNumBox.TabIndex = 7;
            this.IDNumBox.Validating += new System.ComponentModel.CancelEventHandler(this.IDNumBox_Validating);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(154, 345);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(263, 22);
            this.addressBox.TabIndex = 9;
            this.addressBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressBox_Validating);
            // 
            // startYear
            // 
            this.startYear.Location = new System.Drawing.Point(154, 305);
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(263, 22);
            this.startYear.TabIndex = 8;
            this.startYear.Validating += new System.ComponentModel.CancelEventHandler(this.startYear_Validating);
            // 
            // deptIDBox
            // 
            this.deptIDBox.Location = new System.Drawing.Point(154, 422);
            this.deptIDBox.Name = "deptIDBox";
            this.deptIDBox.Size = new System.Drawing.Size(263, 22);
            this.deptIDBox.TabIndex = 11;
            this.deptIDBox.Validating += new System.ComponentModel.CancelEventHandler(this.deptIDBox_Validating);
            // 
            // classIDBox
            // 
            this.classIDBox.Location = new System.Drawing.Point(154, 493);
            this.classIDBox.Name = "classIDBox";
            this.classIDBox.Size = new System.Drawing.Size(263, 22);
            this.classIDBox.TabIndex = 13;
            this.classIDBox.Validating += new System.ComponentModel.CancelEventHandler(this.classIDBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nationality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Start Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Date of Birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Department ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "ClassID";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(319, 522);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 23);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
            this.btnMale.Location = new System.Drawing.Point(154, 183);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(59, 21);
            this.btnMale.TabIndex = 4;
            this.btnMale.TabStop = true;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.CheckedChanged += new System.EventHandler(this.btnMale_CheckedChanged);
            this.btnMale.Validating += new System.ComponentModel.CancelEventHandler(this.btnMale_Validating);
            // 
            // btnFemale
            // 
            this.btnFemale.AutoSize = true;
            this.btnFemale.Location = new System.Drawing.Point(282, 183);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(75, 21);
            this.btnFemale.TabIndex = 5;
            this.btnFemale.TabStop = true;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.CheckedChanged += new System.EventHandler(this.btnFemale_CheckedChanged);
            this.btnFemale.Validating += new System.ComponentModel.CancelEventHandler(this.btnFemale_Validating);
            // 
            // majorBox
            // 
            this.majorBox.Location = new System.Drawing.Point(154, 458);
            this.majorBox.Name = "majorBox";
            this.majorBox.Size = new System.Drawing.Size(263, 22);
            this.majorBox.TabIndex = 12;
            this.majorBox.Validating += new System.ComponentModel.CancelEventHandler(this.majorBox_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Major";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 383);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 557);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.majorBox);
            this.Controls.Add(this.btnFemale);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classIDBox);
            this.Controls.Add(this.deptIDBox);
            this.Controls.Add(this.startYear);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.IDNumBox);
            this.Controls.Add(this.nationBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.mnameBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.studentIDbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentManagement";
            this.Text = "StudentManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentManagement_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox studentIDbox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox mnameBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox nationBox;
        private System.Windows.Forms.TextBox IDNumBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox startYear;
        private System.Windows.Forms.TextBox deptIDBox;
        private System.Windows.Forms.TextBox classIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.TextBox majorBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}