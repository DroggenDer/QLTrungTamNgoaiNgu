using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraPrinting.BarCode;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedundantEnglishVip.UI
{
    public partial class uc_ReportCourse : UserControl
    {
        List<CourseRevenue_DTO> lstCourse;
        DateTime d1, d2;
        public uc_ReportCourse()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void btnRp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            d1 = dtpFrom.Value;
            d2 = dtpTo.Value.AddDays(1);
            MessageBox.Show(d1.ToString() + d2.ToString());
            dgvReport.DataSource = lstCourse = CourseRevenue_BUS.LayDoanhThuKH(d1, d2);
        }

        private void uc_ReportCourse_Load(object sender, EventArgs e)
        {
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-DateTime.Today.Day);         
        }
    }
}
