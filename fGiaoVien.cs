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
    public partial class fGiaoVien : Form
    {
        PDiemDanh dd = new PDiemDanh();
        BaoAn ba = new BaoAn();
        GiaoVien nv = new GiaoVien();
        Boolean themmoi;
        public fGiaoVien()
        {
            InitializeComponent();
        }
        void HienthiGiaoVien()
        {
            DataTable dt = nv.LayDSGiaoVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                String.Format("{0:dd/MM/yyyy}", lvi.SubItems.Add(dt.Rows[i][3].ToString()));
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());

            }
        }
        void HienthitimkiemtheoTen()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemTenGV(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                String.Format("{0:dd/MM/yyyy}", lvi.SubItems.Add(dt.Rows[i][3].ToString()));
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());

            }
        }
        void HienthitimkiemtheoMa()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemMaGV(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                String.Format("{0:dd/MM/yyyy}", lvi.SubItems.Add(dt.Rows[i][3].ToString()));
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());

            }
        }
        private void spbThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setnull();
            themmoi = true;
        }
        
        void setnull()
        {
            txtMaGV.Text = "";
            txtTenNV.Text = "";
            dtpNgaySinh.Text = "";
            txtTrinhDo.Text = "";
            txtBoPhan.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";

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
            txtMaGV.ReadOnly = val;
            txtTenNV.ReadOnly = val;
            dtpNgaySinh.Enabled = !val;
            cmbGioiTinh.Enabled = !val;
            txtTrinhDo.ReadOnly = val;
            txtBoPhan.ReadOnly = val;
            txtSDT.ReadOnly = val;
            txtDiaChi.ReadOnly = val;
            txtEmail.ReadOnly = val;

        }
        private void fGiaoVien_Load(object sender, EventArgs e)
        {
            HienthiGiaoVien();
            setnull();
            setKhoa(true);
            setButton(true);
        }

        private void spbXoa_Click(object sender, EventArgs e)
        {

            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            if (lsvNV.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (dr == DialogResult.Yes)
                    {                      
                        dd.XoaPhieuDDGVCu(lsvNV.SelectedItems[0].SubItems[0].Text);
                        ba.XoaBaoAnGVCu(lsvNV.SelectedItems[0].SubItems[0].Text);
                        nv.XoaGiaoVien(lsvNV.SelectedItems[0].SubItems[0].Text);
                        nv.ThemGVCU(txtMaGV.Text, txtTenNV.Text, cmbGioiTinh.Text, ngay, txtSDT.Text, txtTrinhDo.Text, txtBoPhan.Text, txtDiaChi.Text, txtEmail.Text);
                        lsvNV.Items.RemoveAt(lsvNV.SelectedIndices[0]);
                        setnull();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa giáo viên đang làm việc");
                }
                
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void spbLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            DataTable dt = nv.KTIDTrung(txtMaGV.Text);

            if (themmoi)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng mã giáo viên");

                }
                else
                {
                    nv.ThemGV(txtMaGV.Text, txtTenNV.Text, cmbGioiTinh.Text, ngay, txtSDT.Text, txtTrinhDo.Text, txtBoPhan.Text, txtDiaChi.Text, txtEmail.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nv.CapNhatGV(lsvNV.SelectedItems[0].SubItems[0].Text, txtTenNV.Text, cmbGioiTinh.Text, ngay, txtSDT.Text, txtTrinhDo.Text, txtBoPhan.Text, txtDiaChi.Text, txtEmail.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            HienthiGiaoVien();
            setnull();
            setButton(true);
            setKhoa(true);
        }

        private void spbSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            themmoi = false;
        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNV.SelectedIndices.Count > 0)
            {
                txtMaGV.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                txtTenNV.Text = lsvNV.SelectedItems[0].SubItems[1].Text;
                cmbGioiTinh.SelectedIndex = cmbGioiTinh.FindString(lsvNV.SelectedItems[0].SubItems[2].Text);
                dtpNgaySinh.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[3].Text);
                txtSDT.Text = lsvNV.SelectedItems[0].SubItems[4].Text;
                txtTrinhDo.Text = lsvNV.SelectedItems[0].SubItems[5].Text;
                txtBoPhan.Text = lsvNV.SelectedItems[0].SubItems[6].Text;
                txtDiaChi.Text = lsvNV.SelectedItems[0].SubItems[7].Text;
                txtEmail.Text = lsvNV.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void spbRS_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            HienthiGiaoVien();
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
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
