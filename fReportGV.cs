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
    public partial class fReportGV : Form
    {
        public fReportGV()
        {
            InitializeComponent();
        }

        private void fReportGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongTinMNDataSet.GiaoVien' table. You can move, or remove it, as needed.
            this.GiaoVienTableAdapter.Fill(this.ThongTinMNDataSet.GiaoVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
