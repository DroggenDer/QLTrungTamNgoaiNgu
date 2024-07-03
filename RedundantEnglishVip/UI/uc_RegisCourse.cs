using BUS;
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
    public partial class uc_RegisCourse : UserControl
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();
        public uc_RegisCourse()
        {
            InitializeComponent();
            dgvListDK.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
            LoadCbbHocVien();
            LoadCbbKhoaHoc();
        }


        void LoadCbbKhoaHoc()
        {
            List<Course_DTO> listkh = Course_BUS.LayDS();
            cbCourseName.DataSource = listkh;
            cbCourseName.DisplayMember = "NameCourse";
            cbCourseName.ValueMember = "Id";
        }

        void LoadCbbHocVien()
        {
            List<Student_DTO> listhv = Student_BUS.LayDS();
            cbStuName.DataSource = listhv;
            cbStuName.DisplayMember = "Name";
            cbStuName.ValueMember = "Id";
        }

        void LoadDS()
        {
            List<Regis_DTO> listDK = Regis_BUS.LayDS();
            LstBindin.DataSource = listDK;
        }

        void LoadBinding()
        {
            dtpDate.DataBindings.Add(new Binding("Value", dgvListDK.DataSource, "DateRegis", true, DataSourceUpdateMode.Never));
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = dgvListDK.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Please select option!");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (Regis_BUS.Xoa(Id))
            {
                MessageBox.Show("Deleted");
                LoadDS();
                return;
            }

            MessageBox.Show("Failed action!");
        }

        private void dgvListDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            dgvListDK.CellFormatting += dgvListDK_CellFormatting;
        }

        private void dgvListDK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                e.Value = x.NameCourse;
            }
        }

        private void uc_RegisCourse_Load(object sender, EventArgs e)
        {
            LoadDS();
            dgvListDK.CellFormatting += dgvListDK_CellFormatting;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (cbCourseName.SelectedItem == null || cbStuName.SelectedItem == null || cbFeeStatus.SelectedItem == null)
            {
                MessageBox.Show("Please check the input!");
                return;
            }

            Regis_DTO kh = new Regis_DTO()
            {
                Id = 0,
                CourseName = (cbCourseName.SelectedItem as Course_DTO),
                Student = (cbStuName.SelectedItem as Student_DTO),
                DateRegis = dtpDate.Value,
                TTHP = cbFeeStatus.SelectedText as string,
                
            };
            if (Regis_BUS.Them(kh))
            {
                //them taikhoan
                MessageBox.Show("Add successfully");
                LoadDS();
                return;
            }

            MessageBox.Show("Failed action!");
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = dgvListDK.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Please select option!");
                return;
            }


            int Id = Convert.ToInt32(row.Cells[0].Value);
            Regis_DTO ncc = new Regis_DTO()
            {
                Id = 0,
                CourseName = (cbCourseName.SelectedItem as Course_DTO),
                Student = (cbStuName.SelectedItem as Student_DTO),
                DateRegis = dtpDate.Value,

            };
            if (Regis_BUS.Sua(Id, ncc))
            {
                MessageBox.Show("Update successfully");
                LoadDS();
                return;
            }

            MessageBox.Show("Failed action!");
        }
    }
}
