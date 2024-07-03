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
    public partial class uc_ManageCourse : UserControl
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();
        public uc_ManageCourse()
        {
            InitializeComponent();
            dgvCourse.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
            LoadCbbGiaoVien();
            LoadCbbRoom();
        }

        void LoadCbbGiaoVien()
        {
            List<Teacher_DTO> listgv = Teacher_BUS.LayDS();
            cbTeacher.DataSource = listgv;
            cbTeacher.DisplayMember = "Name";
            cbTeacher.ValueMember = "ID";
        }

        void LoadCbbRoom()
        {
            List<Room_DTO> listr = Room_BUS.LayDS();
            cbRoom.DataSource = listr;
            cbRoom.DisplayMember = "RoomName";
            cbRoom.ValueMember = "ID";
        }

        void LoadBinding()
        {
            txtCodeCourse.DataBindings.Add(new Binding("Text", dgvCourse.DataSource, "CourseCode", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dgvCourse.DataSource, "NameCourse", true, DataSourceUpdateMode.Never));
            dtpStartD.DataBindings.Add(new Binding("Value", dgvCourse.DataSource, "StartD", true, DataSourceUpdateMode.Never));
            dtpEndD.DataBindings.Add(new Binding("Value", dgvCourse.DataSource, "EndD", true, DataSourceUpdateMode.Never));
            txtTimeLearn.DataBindings.Add(new Binding("Text", dgvCourse.DataSource, "Time", true, DataSourceUpdateMode.Never));
            txtFee.DataBindings.Add(new Binding("Text", dgvCourse.DataSource, "Fee", true, DataSourceUpdateMode.Never));
            txtCurri.DataBindings.Add(new Binding("Text", dgvCourse.DataSource, "Curri", true, DataSourceUpdateMode.Never));
            txtNumber.DataBindings.Add(new Binding("Text", dgvCourse.DataSource, "Number", true, DataSourceUpdateMode.Never));
        }

        void LoadDS()
        {
            List<Course_DTO> listKH = Course_BUS.LayDS();
            LstBindin.DataSource = listKH;
        }
        private void uc_ManageCourse_Load(object sender, EventArgs e)
        {
            LoadDS();
            dgvCourse.CellFormatting += dgvCourse_CellFormatting;
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string code = txtCodeCourse.Text;
            string name = txtName.Text;
            string time = txtTimeLearn.Text;
            int fee = int.Parse(txtFee.Text);
            string curri = txtCurri.Text;
            int number = int.Parse(txtNumber.Text);

            if (String.IsNullOrEmpty(code) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(time) || String.IsNullOrEmpty(curri))
            {
                MessageBox.Show("Please check the input!");
                return;
            }
            if (number <= 0)
            {
                MessageBox.Show("The number of student must be more than 0");
                return;
            }
            if (cbRoom.SelectedItem == null || cbTeacher.SelectedItem == null)
            {
                MessageBox.Show("Please select teacher and room!");
                return;
            }

            Course_DTO kh = new Course_DTO()
            {
                Id = 0,
                Coursecode = code,
                NameCourse = name,
                StartD = dtpEndD.Value,
                EndD = dtpEndD.Value,
                Time = time,
                Fee = fee,
                Phong = (cbRoom.SelectedItem as Room_DTO),
                GiaoVien = (cbTeacher.SelectedItem as Teacher_DTO),
                Curri = curri,
                Number = number,
            };
            if (Course_BUS.Them(kh))
            {
                //them taikhoan
                MessageBox.Show("Add successfully");
                LoadDS();
                return;
            }

            MessageBox.Show("Failed action");
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = dgvCourse.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Please select option!");
                return;
            }
            string code = txtCodeCourse.Text;
            string name = txtName.Text;
            string time = txtTimeLearn.Text;
            int fee = int.Parse(txtFee.Text);
            string curri = txtCurri.Text;
            int number = int.Parse(txtNumber.Text);

            if (String.IsNullOrEmpty(code) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(time) || String.IsNullOrEmpty(curri))
            {
                MessageBox.Show("Please check the input!");
                return;
            }
            int Id = Convert.ToInt32(row.Cells[0].Value);
            Course_DTO ncc = new Course_DTO()
            {
                Id = 0,
                Coursecode = code,
                NameCourse = name,
                StartD = dtpEndD.Value,
                EndD = dtpEndD.Value,
                Time = time,
                Fee = fee,
                Phong = (cbRoom.SelectedItem as Room_DTO),
                GiaoVien = (cbTeacher.SelectedItem as Teacher_DTO),
                Curri = curri,
                Number = number,
            };
            if (Course_BUS.Sua(Id, ncc))
            {
                MessageBox.Show("Update successfully");
                LoadDS();
                return;
            }

            MessageBox.Show("Failed action!");
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = dgvCourse.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Please select option first!");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);

            if (Course_BUS.Xoa(Id))
            {
                MessageBox.Show("Deleted");
                LoadDS();
                return;
            }

            MessageBox.Show("Failed action!");
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dgvCourse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                Room_DTO x = e.Value as Room_DTO;
                if (x == null)
                {
                    return;
                }
                e.Value = x.RoomName;
            }
            if (e.ColumnIndex == 9)
            {
                Teacher_DTO y = e.Value as Teacher_DTO;
                if (y == null)
                {
                    return;
                }
                e.Value = y.Name;
            }
        }
    }
}
