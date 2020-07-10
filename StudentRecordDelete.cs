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
    public partial class StudentRecordDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1DNLKOHN;Initial Catalog=university;Integrated Security=True");
        public StudentRecordDelete()
        {
            InitializeComponent();
            display_data();
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

        private void StudentRecordDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentIDbox.Text)) MessageBox.Show("Please Enter a Student ID.");
            else
            {
                if (MessageBox.Show("Are you sure about this decision?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from student where student_id = '" + studentIDbox.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display_data();
                    MessageBox.Show("Succesfully Deleted!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
