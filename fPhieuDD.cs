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
    public partial class fPhieuDD : Form
    {
        PDiemDanh nh = new PDiemDanh();
        Boolean themmoi;
        public fPhieuDD()
        {
            InitializeComponent();
        }
        void HienthiPhieuDiemDanh()
        {
            DataTable dt = nh.LayDSPDD();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }
        }
        void HienthiMaGV()
        {
            DataTable dt = nh.LayDSGV();
            cbbGV.DataSource = dt;
            cbbGV.DisplayMember = "MaGV";
            cbbGV.ValueMember = "MaGV";
        }
        void HienthiMaHS()
        {
            DataTable dt = nh.LayDSHS();
            cbbMaHS.DataSource = dt;
            cbbMaHS.DisplayMember = "MaHS";
            cbbMaHS.ValueMember = "MaHS";
        }
        void HienthiTKDD()
        {
            DataTable dt = nh.timkiemMaDD(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }
        }
        void HienthiTKGV()
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
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }
        }
        void HienThiTKHS()
        {
            DataTable dt = nh.timkiemHS(txtTenhoacMa.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

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
            txtMaPBA.Text = "";
            cbbGV.Text = "";
            cbbMaHS.Text = "";
            dtpNgayDK.Text = "";
            txtTinhTrangVang.Text = "";
            txtXuatAn.Text = "";

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
            txtTinhTrangVang.ReadOnly = val;
            txtXuatAn.ReadOnly = val;
            dtpNgayDK.Enabled = !val;
            cbbGV.Enabled = !val;
            cbbMaHS.Enabled = !val;
        }
        private void fPhieuDD_Load(object sender, EventArgs e)
        {
            HienthiPhieuDiemDanh();
            HienthiMaGV();
            HienthiMaHS();
            setnull();
            setButton(true);
            setKhoa(true);
        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNV.SelectedIndices.Count > 0)
            {
                txtMaPBA.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                cbbGV.Text = lsvNV.SelectedItems[0].SubItems[1].Text;
                cbbMaHS.Text = lsvNV.SelectedItems[0].SubItems[2].Text;
                dtpNgayDK.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[3].Text);
                txtTinhTrangVang.Text = lsvNV.SelectedItems[0].SubItems[4].Text;
                txtXuatAn.Text = lsvNV.SelectedItems[0].SubItems[5].Text;


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
                    nh.XoaPhieuDD(lsvNV.SelectedItems[0].SubItems[0].Text);
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
                    MessageBox.Show("Trùng mã phiếu điểm danh");

                }
                else
                {
                    nh.ThemDD(txtMaPBA.Text, cbbGV.Text, cbbMaHS.Text, ngay, txtTinhTrangVang.Text, txtXuatAn.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nh.CapNhatDD(lsvNV.SelectedItems[0].SubItems[0].Text, cbbGV.Text, cbbMaHS.Text, ngay, txtTinhTrangVang.Text, txtXuatAn.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            HienthiPhieuDiemDanh();
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
                        HienthiTKDD();
                    }
                    if (i == 2)
                    {
                        HienthiTKGV();

                    }
                    if (i == 3)
                    {
                        HienThiTKHS();
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
            HienthiPhieuDiemDanh();
        }

        private void sbtLamMoi_Click(object sender, EventArgs e)
        {
            setnull();
            setKhoa(true);
            setButton(true);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
