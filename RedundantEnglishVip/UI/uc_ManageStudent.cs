using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace RedundantEnglishVip.UI
{
    public partial class uc_ManageStudent : UserControl
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();
        public uc_ManageStudent()
        {
            InitializeComponent();
            dgvStudent.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
        }

        void LoadDS()
        {
            List<Student_DTO> listTinhTrang = Student_BUS.LayDS();
            LstBindin.DataSource = listTinhTrang;

        }

        void LoadBinding()
        {
            txtLastName.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Name", true, DataSourceUpdateMode.Never));
            dtpDate.DataBindings.Add(new Binding("Value", dgvStudent.DataSource, "Date", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txtPhone.DataBindings.Add(new Binding("Text", dgvStudent.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
        }
        private void uc_ManageStudent_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ho = txtLastName.Text;
            string ten = txtName.Text;
            string dc = txtAddress.Text;
            string sdt = txtPhone.Text;
            string email = txtEmail.Text;


            if (String.IsNullOrEmpty(ho) || String.IsNullOrEmpty(ten) || String.IsNullOrEmpty(dc) || String.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Please check the input!");
                return;
            }

            Student_DTO kh = new Student_DTO()
            {
                Id = 0,
                Lastname = ho,
                Name = ten,
                Date = dtpDate.Value,
                Email = email,
                Address = dc,
                Phonenumber = sdt,
                Sex = rdMale.Checked ? "Male" : "Female",
            };
            if (Student_BUS.Them(kh))
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
            DataGridViewRow row = dgvStudent.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Please select option first!");
                return;
            }
            string ho = txtLastName.Text;
            string ten = txtName.Text;
            string dc = txtAddress.Text;
            string sdt = txtPhone.Text;
            string email = txtEmail.Text;
            string username = row.Cells[1].Value.ToString();

            if (String.IsNullOrEmpty(ho) || String.IsNullOrEmpty(ten) || String.IsNullOrEmpty(dc) || String.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Please check the input!");
                return;
            }
            int Id = Convert.ToInt32(row.Cells[0].Value);          
            Student_DTO ncc = new Student_DTO()
            {
                Id = 0,
                Username = username,
                Lastname = ho,
                Name = ten,
                Address = dc,
                Email = email,
                Sex = rdMale.Checked ? "Male" : "Female",
                Date = dtpDate.Value,
                Phonenumber = sdt,
            };
            if (Student_BUS.Sua(Id, ncc))
            {
                MessageBox.Show("Update successfully");
                LoadDS();
                return;
            }

            MessageBox.Show("Fail action!");
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = dgvStudent.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Please select your option!");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            string username = row.Cells[1].Value.ToString();
            
            if (Student_BUS.Xoa(Id))
            {
                MessageBox.Show("Deleted");
                LoadDS();
                if (!string.IsNullOrEmpty(username))
                    Account_BUS.XoaTaiKhoan(username);
                return;
            }

            MessageBox.Show("Failed action!");
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
