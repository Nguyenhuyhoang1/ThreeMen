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

namespace WindowsFormsApp1
{
    public partial class fDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        database db = new database();
        public fDoiMatKhau()
        {
            InitializeComponent();
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            string update = "update tbuser set Pass='" + txtNhapMKmoi.Text + "' where(UserName=N'" + txtTDNhap.Text + "' and Pass='" + txtNMKcu.Text + "')";
            string ten = txtTDNhap.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtNMKcu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtNhapMKmoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtNhaplaiMK.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (txtNhapMKmoi.Text == txtNhaplaiMK.Text)
                            {
                                db.ExecuteNonQuery(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void bbtNhaplai_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.panel3.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btThoatDoiMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}