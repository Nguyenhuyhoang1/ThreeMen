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
    public partial class fPBaoAn : Form
    {
        BaoAn nh = new BaoAn();
        Boolean themmoi;
        public fPBaoAn()
        {
            InitializeComponent();
        }
        void HienthiBaoAn()
        {
            DataTable dt = nh.LayDSBaoAn();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());              
            }
        }
        void HienthiMaNV()
        {
            DataTable dt = nh.LayDSNhanVien();
            cbbMaNV.DataSource = dt;
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";
        }
        void HienthiMaGV()
        {
            DataTable dt = nh.LayDSGiaoVien();
            cbbGV.DataSource = dt;
            cbbGV.DisplayMember = "MaGV";
            cbbGV.ValueMember = "MaGV";
        }
        void HienthiTKBaoAn()
        {
            DataTable dt = nh.timkiemMaBaoAn(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());               
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
            }
        }
        void HienThiTKGV()
        {
            DataTable dt = nh.timkiemMaGV(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        private void spbThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setnull();
            themmoi = true;
        }

        private void fPBaoAn_Load(object sender, EventArgs e)
        {
            HienthiBaoAn();
            HienthiMaNV();
            HienthiMaGV();
            setnull();
            setButton(true);
            setKhoa(true);
        }
        void setnull()
        {
            txtMaPBA.Text = "";
            cbbMaNV.Text = "";
            cbbGV.Text = "";          
            dtpNgayDK.Text = "";
            txtLuatuoi.Text = "";
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
            txtMaPBA.ReadOnly = val;
            txtLuatuoi.ReadOnly = val;
            dtpNgayDK.Enabled = !val;
            cbbGV.Enabled = !val;
            cbbMaNV.Enabled = !val;         
        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNV.SelectedIndices.Count > 0)
            {
                txtMaPBA.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                cbbGV.Text = lsvNV.SelectedItems[0].SubItems[1].Text;
                cbbMaNV.Text = lsvNV.SelectedItems[0].SubItems[2].Text;             
                dtpNgayDK.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[3].Text);
                txtLuatuoi.Text = lsvNV.SelectedItems[0].SubItems[4].Text;

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
                    nh.XoaBaoAnn(lsvNV.SelectedItems[0].SubItems[0].Text);
                    lsvNV.Items.RemoveAt(lsvNV.SelectedIndices[0]);
                    setnull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void spbLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgayDK.Value);
            DataTable dt = nh.KTIDTrung(txtMaPBA.Text);

            if (themmoi)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng mã phiếu báo ăn");

                }
                else
                {
                    nh.ThemBA(txtMaPBA.Text, cbbGV.Text, cbbMaNV.Text, ngay, txtLuatuoi.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nh.CapNhatBA(lsvNV.SelectedItems[0].SubItems[0].Text, cbbGV.Text, cbbMaNV.Text, ngay, txtLuatuoi.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            HienthiBaoAn();
            setnull();
            setButton(true);
            setKhoa(true);
        }
        int i = 0;
        private void ceTheoMaDon_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void ceTheoMaPH_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void ceTheoMaHS_CheckedChanged(object sender, EventArgs e)
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
                        HienthiTKBaoAn();
                    }
                    if (i == 2)
                    {
                        HienthiTKNV();

                    }
                    if (i == 3)
                    {
                        HienThiTKGV();
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
            HienthiBaoAn();
        }

        private void sbtLamMoi_Click(object sender, EventArgs e)
        {
            setnull();
            setKhoa(true);
            setButton(true);
        }

        private void txtLuatuoi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLuatuoi_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
