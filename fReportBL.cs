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
    public partial class fReportBL : Form
    {
        public fReportBL()
        {
            InitializeComponent();
        }

        private void fReportBL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongTinMNDataSet.BienLai' table. You can move, or remove it, as needed.
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void bttXuat_Click(object sender, EventArgs e)
        {
            this.BienLaiTableAdapter.Fill(this.ThongTinMNDataSet.BienLai,Decimal.Parse(cbbThang.Text));

            this.reportViewer1.RefreshReport();

        }
    }
}
