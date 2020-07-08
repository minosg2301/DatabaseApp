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
    public partial class StudentRecordUpdate : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1DNLKOHN;Initial Catalog=university;Integrated Security=True");
        public StudentRecordUpdate()
        {
            InitializeComponent();
            display_data();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (string.IsNullOrEmpty(studentIDbox.Text)) MessageBox.Show("Please Enter a Student ID.");
            else
            {
                if (string.IsNullOrEmpty(graduateBox.Text))
                {
                    if (string.IsNullOrEmpty(addressBox.Text))
                    {
                        if (string.IsNullOrEmpty(majorBox.Text))
                        {
                            MessageBox.Show("No data to be updated");
                        }
                        else
                        {
                            cmd.CommandText = "Update student set major='" + majorBox.Text + "' where student_id='" + studentIDbox.Text + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Succesfully Updated!");
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(majorBox.Text)) cmd.CommandText = "Update student set address='" + addressBox.Text + "' where student_id='" + studentIDbox.Text + "'";
                        else cmd.CommandText = "Update student set set address='" + addressBox.Text + "', major='" + majorBox.Text + "' where student_id='" + studentIDbox.Text + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Succesfully Updated!");
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(addressBox.Text))
                    {
                        if (string.IsNullOrEmpty(majorBox.Text))
                        {
                            cmd.CommandText = "Update student set graduate_year='" + graduateBox.Text + "' where student_id='" + studentIDbox.Text + "'";
                        }
                        else cmd.CommandText = "Update student set graduate_year='" + graduateBox.Text + "',major='" + majorBox.Text + "' where student_id='" + studentIDbox.Text + "'";
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(majorBox.Text)) cmd.CommandText = "Update student set graduate_year='" + graduateBox.Text + "',address='" + addressBox.Text + "' where student_id='" + studentIDbox.Text + "'";
                        else cmd.CommandText = "Update student set graduate_year='" + graduateBox.Text + "',address='" + addressBox.Text + "', major='" + majorBox.Text + "' where student_id='" + studentIDbox.Text + "'";
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Updated!");
                }
                display_data();
                con.Close();
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

        private void StudentRecordUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
