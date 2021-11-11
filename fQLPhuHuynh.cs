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
    public partial class fQLPhuHuynh : Form
    {
        PhuHuynh nv = new PhuHuynh();
        Boolean themmoi;
        public fQLPhuHuynh()
        {
            InitializeComponent();
        }
        void HienthiPH()
        {
            DataTable dt = nv.LayDSPH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
                lvi.SubItems.Add(dt.Rows[i][9].ToString());
                lvi.SubItems.Add(dt.Rows[i][10].ToString());

            }
        }
        void HienthitimkiemtheoTen()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemTenPH(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
                lvi.SubItems.Add(dt.Rows[i][9].ToString());
                lvi.SubItems.Add(dt.Rows[i][10].ToString());
            }
        }
        void HienthitimkiemtheoMa()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemMaPH(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
                lvi.SubItems.Add(dt.Rows[i][9].ToString());
                lvi.SubItems.Add(dt.Rows[i][10].ToString());
            }
        }
        void setnull()
        {
            txtMaPH.Text = "";
            txtTenPH.Text = "";
            dtpNgaySinh.Text = "";
            txtDanToc.Text = "";
            txtDiaChi.Text = "";
            txtSDT1.Text = "";
            txtSDT2.Text = "";
            txtEmail.Text = "";
            cmbGioiTinh.Text = "";
            txtNgheNghiep.Text = "";
            txtNCongTac.Text = "";


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
            txtMaPH.ReadOnly = val;
            txtTenPH.ReadOnly = val;
            dtpNgaySinh.Enabled = !val;
            cmbGioiTinh.Enabled = !val;
            txtSDT1.ReadOnly = val;
            txtSDT2.ReadOnly = val;
            txtNCongTac.ReadOnly = val;
            txtDiaChi.ReadOnly = val;
            txtEmail.ReadOnly = val;
            txtNgheNghiep.ReadOnly = val;
            txtDanToc.ReadOnly = val;

        }
        private void fQLPhuHuynh_Load(object sender, EventArgs e)
        {
            HienthiPH();
            setnull();
            setKhoa(true);
            setButton(true);
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
                txtMaPH.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                txtTenPH.Text = lsvNV.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[2].Text);
                cmbGioiTinh.Text = (lsvNV.SelectedItems[0].SubItems[3].Text);               
                txtDanToc.Text = lsvNV.SelectedItems[0].SubItems[4].Text;
                txtSDT1.Text = lsvNV.SelectedItems[0].SubItems[5].Text;
                txtSDT2.Text = lsvNV.SelectedItems[0].SubItems[6].Text;
                txtDiaChi.Text = lsvNV.SelectedItems[0].SubItems[7].Text;
                txtNCongTac.Text = lsvNV.SelectedItems[0].SubItems[8].Text;
                txtNgheNghiep.Text = lsvNV.SelectedItems[0].SubItems[9].Text;
                txtEmail.Text = lsvNV.SelectedItems[0].SubItems[10].Text;

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
                        nv.XoaPhuHuynh(lsvNV.SelectedItems[0].SubItems[0].Text);
                        lsvNV.Items.RemoveAt(lsvNV.SelectedIndices[0]);
                        setnull();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa phụ huynh này");

                }

            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");

        }

        private void spbLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            DataTable dt = nv.KTTKTrung(txtMaPH.Text);

            if (themmoi)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng mã phụ huynh");

                }
                else
                {
                    nv.ThemPH(txtMaPH.Text, txtTenPH.Text, ngay, cmbGioiTinh.Text, txtDanToc.Text, txtSDT1.Text, txtSDT2.Text, txtDiaChi.Text, txtNCongTac.Text, txtNgheNghiep.Text,txtEmail.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nv.CapNhatPH(lsvNV.SelectedItems[0].SubItems[0].Text, txtTenPH.Text, ngay, cmbGioiTinh.Text, txtDanToc.Text, txtSDT1.Text, txtSDT1.Text, txtDiaChi.Text, txtNCongTac.Text, txtNgheNghiep.Text, txtEmail.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            HienthiPH();
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

        private void sbtLamMoi_Click(object sender, EventArgs e)
        {
            setnull();
            setKhoa(true);
            setButton(true);
        }

        private void spbRS_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            HienthiPH();
        }

        private void spBThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSDT2_KeyPress(object sender, KeyPressEventArgs e)
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
