using DevExpress.XtraEditors;
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
using System.Data;
using System.Web.UI.Design;
using System.Media;
namespace WindowsFormsApp1
{
    
    public partial class fDangNhap : DevExpress.XtraEditors.XtraForm
    {
        
        public static string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ThongTinMN;Integrated Security=True";
        public static string quyen = "NV";
        public fDangNhap()
        {
            InitializeComponent();          
        }    
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }                   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbUserName.Text != null && txbUserName.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin tài khoản");
                    txbUserName.Focus();
                    return;
                }
                if (txtMatKhau.Text != null && txtMatKhau.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin mật khẩu");
                    txbUserName.Focus();
                    return;
                }
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string TenDN = txbUserName.Text.Trim();
                string Matkhau = txtMatKhau.Text.Trim();
                string query = "select * from tbUser where UserName = '" + TenDN + "' and Pass = '" + Matkhau + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    quyen = ds.Tables[0].Rows[0]["Quyen"].ToString();
                    fMenu f = new fMenu(quyen);                    
                    f.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu sai");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu sai");
            }
        }
                    

        private void fDangNhap_Load_1(object sender, EventArgs e)
        {
           
        }
              
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == false)
            {
                
                txtMatKhau.UseSystemPasswordChar =true;
            }
            else
            {               
                txtMatKhau.UseSystemPasswordChar = false;               
            }
              

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbUserName_Enter(object sender, EventArgs e)
        {
            if(txbUserName.Text =="Tài khoản")
            {
                txbUserName.Text = "";
                txbUserName.ForeColor = Color.Black;
            }    
        }

        private void txbUserName_Leave(object sender, EventArgs e)
        {
            if (txbUserName.Text == "")
            {
                txbUserName.Text = "Tài khoản";
                txbUserName.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}