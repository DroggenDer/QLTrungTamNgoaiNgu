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
    public partial class uc_CreateAccount : UserControl
    {
        BindingSource LstBindin = new BindingSource();
        List<Student_DTO> listStudents;
        int rowIndex;
        public uc_CreateAccount()
        {
            InitializeComponent();
        }

        private void LoadDanhSach()
        {
            listStudents = Student_BUS.LayDS();
            LstBindin.DataSource = listStudents;
            dgvAccstu.DataSource = LstBindin;
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPassword.Text;
            string type = txtType.Text;
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please check the input!");
                return;
            }
            Account_DTO kh = new Account_DTO()
            {
                Username = username,
                Password = pass,
                Type = type,

            };
            if (Account_BUS.Them(kh))
            {
                int id = Convert.ToInt32(dgvAccstu[0, rowIndex].Value);
                Student_DTO st = new Student_DTO()
                {
                    Id = id,
                    Username = username,
                    Lastname = dgvAccstu[2, rowIndex].Value.ToString(),
                    Name = dgvAccstu[3, rowIndex].Value.ToString(),
                    Date = DateTime.Parse(dgvAccstu[4, rowIndex].Value.ToString()),
                    Email = dgvAccstu[5, rowIndex].Value.ToString(),
                    Address = dgvAccstu[6, rowIndex].Value.ToString(),
                    Phonenumber = dgvAccstu[7, rowIndex].Value.ToString(),
                    Sex = dgvAccstu[8, rowIndex].Value.ToString(),
                };
                if (Student_BUS.Sua(id, st)) LoadDanhSach();
                //them taikhoan
                MessageBox.Show("Add successfully");
                return;
            }

            MessageBox.Show("Failed action!");
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow row = dgvAccstu.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Please select option first!");
                return;
            }

            string username = row.Cells["UserName"].Value.ToString();
            if (Student_BUS.SuaBangUsername(username))
            {
                if (Account_BUS.XoaTaiKhoan(username))
                {
                    MessageBox.Show("Deleted");
                    LoadDanhSach();
                    return;
                }
            }

            MessageBox.Show("Failed action!");
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void uc_CreateAccount_Load(object sender, EventArgs e)
        {
            List<string> itemsList = new List<string> { "All", "Unaccount", "Account" };
            cbFilter.Items.AddRange(itemsList.ToArray());
            cbFilter.SelectedIndex = 0;

            LoadDanhSach();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 1)
            {
                var filteredList = listStudents.Where(student => student.Username == "");
                BindingSource filteredBindingSource = new BindingSource();
                filteredBindingSource.DataSource = filteredList.ToList();
                dgvAccstu.DataSource = filteredBindingSource;
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                var filteredList = listStudents.Where(student => student.Username != "");
                BindingSource filteredBindingSource = new BindingSource();
                filteredBindingSource.DataSource = filteredList.ToList();
                dgvAccstu.DataSource = filteredBindingSource;
            }
            else
            {
                dgvAccstu.DataSource = LstBindin;
            }
        }

        private void dgvAccstu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < 5)
            {
                txtUsername.Text = dgvAccstu[1, rowIndex].Value.ToString();
            }
        }
    }
}
