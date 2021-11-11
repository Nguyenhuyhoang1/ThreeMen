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
    public partial class fQLHocSinh : Form
    {
        HocSinh nv = new HocSinh();
        Boolean themmoi;
        public fQLHocSinh()
        {
            InitializeComponent();
        }
        void Hienthihocsinh()
        {
            DataTable dt = nv.LayDSHocsinh();
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
            }
        }
        void HienthiMaPH()
        {
            DataTable dt = nv.LayDSPhuHuynh();
            cbbMaPH.DataSource = dt;
            cbbMaPH.DisplayMember = "MaPH";
            cbbMaPH.ValueMember = "MaPH";
        }
        void HienthiLop()
        {
            DataTable dt = nv.LayDSLop();
            cbbTenLop.DataSource = dt;
            cbbTenLop.DisplayMember = "TenLop";
            cbbTenLop.ValueMember = "MaLop";
        }
        void HienthitimkiemtheoTen()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemTenHS(txtTenhoacMa.Text);
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
            }
        }
        void HienthitimkiemtheoMa()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemMaHS(txtTenhoacMa.Text);
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
            }
        }
        void HienthitimkiemtheoMaPH()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemMaPhuHuynh(txtTenhoacMa.Text);
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
            }
        }
        private void spbThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setnull();
            themmoi = true;
        }

        private void fQLHocSinh_Load(object sender, EventArgs e)
        {
            Hienthihocsinh();
            HienthiMaPH();
            HienthiLop();
            setnull();
            setKhoa(true);
            setButton(true);
        }
        void setnull()
        {
            txtMaNV.Text = "";
            txtTenHS.Text = "";
            dtpNgaySinh.Text = "";
            cbbMaPH.Text = "";
            cbbMaPH.Text = "";
            cbbTenLop.Text = "";
            txtGhichu.Text = "";

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
            txtTenHS.ReadOnly = val;
            dtpNgaySinh.Enabled = !val;
            cmbGioiTinh.Enabled = !val;
            cbbMaPH.Enabled = !val;          
            cbbTenLop.Enabled = !val;
            txtGhichu.ReadOnly = val;

        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNV.SelectedIndices.Count > 0)
            {

                txtMaNV.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                cbbMaPH.Text = (lsvNV.SelectedItems[0].SubItems[1].Text);
                txtTenHS.Text = lsvNV.SelectedItems[0].SubItems[2].Text;
                cbbTenLop.Text = (lsvNV.SelectedItems[0].SubItems[3].Text);
                dtpNgaySinh.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[4].Text);
                cmbGioiTinh.SelectedIndex = cmbGioiTinh.FindString(lsvNV.SelectedItems[0].SubItems[5].Text);                
                txtGhichu.Text = lsvNV.SelectedItems[0].SubItems[6].Text;

            }
        }

        private void spbSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            themmoi = false;
        }

        private void spBThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        nv.XoaHocSinh(lsvNV.SelectedItems[0].SubItems[0].Text);
                        lsvNV.Items.RemoveAt(lsvNV.SelectedIndices[0]);
                        setnull();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa học sinh đang học");

                }

            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void spbLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            DataTable dt = nv.KTIDTrung(txtMaNV.Text);

            if (themmoi)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng mã học sinh");

                }
                else
                {
                    nv.ThemHocSinh(txtMaNV.Text, cbbMaPH.Text, txtTenHS.Text, cbbTenLop.SelectedValue.ToString(), ngay, cmbGioiTinh.Text, txtGhichu.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nv.CapNhatHocSinh(lsvNV.SelectedItems[0].SubItems[0].Text, cbbMaPH.Text, txtTenHS.Text, cbbTenLop.SelectedValue.ToString(), ngay, cmbGioiTinh.Text, txtGhichu.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            Hienthihocsinh();
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
        int i = 0;
        private void ceTheoMa_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void ceTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void ceTheoBoPhan_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
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
                    if (i == 3)
                    {
                        HienthitimkiemtheoMaPH();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }

        }

        private void spbRS_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            Hienthihocsinh();
        }
    }
}
