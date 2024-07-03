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

namespace RedundantEnglishVip
{
    public partial class frm_MainStudent : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private string username;
        public frm_MainStudent(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        uc_StudentInfo uc_StudentInfo;
        uc_StudentRegis uc_StudentRegis;
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void mnInfo_Click(object sender, EventArgs e)
        {
            if (uc_StudentInfo == null)
            {
                uc_StudentInfo = new uc_StudentInfo(username);
                uc_StudentInfo.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc_StudentInfo);
                uc_StudentInfo.BringToFront();
            }
            else
                uc_StudentInfo.BringToFront();
        }

        private void mnRegis_Click(object sender, EventArgs e)
        {
            if (uc_StudentRegis == null)
            {
                uc_StudentRegis = new uc_StudentRegis(username);
                uc_StudentRegis.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc_StudentRegis);
                uc_StudentRegis.BringToFront();
            }
            else
                uc_StudentRegis.BringToFront();
        }

        private void mnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new frm_Login();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }

        private void mnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
