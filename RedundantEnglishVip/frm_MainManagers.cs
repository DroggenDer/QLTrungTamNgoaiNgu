using DevExpress.XtraBars;
using RedundantEnglishVip.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;


namespace RedundantEnglishVip
{
    public partial class frm_MainManagers : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_MainManagers()
        {
            InitializeComponent();
        }

        uc_ManageStudent uc_ManageStudent;
        uc_CreateAccount uc_CreateAccount;
        uc_ManageCourse uc_ManageCourse;
        uc_RegisCourse uc_RegisCourse;
        uc_ReportStudent uc_ReportStudent;
        uc_ReportCourse uc_ReportCourse;

        
        private void mnMangeStudent_Click(object sender, EventArgs e)
        {
            if (uc_ManageStudent == null)
            {
                uc_ManageStudent = new uc_ManageStudent();
                uc_ManageStudent.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc_ManageStudent);
                uc_ManageStudent.BringToFront();
            }
            else
                uc_ManageStudent.BringToFront();

        }

        private void mnCreateAccount_Click(object sender, EventArgs e)
        {
            if (uc_CreateAccount == null)
            {
                uc_CreateAccount = new uc_CreateAccount();
                uc_CreateAccount.Dock = DockStyle.Fill;
                mainContainer.Controls.Add (uc_CreateAccount);
                uc_CreateAccount.BringToFront();
            }
            else
                uc_CreateAccount.BringToFront();
        }

        private void mnManageCourse_Click(object sender, EventArgs e)
        {
            if (uc_ManageCourse == null)
            {
                uc_ManageCourse = new uc_ManageCourse();
                uc_ManageCourse.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc_ManageCourse);
                uc_ManageCourse.BringToFront();
            }
            else
                uc_ManageCourse.BringToFront();
        }

        private void mnRegisCourse_Click(object sender, EventArgs e)
        {
            if (uc_RegisCourse == null)
            {
                uc_RegisCourse = new uc_RegisCourse();
                uc_RegisCourse.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc_RegisCourse);
                uc_RegisCourse.BringToFront();
            }
            else
                uc_RegisCourse.BringToFront();
        }

        private void mnStudentRP_Click(object sender, EventArgs e)
        {
            if (uc_ReportStudent == null)
            {
                uc_ReportStudent = new uc_ReportStudent();
                uc_ReportStudent.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc_ReportStudent);
                uc_ReportStudent.BringToFront();
            }
            else
                uc_ReportStudent.BringToFront();

        }

        private void mnCourseReport_Click(object sender, EventArgs e)
        {
            if (uc_ReportCourse == null)
            {
                uc_ReportCourse = new uc_ReportCourse();
                uc_ReportCourse.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc_ReportCourse);
                uc_ReportCourse.BringToFront();
            }
            else
                uc_ReportCourse.BringToFront();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new frm_Login();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_MainManagers_Load(object sender, EventArgs e)
        {
            
        }

        private void mainContainer_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Bạn có muốn sao lưu dữ liệu không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
                saoluuFolder.Description = "Chọn thư mục lưu trữ";
                if (saoluuFolder.ShowDialog() == DialogResult.OK)
                {
                    string sDuongDan = saoluuFolder.SelectedPath;
                    if (DataConsole_BUS.SaoLuu(sDuongDan) == true)
                        MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                    else
                        MessageBox.Show("Thao tác không thành công");
                }
            }
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Dữ liệu hiện tại sau khi khôi phục sẽ bị mất,\n" +
                    "Bạn có muốn không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                OpenFileDialog phuchoiFile = new OpenFileDialog();
                phuchoiFile.Filter = "*.bak|*.bak";
                phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
                if (phuchoiFile.ShowDialog() == DialogResult.OK &&
               phuchoiFile.CheckFileExists == true)
                {
                    string sDuongDan = phuchoiFile.FileName;
                    if (DataConsole_BUS.PhucHoi(sDuongDan) == true)
                    {
                        MessageBox.Show(
                        "Khôi phục thành công, vui lòng đăng nhập lại để sử dụng",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);                      
                    }
                    else
                        MessageBox.Show("Khôi phục thất bại");
                }
            }
        }
    }
}
