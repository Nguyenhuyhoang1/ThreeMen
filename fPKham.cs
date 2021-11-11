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
    public partial class fPKham : Form
    {
        PhieuKham nv = new PhieuKham();
        Boolean themmoi;
        public fPKham()
        {
            InitializeComponent();
        }
        void HienthiPhieuKham()
        {
            DataTable dt = nv.LayDSPhieuKham();
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


            }
        }
        void HienthiMaPH()
        {
            DataTable dt = nv.LayDSHS();
            cbbMaHS.DataSource = dt;
            cbbMaHS.DisplayMember = "MaHS";
            cbbMaHS.ValueMember = "MaHS";
        }
        void HienthiTKmaHS()
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
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
                lvi.SubItems.Add(dt.Rows[i][9].ToString());


            }
        }
        void HienthiTKmaPK()
        {
            lsvNV.Items.Clear();
            DataTable dt = nv.timkiemMaPK(txtTenhoacMa.Text);
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


            }
        }
        private void spbThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setnull();
            themmoi = true;
        }

        private void fPKham_Load(object sender, EventArgs e)
        {
            HienthiPhieuKham();
            HienthiMaPH();
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
            txtMaPK.Text = "";
            cbbMaHS.Text = "";
            dtpNgaySinh.Text = "";
            txtCanNang.Text = "";
            txtChieuCao.Text = "";
            txtMat.Text = "";
            txtNamHoc.Text = "";
            txtTaiMH.Text = "";
            txtXuong.Text = "";
            txtRang.Text = "";

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
            txtMaPK.ReadOnly = val;
            txtNamHoc.ReadOnly = val;
            dtpNgaySinh.Enabled = !val;
            cbbMaHS.Enabled = !val;
            txtChieuCao.ReadOnly = val;
            txtCanNang.ReadOnly = val;
            txtTaiMH.ReadOnly = val;
            txtMat.ReadOnly = val;
            txtXuong.ReadOnly = val;
            txtRang.ReadOnly = val;
        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNV.SelectedIndices.Count > 0)
            {
                txtMaPK.Text = lsvNV.SelectedItems[0].SubItems[0].Text;
                cbbMaHS.Text = (lsvNV.SelectedItems[0].SubItems[1].Text);
                dtpNgaySinh.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[2].Text);          
                txtNamHoc.Text = lsvNV.SelectedItems[0].SubItems[3].Text;
                txtChieuCao.Text = lsvNV.SelectedItems[0].SubItems[4].Text;
                txtCanNang.Text = lsvNV.SelectedItems[0].SubItems[5].Text;
                txtTaiMH.Text = lsvNV.SelectedItems[0].SubItems[6].Text;
                txtMat.Text = lsvNV.SelectedItems[0].SubItems[7].Text;
                txtXuong.Text = lsvNV.SelectedItems[0].SubItems[8].Text;
                txtRang.Text = lsvNV.SelectedItems[0].SubItems[9].Text;

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
                if (dr == DialogResult.Yes)
                {
                    nv.XoaMaPK(lsvNV.SelectedItems[0].SubItems[0].Text);
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
            DataTable dt = nv.KTIDTrung(txtMaPK.Text);

            if (themmoi)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng mã phiếu khám");

                }
                else
                {
                    nv.ThemPK(txtMaPK.Text, cbbMaHS.Text, ngay, txtNamHoc.Text, txtChieuCao.Text, txtCanNang.Text, txtTaiMH.Text, txtMat.Text, txtXuong.Text, txtRang.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
            }
            else
            {
                nv.CapNhatPK(lsvNV.SelectedItems[0].SubItems[0].Text, cbbMaHS.Text, ngay, txtNamHoc.Text, txtChieuCao.Text, txtCanNang.Text, txtTaiMH.Text, txtMat.Text, txtXuong.Text, txtRang.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            lsvNV.Items.Clear();
            HienthiPhieuKham();
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
                        HienthiTKmaPK();
                    }
                    if (i == 2)
                    {
                        HienthiTKmaHS();
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
            HienthiPhieuKham();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
