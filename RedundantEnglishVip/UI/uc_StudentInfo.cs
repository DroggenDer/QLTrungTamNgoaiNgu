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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RedundantEnglishVip.UI
{
    public partial class uc_StudentInfo : UserControl
    {
        private string username;
        public uc_StudentInfo(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        void LoadInfo()
        {
            Student_DTO list = Student_BUS.LayInfo(username);
            lblLastName.Text = list.Lastname;
            lblName.Text = list.Name;
            lblAddress.Text = list.Address;
            lblDate.Text = list.Date.ToString();
            lblEmail.Text = list.Email;
            lblPhone.Text = list.Phonenumber.ToString();
            lblSex.Text = list.Sex;

        }
        private void uc_StudentInfo_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
