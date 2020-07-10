using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using MySQL;

namespace DatabaseApp
{
    public partial class StudentManagement : Form
    {
        string sex;
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1DNLKOHN;Initial Catalog=university;Integrated Security=True");
        public StudentManagement()
        {
            InitializeComponent();
            display_data();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (string.IsNullOrEmpty(studentIDbox.Text)) MessageBox.Show("Please Enter a Student ID.");
            else
            {
                if (classIDBox.Text != "CH1801" && classIDBox.Text != "MO18KH01" && classIDBox.Text != "MT18KH01" && classIDBox.Text != "MT18KH02" && classIDBox.Text != "MT18KH03" &&
                classIDBox.Text != "MT18KH04" && classIDBox.Text != "MT18KH05" && classIDBox.Text != "MT18KHTN" && classIDBox.Text != "MT18KT" && classIDBox.Text != "MT18KTTN" &&
                classIDBox.Text != "UD18KH01")
                {
                    con.Close();
                    MessageBox.Show("Please enter the correct existing class ID.");
                }
                else
                {
                    if (deptIDBox.Text.Length > 3 || (deptIDBox.Text != "cse" && deptIDBox.Text != "dce" && deptIDBox.Text != "dch" && deptIDBox.Text != "dee" && deptIDBox.Text != "dte" &&
                    deptIDBox.Text != "enr" && deptIDBox.Text != "fas" && deptIDBox.Text != "fme" && deptIDBox.Text != "fmt" && deptIDBox.Text != "gpe" && deptIDBox.Text != "hea" &&
                    deptIDBox.Text != "iut" && deptIDBox.Text != "sim"))
                    {
                        con.Close();
                        MessageBox.Show("Please enter the correct departmentID.");
                    }
                    else
                    {
                        SqlDataAdapter da = new SqlDataAdapter("Select student_id from student where student_id = '" + studentIDbox.Text + "'", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            con.Close();
                            MessageBox.Show("Student ID already exists.");
                        }
                        else
                        {
                            cmd.CommandText = "Insert into student values ('" + studentIDbox.Text + "','" + fnameBox.Text + "','" + mnameBox.Text + "','" + lnameBox.Text + "','" + sex + "','" + IDNumBox.Text +
                            "','" + nationBox.Text + "','" + startYear.Text + "','" + null + "','" + addressBox.Text + "','" + dateTimePicker1.Value + "','" + deptIDBox.Text + "','" + majorBox.Text + "','" + classIDBox.Text + "')";
                            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                            cmd.ExecuteNonQuery();
                            display_data();
                            con.Close();
                            MessageBox.Show("Succesfully Inserted!");
                        }
                    }
                }
            }
        }
        public void display_data()
        {
            SqlConnection con = DBUtils.GetDBConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student";
            cmd.ExecuteNonQuery();
            DataTable DaTab = new DataTable();
            SqlDataAdapter DaAd = new SqlDataAdapter(cmd);
            DaAd.Fill(DaTab);
            dataGridView1.DataSource = DaTab;
            con.Close();
        }
        private void StudentManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
        private void btnMale_CheckedChanged(object sender, EventArgs e)
        {
            sex = "m";
        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            sex = "f";
        }

