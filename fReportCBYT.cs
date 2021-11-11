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
    public partial class fReportCBYT : Form
    {
        public fReportCBYT()
        {
            InitializeComponent();
        }

        private void fReportCBYT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongTinMNDataSet.CBYT' table. You can move, or remove it, as needed.
            this.CBYTTableAdapter.Fill(this.ThongTinMNDataSet.CBYT);

            this.reportViewer1.RefreshReport();
        }
    }
}
