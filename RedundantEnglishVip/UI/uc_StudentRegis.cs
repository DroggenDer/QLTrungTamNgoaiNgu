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
    
    public partial class uc_StudentRegis : UserControl
    {
        private string username;
        public uc_StudentRegis(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        void LoadInfo()
        {
            Regis_DTO list = Regis_BUS.LayRegis(username);
            lblLastname.Text = list.Student.Lastname;
            lblName.Text = list.Student.Name;
            lblCourseRegis.Text = list.CourseName.NameCourse;
            lblDayRegis.Text = list.Student.Date.ToString();
            lblStartDay.Text = list.CourseName.StartD.ToString();
            lblEndDay.Text = list.CourseName.EndD.ToString();
            lblCurri.Text = list.CourseName.Curri;

        }

        private void uc_StudentRegis_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
