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
    public partial class fQLTaiKhoan : Form
    {

        QLTaiKhoan nh = new QLTaiKhoan();
        Boolean themmoi;
        public fQLTaiKhoan()
        {
            InitializeComponent();
        }
        void HienthiTaiKhoan()
        {
            DataTable dt = nh.LayDSTaiKhoan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
              
            }
        }
        void HienthiTK()
        {
            DataTable dt = nh.timkiemTaiKhoan(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        void HienthiTen()
        {
            DataTable dt = nh.timkiemTen(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        void setnull()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtQuyen.Text = "";
            txtHoten.Text = "";
            
        }
        void setButton(bool val)
        {
            spbThem.Enabled = val;
            spbXoa.Enabled = val;
            sbtLamMoi.Enabled = !val;
            spbSua.Enabled = val;
            spBThoat.Enabled = val;
            spbLuu.Enabled = !val;

        }

        void setKhoa(bool val)
        {
            txtTaiKhoan.ReadOnly = val;
            txtMatKhau.ReadOnly = val;
            txtQuyen.ReadOnly = val;
            txtHoten.ReadOnly = val;
        }
        private void fQLTaiKhoan_Load(object sender, EventArgs e)
        {
            HienthiTaiKhoan();
            setnull();
            setButton(true);
            setKhoa(true);
        }

        private void spbThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setnull();
            themmoi = true;
        }
        
        private void spBThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spbSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            themmoi = false;
        }

        private void spbXoa_Click(object sender, EventArgs e)
        {
            if (lsvNV.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nh.XoaTaiKhoan(lsvNV.SelectedItems[0].SubItems[0].Text);
                    lsvNV.Items.RemoveAt(lsvNV.SelectedIndices[0]);
                    setnull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void spbLuu_Click(object sender, EventArgs e)
        {            
            DataTable dt = nh.KTTKTrung(txtTaiKhoan.Text);

            if (themmoi)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng tài khoản");

                }
                else
                {
                    nh.ThemTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, txtHoten.Text, txtQuyen.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nh.CapNhatTaiKhoan(lsvNV.SelectedItems[0].SubItems[0].Text, txtMatKhau.Text, txtHoten.Text, txtQuyen.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            HienthiTaiKhoan();
            setnull();
            setButton(true);
            setKhoa(true);
        }

        private void sbtLamMoi_Click(object sender, EventArgs e)
        {
            setnull();
            setKhoa(true);
            setButton(true);
        }

        private void lsvNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lsvNV.SelectedIndices.Count > 0)
            {
                txtTaiKhoan.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                txtMatKhau.Text = lsvNV.SelectedItems[0].SubItems[1].Text;
                txtHoten.Text = lsvNV.SelectedItems[0].SubItems[2].Text;
                txtQuyen.Text = lsvNV.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void spbTimKiem_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            try
            {
                if ((txtTenhoacMa.Text == "") || (txtTenhoacMa.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        HienthiTK();
                    }
                    if (i == 2)
                    {
                        HienthiTen();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }
        int i = 0;
        private void ceTheoTK_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void ceTheoHoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void spbRS_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            HienthiTaiKhoan();
        }
    }
}
