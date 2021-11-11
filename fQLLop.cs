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
    public partial class fQLLop : Form
    {
        Lop nv = new Lop();
        Boolean themmoi;
        public fQLLop()
        {
            InitializeComponent();
        }
        void HienthiLop()
        {
            DataTable dt = nv.LayDSLop();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
               
            }
        }
        void HienthitimkiemtheoMa()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemMaLop(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        void HienthitimkiemtheoTen()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemTenLop(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());               
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
                        HienthitimkiemtheoMa();
                    }
                    if (i == 2)
                    {
                        HienthitimkiemtheoTen();
                    }                    
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }

        }

        private void fQLLop_Load(object sender, EventArgs e)
        {
            HienthiLop();
            setnull();
            setKhoa(true);
            setButton(true);
        }

        private void spBThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtLamMoi_Click(object sender, EventArgs e)
        {
            setnull();
            setKhoa(true);
            setButton(true);
        }
        void setnull()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtNamHoc.Text = "";
            txtSoLuong.Text = "";
            

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
            txtMaNV.ReadOnly = val;
            txtTenNV.ReadOnly = val;
            txtNamHoc.ReadOnly = val;
            txtSoLuong.ReadOnly = val;
           

        }

        private void spbThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setnull();
            themmoi = true;
        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNV.SelectedIndices.Count > 0)
            {
                txtMaNV.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                txtTenNV.Text = lsvNV.SelectedItems[0].SubItems[1].Text;               
                txtSoLuong.Text = lsvNV.SelectedItems[0].SubItems[2].Text;
                txtNamHoc.Text = lsvNV.SelectedItems[0].SubItems[3].Text;
               
            }
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
                try
                {
                    if (dr == DialogResult.Yes)
                    {
                        nv.XoaLop(lsvNV.SelectedItems[0].SubItems[0].Text);
                        lsvNV.Items.RemoveAt(lsvNV.SelectedIndices[0]);
                        setnull();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa lớp này");

                }

            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");

        }

        private void spbLuu_Click(object sender, EventArgs e)
        {           
            DataTable dt = nv.KTIDTrung(txtMaNV.Text);

            if (themmoi)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng mã lớp");

                }
                else
                {
                    nv.ThemLop(txtMaNV.Text, txtTenNV.Text, txtSoLuong.Text,  txtNamHoc.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nv.CapNhatLop(lsvNV.SelectedItems[0].SubItems[0].Text, txtTenNV.Text, txtSoLuong.Text, txtNamHoc.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            HienthiLop();
            setnull();
            setButton(true);
            setKhoa(true);
        }
        int i = 0;
        private void ceTheoMa_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void ceTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void spbRS_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            HienthiLop();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