        private void studentIDbox_Validating(object sender, CancelEventArgs e)
        {
            if (!studentIDbox.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                studentIDbox.Focus();
                errorProvider1.SetError(studentIDbox, "Please remove characters from here.");
            }
            else
            {
                if (string.IsNullOrEmpty(studentIDbox.Text))
                {
                    e.Cancel = true;
                    studentIDbox.Focus();
                    errorProvider1.SetError(studentIDbox, "Please do not leave this box empty.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(studentIDbox, null);
                }
            }
        }

        private void fnameBox_Validating(object sender, CancelEventArgs e)
        {
            if (fnameBox.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                fnameBox.Focus();
                errorProvider1.SetError(fnameBox, "Please remove numbers from here.");
            }
            else
            {
                if (string.IsNullOrEmpty(fnameBox.Text))
                {
                    e.Cancel = true;
                    fnameBox.Focus();
                    errorProvider1.SetError(fnameBox, "Please do not leave this box empty.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(fnameBox, null);
                }
            }
        }

        private void mnameBox_Validating(object sender, CancelEventArgs e)
        {
            if (mnameBox.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                mnameBox.Focus();
                errorProvider1.SetError(mnameBox, "Please remove numbers from here.");
            }
            else
            {
                    e.Cancel = false;
                    errorProvider1.SetError(mnameBox, null);
            }
        }

        private void lnameBox_Validating(object sender, CancelEventArgs e)
        {
            if (lnameBox.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                lnameBox.Focus();
                errorProvider1.SetError(lnameBox, "Please remove numbers from here.");
            }
            else
            {
                if (string.IsNullOrEmpty(lnameBox.Text))
                {
                    e.Cancel = true;
                    lnameBox.Focus();
                    errorProvider1.SetError(lnameBox, "Please do not leave this box empty.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(lnameBox, null);
                }
            }
        }

        private void nationBox_Validating(object sender, CancelEventArgs e)
        {
            if (nationBox.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                nationBox.Focus();
                errorProvider1.SetError(nationBox, "Please remove numbers from here.");
            }
            else
            {
                if (string.IsNullOrEmpty(nationBox.Text))
                {
                    e.Cancel = true;
                    nationBox.Focus();
                    errorProvider1.SetError(nationBox, "Please do not leave this box empty.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(nationBox, null);
                }
            }
        }

        private void IDNumBox_Validating(object sender, CancelEventArgs e)
        {
            if (!IDNumBox.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                IDNumBox.Focus();
                errorProvider1.SetError(IDNumBox, "Please remove characters from here.");
            }
            else
            {
                if (string.IsNullOrEmpty(IDNumBox.Text))
                {
                    e.Cancel = true;
                    IDNumBox.Focus();
                    errorProvider1.SetError(IDNumBox, "Please do not leave this box empty.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(IDNumBox, null);
                }
            }
        }

        private void startYear_Validating(object sender, CancelEventArgs e)
        {
            if (!startYear.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                startYear.Focus();
                errorProvider1.SetError(startYear, "Please remove characters from here.");
            }
            else
            {
                if (string.IsNullOrEmpty(startYear.Text))
                {
                    e.Cancel = true;
                    startYear.Focus();
                    errorProvider1.SetError(startYear, "Please do not leave this box empty.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(startYear, null);
                }
            }
        }

        private void addressBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(addressBox.Text))
            {
                 e.Cancel = true;
                addressBox.Focus();
                errorProvider1.SetError(addressBox, "Please do not leave this box empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(addressBox, null);
            }
        }

        private void deptIDBox_Validating(object sender, CancelEventArgs e)
        {
            if (deptIDBox.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                deptIDBox.Focus();
                errorProvider1.SetError(deptIDBox, "Please remove numbers from here.");
            }
            else if(deptIDBox.Text.Length > 3||(deptIDBox.Text!= "cse" && deptIDBox.Text != "dce" && deptIDBox.Text != "dch" && deptIDBox.Text != "dee" && deptIDBox.Text != "dte" &&
                deptIDBox.Text != "enr" && deptIDBox.Text != "fas" && deptIDBox.Text != "fme" && deptIDBox.Text != "fmt" && deptIDBox.Text != "gpe" && deptIDBox.Text != "hea" &&
                deptIDBox.Text != "iut" && deptIDBox.Text != "sim"))
            {
                e.Cancel = true;
                deptIDBox.Focus();
                errorProvider1.SetError(deptIDBox, "Please enter the correct format.");
            }
            else
            {
                if (string.IsNullOrEmpty(deptIDBox.Text))
                {
                    e.Cancel = true;
                    deptIDBox.Focus();
                    errorProvider1.SetError(deptIDBox, "Please do not leave this box empty.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(deptIDBox, null);
                }
            }
        }

        private void majorBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider1.SetError(majorBox, null);
        }

        private void classIDBox_Validating(object sender, CancelEventArgs e)
        {
            if (classIDBox.Text != "CH1801" && classIDBox.Text != "MO18KH01" && classIDBox.Text != "MT18KH01" && classIDBox.Text != "MT18KH02" && classIDBox.Text != "MT18KH03" &&
                classIDBox.Text != "MT18KH04" && classIDBox.Text != "MT18KH05" && classIDBox.Text != "MT18KHTN" && classIDBox.Text != "MT18KT" && classIDBox.Text != "MT18KTTN" &&
                classIDBox.Text != "UD18KH01")
            {
                e.Cancel = true;
                classIDBox.Focus();
                errorProvider1.SetError(classIDBox, "Please enter the correct class.");
            }
            else
            {
                if (string.IsNullOrEmpty(classIDBox.Text))
                {
                    e.Cancel = true;
                    classIDBox.Focus();
                    errorProvider1.SetError(classIDBox, "Please do not leave this box empty.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(classIDBox, null);
                }
            }
        }

        private void btnMale_Validating(object sender, CancelEventArgs e)
        {
            if (!btnMale.Checked && !btnFemale.Checked)
            {
                e.Cancel = true;
                btnFemale.Focus();
                errorProvider1.SetError(btnFemale,"Please select the gender");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(btnFemale, null);
            }
        }

        private void btnFemale_Validating(object sender, CancelEventArgs e)
        {
            if (!btnMale.Checked&&!btnFemale.Checked)
            {
                e.Cancel = true;
                btnFemale.Focus();
                errorProvider1.SetError(btnFemale, "Please select the gender");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(btnFemale, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
