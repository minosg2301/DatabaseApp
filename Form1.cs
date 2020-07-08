using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySQL;
namespace DatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StudentManagement SMF = new StudentManagement();
            this.Hide();
            SMF.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentRecordUpdate SMF = new StudentRecordUpdate();
            this.Hide();
            SMF.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentRecordDelete SMF = new StudentRecordDelete();
            this.Hide();
            SMF.ShowDialog();
        }
    }
}
