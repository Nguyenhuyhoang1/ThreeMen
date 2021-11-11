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
    public partial class fQLNV : Form
    {
        NhanVien nv = new NhanVien();
        BienLai bien = new BienLai();
        DonNhapHoc don = new DonNhapHoc();
        BaoAn ba = new BaoAn();
        Boolean themmoi;
        public fQLNV()
        {
            InitializeComponent();
        }
        void HienthiNhanVien()
        {
            DataTable dt = nv.LayDSNhanVien();
            for(int i =0; i< dt.Rows.Count; i++)
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

            }
        }
        void Hienthitimkiemtheobophan()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemBoPhanNV(txtTenhoacMa.Text);
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

            }
        }
        void HienthitimkiemtheoTen()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemTenNV(txtTenhoacMa.Text);
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

            }
        }
        void HienthitimkiemtheoMa()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemMaNV(txtTenhoacMa.Text);
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

            }
        }
        private void fQLNV_Load(object sender, EventArgs e)
        {
            
            HienthiNhanVien();
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
            txtMaNV.ReadOnly = val;
            txtTenNV.ReadOnly = val;
            dtpNgaySinh.Enabled = !val;
            cmbGioiTinh.Enabled = !val;
            txtTrinhDo.ReadOnly = val;
            txtBoPhan.ReadOnly = val;
            txtSDT.ReadOnly = val;
            txtDiaChi.ReadOnly = val;
            txtEmail.ReadOnly = val;
            
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
            if(lsvNV.SelectedIndices.Count >0)
            {
                txtMaNV.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                txtTenNV.Text = lsvNV.SelectedItems[0].SubItems[1].Text;
                cmbGioiTinh.SelectedIndex = cmbGioiTinh.FindString(lsvNV.SelectedItems[0].SubItems[2].Text);
                dtpNgaySinh.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[3].Text);
                txtBoPhan.Text = lsvNV.SelectedItems[0].SubItems[4].Text;
                txtTrinhDo.Text = lsvNV.SelectedItems[0].SubItems[5].Text;
                txtDiaChi.Text = lsvNV.SelectedItems[0].SubItems[6].Text;
                txtEmail.Text = lsvNV.SelectedItems[0].SubItems[7].Text;
                txtSDT.Text = lsvNV.SelectedItems[0].SubItems[8].Text;                             
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
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            
            
                if (lsvNV.SelectedItems.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (dr == DialogResult.Yes)
                    {   
                        
                        ba.XoaBaoAnCu(lsvNV.SelectedItems[0].SubItems[0].Text);
                        bien.XoaBienLaiCu(lsvNV.SelectedItems[0].SubItems[0].Text);
                        don.XoaHoaDonCu(lsvNV.SelectedItems[0].SubItems[0].Text);
                        nv.ThemNVCu(txtMaNV.Text, txtTenNV.Text, cmbGioiTinh.Text, ngay, txtBoPhan.Text, txtTrinhDo.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text);
                        nv.XoaNhanVien(lsvNV.SelectedItems[0].SubItems[0].Text);
                        lsvNV.Items.RemoveAt(lsvNV.SelectedIndices[0]);
                        setnull();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa nhân viên đang làm việc");
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
                        MessageBox.Show("Trùng mã nhân viên");

                    }
                    else
                    {
                        nv.ThemNV(txtMaNV.Text, txtTenNV.Text, cmbGioiTinh.Text, ngay, txtBoPhan.Text, txtTrinhDo.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text);
                        MessageBox.Show("Thêm mới thành công");
                    }                   
                }
                else
                {
                    nv.CapNhatNV(lsvNV.SelectedItems[0].SubItems[0].Text, txtTenNV.Text, cmbGioiTinh.Text, ngay, txtBoPhan.Text, txtTrinhDo.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text);
                    MessageBox.Show("Cập nhật thành công");
                }
                lsvNV.Items.Clear();
                HienthiNhanVien();
                setnull();
                setButton(true);
                setKhoa(true);                        
        }

        private void spbTimKiem_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            try
            {
                if ((txtTenhoacMa.Text == "") || (txtTenhoacMa.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                        Hienthitimkiemtheobophan();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }

        }
        int i = 0;      
        private void txtTenhoacMa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void spbLamMoi_Click(object sender, EventArgs e)
        {
            lsvNV.Items.Clear();
            HienthiNhanVien();
        }

        private void ceTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void ceTheoBoPhan_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }        
        private void ceTheoMa_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

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
