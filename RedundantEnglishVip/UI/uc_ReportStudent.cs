using BUS;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.DirectX.NativeInterop.Direct2D;
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
    public partial class uc_ReportStudent : UserControl
    {
        List<Regis_DTO> lts;
        DateTime d1, d2;
        public uc_ReportStudent()
        {
            InitializeComponent();
        }

        private void uc_ReportStudent_Load(object sender, EventArgs e)
        {
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-DateTime.Today.Day+1);
            List<string> itemlist = new List<string> { "All", "Unpaid", "Paid" };
            cbSort.Items.AddRange(itemlist.ToArray());
            cbSort.SelectedIndex = 0;
 
        }

       
        private void dgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Student_DTO y = e.Value as Student_DTO;
                if (y == null)
                {
                    return;
                }
                e.Value = y.Name;
            }
            if (e.ColumnIndex == 3)
            {
                Course_DTO x = e.Value as Course_DTO;
                if (x == null)
                {
                    return;
                }
                e.Value = x.Coursecode;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 1)
            {
                var filteredList = lts.Where(regis => regis.TTHP.Trim() == "Unpaid");
                BindingSource filteredBindingSource = new BindingSource();
                filteredBindingSource.DataSource = filteredList.ToList();
                dgvReport.DataSource = filteredBindingSource;
            }
            else if (cbSort.SelectedIndex == 2)
            {
                var filteredList = lts.Where(regis => regis.TTHP.Trim() == "Paid");
                BindingSource filteredBindingSource = new BindingSource();
                filteredBindingSource.DataSource = filteredList.ToList();
                dgvReport.DataSource = filteredBindingSource;
            }
            else
            {
                dgvReport.DataSource = lts;
            }
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        

        private void btnExExcel_Click(object sender, EventArgs e)
        {
          
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            d1 = dtpFrom.Value;
            d2 = dtpTo.Value.AddDays(1);
            dgvReport.DataSource = lts = Regis_BUS.LayDKTuNgay(d1, d2);
            dgvReport.CellFormatting += dgvReport_CellFormatting;
        }
    }
}
