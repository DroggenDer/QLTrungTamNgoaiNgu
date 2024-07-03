using BUS;
using DevExpress.XtraEditors;
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

namespace RedundantEnglishVip
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        public static Account_DTO TaiKhoan;
        public bool bhv = false;
        public string flag;
        private void frm_Login_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sTen = txtUsername.Text;
            string sMatKhau = txtPassword.Text;
            


            TaiKhoan = Account_BUS.layTaiKhoan(sTen, sMatKhau);
            
            if (TaiKhoan != null && TaiKhoan.Type.Trim()=="ad")
            {

                MessageBox.Show("Welcome Admin!");
                this.Hide();
                var f1 = new frm_MainManagers();
                f1.Closed += (s, args) => this.Close();
                f1.Show();

            }
            else if (TaiKhoan != null)
            {
                flag = sTen;
                MessageBox.Show("Welcome student to Redundant English!");
                this.Hide();
                var f1 = new frm_MainStudent(flag);
                f1.Closed += (s, args) => this.Close();
                f1.Show();

            }
            else
            {
                MessageBox.Show("Fail login");

            }
        }
    }
}