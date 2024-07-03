namespace RedundantEnglishVip
{
    partial class frm_MainManagers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainManagers));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnMangeStudent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnCreateAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnManageCourse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnRegisCourse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnStudentRP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnCourseReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(378, 39);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(6);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(678, 551);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.SizeChanged += new System.EventHandler(this.mainContainer_SizeChanged);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.DarkGray;
            this.accordionControl1.Appearance.AccordionControl.ForeColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accordionControl1.Appearance.ItemWithContainer.Default.BorderColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.ItemWithContainer.Default.Options.UseBorderColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement6});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(6);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(378, 551);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnMangeStudent,
            this.mnCreateAccount});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "STUDENT";
            // 
            // mnMangeStudent
            // 
            this.mnMangeStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnMangeStudent.ImageOptions.SvgImage")));
            this.mnMangeStudent.Name = "mnMangeStudent";
            this.mnMangeStudent.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnMangeStudent.Text = "Manage Student";
            this.mnMangeStudent.Click += new System.EventHandler(this.mnMangeStudent_Click);
            // 
            // mnCreateAccount
            // 
            this.mnCreateAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnCreateAccount.ImageOptions.SvgImage")));
            this.mnCreateAccount.Name = "mnCreateAccount";
            this.mnCreateAccount.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnCreateAccount.Text = "Create Account";
            this.mnCreateAccount.Click += new System.EventHandler(this.mnCreateAccount_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnManageCourse,
            this.mnRegisCourse});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "COURSE";
            // 
            // mnManageCourse
            // 
            this.mnManageCourse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnManageCourse.ImageOptions.SvgImage")));
            this.mnManageCourse.Name = "mnManageCourse";
            this.mnManageCourse.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnManageCourse.Text = "Manage Course";
            this.mnManageCourse.Click += new System.EventHandler(this.mnManageCourse_Click);
            // 
            // mnRegisCourse
            // 
            this.mnRegisCourse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnRegisCourse.ImageOptions.SvgImage")));
            this.mnRegisCourse.Name = "mnRegisCourse";
            this.mnRegisCourse.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnRegisCourse.Text = "Regis Course";
            this.mnRegisCourse.Click += new System.EventHandler(this.mnRegisCourse_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnStudentRP,
            this.mnCourseReport});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "REPORT";
            // 
            // mnStudentRP
            // 
            this.mnStudentRP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnStudentRP.ImageOptions.SvgImage")));
            this.mnStudentRP.Name = "mnStudentRP";
            this.mnStudentRP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnStudentRP.Text = "Report Student";
            this.mnStudentRP.Click += new System.EventHandler(this.mnStudentRP_Click);
            // 
            // mnCourseReport
            // 
            this.mnCourseReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnCourseReport.ImageOptions.SvgImage")));
            this.mnCourseReport.Name = "mnCourseReport";
            this.mnCourseReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnCourseReport.Text = "Report Course";
            this.mnCourseReport.Click += new System.EventHandler(this.mnCourseReport_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement7,
            this.accordionControlElement8,
            this.accordionControlElement4,
            this.accordionControlElement5});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "SYSTEM";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement7.ImageOptions.SvgImage")));
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Log Out";
            this.accordionControlElement7.Click += new System.EventHandler(this.accordionControlElement7_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement8.ImageOptions.SvgImage")));
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Shut Down";
            this.accordionControlElement8.Click += new System.EventHandler(this.accordionControlElement8_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement4.ImageOptions.SvgImage")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Backup";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement5.ImageOptions.SvgImage")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Restore";
            this.accordionControlElement5.Click += new System.EventHandler(this.accordionControlElement5_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1056, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // frm_MainManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 590);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::RedundantEnglishVip.Properties.Resources.logo;
            this.Name = "frm_MainManagers";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REDUNDANT ENGLISH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MainManagers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnMangeStudent;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnCreateAccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnManageCourse;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnRegisCourse;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnStudentRP;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnCourseReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
    }
}