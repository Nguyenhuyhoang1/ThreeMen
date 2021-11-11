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
    public partial class fBienLai : Form
    {
        BienLai nh = new BienLai();
        Boolean themmoi;
        public fBienLai()
        {
            InitializeComponent();
        }
        void HienthiBienLai()
        {
            DataTable dt = nh.LayDSBL();
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

            }
        }
        void HienthiMaNV()
        {
            DataTable dt = nh.LayDSNhanVien();
            cbbNV.DataSource = dt;
            cbbNV.DisplayMember = "MaNV";
            cbbNV.ValueMember = "MaNV";
        }
        void HienthiMaPH()
        {
            DataTable dt = nh.LayDSPhuHuynh();
            cbbPH.DataSource = dt;
            cbbPH.DisplayMember = "MaPH";
            cbbPH.ValueMember = "MaPH";
        }
        void HienthiTKBienLai()
        {
            DataTable dt = nh.timkiemMaBL(txtTenhoacMa.Text);
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
            }
        }
        void HienthiTKNV()
        {
            DataTable dt = nh.timkiemMaNV(txtTenhoacMa.Text);
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
            }
        }
        void HienThiTKPH()
        {
            DataTable dt = nh.timkiemMaPhuHuynh(txtTenhoacMa.Text);
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
            }
        }
        void setnull()
        {
            txtMBL.Text = "";
            cbbNV.Text = "";
            cbbPH.Text = "";
            txtHP.Text = "";
            dtpNgaySinh.Text = "";
            txtPhuThu.Text = "";
            txtTienAn.Text = "";
            txtTongTien.Text = "";

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
            txtMBL.ReadOnly = val;
            txtHP.ReadOnly = val;   
            txtPhuThu.ReadOnly = val;
            txtTienAn.ReadOnly = val;
            txtTongTien.ReadOnly = val;
            dtpNgaySinh.Enabled = !val;
            cbbPH.Enabled = !val;
            cbbNV.Enabled = !val;          
        }
        private void spbThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setnull();
            themmoi = true;
        }

        

        private void spbRS_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            HienthiBienLai();
        }

        private void fBienLai_Load(object sender, EventArgs e)
        {
            HienthiBienLai();
            HienthiMaNV();
            HienthiMaPH();          
            setnull();
            setButton(true);
            setKhoa(true);
        }

        private void lsvNV_Click(object sender, EventArgs e)
        {
           
        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNV.SelectedIndices.Count > 0)
            {
                txtMBL.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                cbbNV.Text = lsvNV.SelectedItems[0].SubItems[1].Text;
                cbbPH.Text = lsvNV.SelectedItems[0].SubItems[2].Text;
                dtpNgaySinh.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[3].Text);
                txtHP.Text = lsvNV.SelectedItems[0].SubItems[4].Text;
                txtTienAn.Text = lsvNV.SelectedItems[0].SubItems[5].Text;
                txtPhuThu.Text = lsvNV.SelectedItems[0].SubItems[6].Text;
                txtTongTien.Text = lsvNV.SelectedItems[0].SubItems[7].Text;
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
                if (dr == DialogResult.Yes)
                {
                    nh.XoaBienLai(lsvNV.SelectedItems[0].SubItems[0].Text);
                    lsvNV.Items.RemoveAt(lsvNV.SelectedIndices[0]);
                    setnull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void spbLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            DataTable dt = nh.KTIDTrung(txtMBL.Text);

            if (themmoi)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng mã biên lai");

                }
                else
                {
                    nh.ThemBL(txtMBL.Text, cbbNV.Text, cbbPH.Text, ngay, txtHP.Text, txtTienAn.Text,txtPhuThu.Text,txtTongTien.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nh.CapNhatBienLai(lsvNV.SelectedItems[0].SubItems[0].Text, cbbNV.Text, cbbPH.Text, ngay, txtHP.Text, txtTienAn.Text, txtPhuThu.Text, txtTongTien.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            HienthiBienLai();
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
                        HienthiTKBienLai();
                    }
                    if (i == 2)
                    {
                        HienThiTKPH();

                    }
                    if (i == 3)
                    {
                        HienthiTKNV();
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

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTienAn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPhuThu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
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
