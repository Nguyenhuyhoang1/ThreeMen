using DevExpress.XtraBars;
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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class fMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        GiaoVien nv = new GiaoVien();
        NhanVien nhanvien = new NhanVien();
        CanBoYTe cb = new CanBoYTe();
        HocSinh hs = new HocSinh();
        PhuHuynh ph = new PhuHuynh();
        PhieuKham kham = new PhieuKham();
        PDiemDanh dd = new PDiemDanh();
        BienLai bien = new BienLai();
        BaoAn ba = new BaoAn();
        DonNhapHoc don = new DonNhapHoc();

        public bool isThoat = true;
        public fMenu(string quyen)
        {
            InitializeComponent();
            if(quyen == "NVVP")
            {
              
            }
            else
            {
                if (quyen == "GV")
                {
                    //He thong                
                    bbtQLTaiKhoan.Enabled = false;

                    //Quan Ly
                    bbtQLNV.Enabled = false;
                    bbtQLGV.Enabled = true;
                    bbtQlHS.Enabled = true;
                    bbtQLPH.Enabled = true;
                    bbtQLYT.Enabled = false;
                    //QL nghiep vu
                    bbtLop.Enabled = true;
                    bttKham.Enabled = false;
                    bbtDiemDanh.Enabled = true;
                    bbtBaoAn.Enabled = false;
                    bbtTKHoaDn.Enabled = false;
                    bbtBienLai.Enabled = false;                   
                }
                if (quyen == "CBYT")
                {
                    //He thong                
                    bbtQLTaiKhoan.Enabled = false;

                    //Quan Ly
                    bbtQLNV.Enabled = false;
                    bbtQLGV.Enabled = false;
                    bbtQlHS.Enabled = true;
                    bbtQLPH.Enabled = true;
                    bbtQLYT.Enabled = true;

                    //QL nghiep vu
                    bbtLop.Enabled = true;
                    bttKham.Enabled = true;
                    bbtDiemDanh.Enabled = false;
                    bbtBaoAn.Enabled = false;
                    bbtTKHoaDn.Enabled = false;
                    bbtBienLai.Enabled = false;
                }                
            }                      
        }     
      
        private void bbtDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }        
        private void bbtQLNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }     
        private void bbtDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
     
        private void bbtDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
                               
        }
        private void fMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void fMenu_Load_1(object sender, EventArgs e)
        {
            HienthiNVCU();
            HienthiGiaoVienCU();
            HienthiBienLaiCu();
            HienthiBaoAnCu();
            HienthiPhieuDD();
        }

        private void bbtQLGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bbtQLPH_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        private void bbtTKHoaDn_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void bbtQLTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bbtQlHS_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void bbtQLYT_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
        private void bbtLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bbtBienLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bbtBaoAn_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void bbtDiemDanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bttKham_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
        void HienthiGiaoVienCU()
        {
            DataTable dt = nv.LayDSGiaoVienCU();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lvGVC.Items.Add(dt.Rows[i][0].ToString());
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
        void HienthiNVCU()
        {
            DataTable dt = nhanvien.LayDSNhanVienCU();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
               lsvNVcu.Items.Add(dt.Rows[i][0].ToString());
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
        void HienthiBienLaiCu()
        {
            DataTable dt = bien.LayDSBLCu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
               lvBienLai.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());

            }
        }
        void HienthiBaoAnCu()
        {
            DataTable dt = ba.LayDSBaoAnCu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
               lvBaoAn.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                          
            }
        }
        void HienthiDonNhaphocCu()
        {
            DataTable dt = don.LayDSHoaDonCu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
               lvNhapHoc.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());              

            }
        }
        void HienthiPhieuDD()
        {
            DataTable dt = dd.LayDSPDDCu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
               lvDD.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }
        }
        private void backstageViewTabItem2_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            lvGVC.Items.Clear();
            HienthiGiaoVienCU();
        }

        void HienthitimkiemtheoTen()
        {
            lvGVC.Items.Clear();
            DataTable dt = nv.timkiemTenGVCu(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lvGVC.Items.Add(dt.Rows[i][0].ToString());
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
        void HienthitimkiemtheoTenNV()
        {
            lsvNVcu.Items.Clear();
            DataTable dt = nhanvien.timkiemTenNVCu(txttennv.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNVcu.Items.Add(dt.Rows[i][0].ToString());
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
        void HienthiTKMaBA()
        {
            lvBaoAn.Items.Clear();
            DataTable dt = ba.timkiemMaBaoAnCu(txtNMBA.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lvBaoAn.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        void HienthiTKMaBL()
        {
            lvBienLai.Items.Clear();
            DataTable dt = bien.timkiemMaBLCu(txtmaBL.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lvBienLai.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }
        void HienthiTKMaNH()
        {
            lvNhapHoc.Items.Clear();
            DataTable dt = don.timkiemMaDonCu(txtNMnH.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lvNhapHoc.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        private void spbXoa_Click_1(object sender, EventArgs e)
        {
            if (lvGVC.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaGiaoVienCu(lvGVC.SelectedItems[0].SubItems[0].Text);                    
                    lvGVC.Items.RemoveAt(lvGVC.SelectedIndices[0]);                  
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void spbRS_Click_1(object sender, EventArgs e)
        {
            lvGVC.Items.Clear();
            HienthiGiaoVienCU();
        }

        private void sbtLamMoi_Click(object sender, EventArgs e)
        {
            lvGVC.Items.Clear();
            HienthiGiaoVienCU();
        }

        private void spbTimKiem_Click_1(object sender, EventArgs e)
        {
            lvGVC.Items.Clear();
            try
            {
                if ((txtTenhoacMa.Text == "") || (txtTenhoacMa.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    HienthitimkiemtheoTen();

                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }      
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (lsvNVcu.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nhanvien.XoaNhanVienCu(lsvNVcu.SelectedItems[0].SubItems[0].Text);
                    lsvNVcu.Items.RemoveAt(lsvNVcu.SelectedIndices[0]);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            lsvNVcu.Items.Clear();
            try
            {
                if ((txttennv.Text == "") || (txttennv.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                   HienthitimkiemtheoTenNV();

                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            lsvNVcu.Items.Clear();
            HienthiNVCU();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lsvNVcu.Items.Clear();
            HienthiNVCU();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            

        }
           
        private int hinh = 1;
        private void loadHinh()
        {           
            if(hinh == 6)
            {
                hinh = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"hinhanh\{0}.jpg", hinh);
            hinh++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadHinh();
        }   
        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            fReportBL f = new fReportBL();
            f.Show();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            lvBienLai.Items.Clear();
            HienthiBienLaiCu();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            lvBaoAn.Items.Clear();
            HienthiBaoAnCu();
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            lvNhapHoc.Items.Clear();
            HienthiDonNhaphocCu();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (lvBaoAn.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ba.XoabangBaoAnnCu(lvBaoAn.SelectedItems[0].SubItems[0].Text);
                    lvBaoAn.Items.RemoveAt(lvBaoAn.SelectedIndices[0]);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            if (lvNhapHoc.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    don.XoabangHoaDonCu(lvNhapHoc.SelectedItems[0].SubItems[0].Text);
                    lvNhapHoc.Items.RemoveAt(lvNhapHoc.SelectedIndices[0]);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            if (lvBienLai.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bien.XoaBangBienLaiCu(lvBienLai.SelectedItems[0].SubItems[0].Text);
                    lvBienLai.Items.RemoveAt(lvBienLai.SelectedIndices[0]);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            lvBaoAn.Items.Clear();
            try
            {
                if ((txtNMBA.Text == "") || (txtNMBA.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    HienthiTKMaBA();

                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            lvNhapHoc.Items.Clear();
            try
            {
                if ((txtNMnH.Text == "") || (txtNMnH.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    HienthiTKMaNH();

                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            lvBienLai.Items.Clear();
            try
            {
                if ((txtmaBL.Text == "") || (txtmaBL.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    HienthiTKMaBL();

                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            lvBaoAn.Items.Clear();
            HienthiBaoAnCu();
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            lvBienLai.Items.Clear();
            HienthiBienLaiCu();
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            lvNhapHoc.Items.Clear();
            HienthiDonNhaphocCu();
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            lvDD.Items.Clear();
            HienthiPhieuDD();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bbtThongTintruong_ItemClick(object sender, ItemClickEventArgs e)
        {
            fGTtruong f = new fGTtruong();
            f.Show();
        }

        private void bbtDoiMatK_ItemClick(object sender, ItemClickEventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau();
            f.ShowDialog();
        }

        private void bbtDX_ItemClick(object sender, ItemClickEventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
            this.Hide();
        }

        private void bttQLTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            fQLTaiKhoan f = new fQLTaiKhoan();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void bbtHoTro_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100006113355309");
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            fQLNV f = new fQLNV();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            fGiaoVien f = new fGiaoVien();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            fQLPhuHuynh f = new fQLPhuHuynh();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            fQLHocSinh f = new fQLHocSinh();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            fQLYT f = new fQLYT();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            fQLLop f = new fQLLop();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            fBienLai f = new fBienLai();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLDNhapHoc f = new QLDNhapHoc();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            fPBaoAn f = new fPBaoAn();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            fPhieuDD f = new fPhieuDD();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            fPKham f = new fPKham();
            tabHienThi.Show();
            tabHienThi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            tabHienThi.Controls.Add(f);
            f.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            fReportNV f = new fReportNV();
            f.Show();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            fReportGV f = new fReportGV();
            f.Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            fReportCBYT f = new fReportCBYT();
            f.Show();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            fReportHS f = new fReportHS();
            f.Show();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            fReportPNH f = new fReportPNH();
            f.Show();
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            fReportBL f = new fReportBL();
                f.Show();
        }
    }
}