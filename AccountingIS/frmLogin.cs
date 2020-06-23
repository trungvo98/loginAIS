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
namespace AccountingIS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string query = "select * from tb_login where usernam='" + txtUsername.Text.Trim() + "'and password='" + txtPassword.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                Form1 ob = new Form1();
                this.Hide();
                ob.Show();
            }
            else
            {
                MessageBox.Show("Username or Password invalid");
            }
        }
    }
}
