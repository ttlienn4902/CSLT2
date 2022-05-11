using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ketnoicsdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-OV1HU3M9\\SQLEXPRESS;" + "Initial Catalog=Quanlybanhang;" + "Integrated Security=True";
            try
            {
                con.Open();
                MessageBox.Show("kết nối csdl thành công");
            } 
            catch (Exception ex)
            {
                MessageBox.Show("KET NOI CSDL FAIL" + ex.ToString());
            }
            }
        }
    }

