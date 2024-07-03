namespace RedundantEnglishVip
{
    partial class frm_MainStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainStudent));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aCE2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnInfo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aCE3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnRegis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aCE4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnLogout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnClose = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.mainContainer.Location = new System.Drawing.Point(312, 39);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(701, 551);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.MediumAquamarine;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Group.Default.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accordionControl1.Appearance.Group.Default.ForeColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.Group.Default.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Default.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accordionControl1.Appearance.Item.Default.ForeColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.Item.Default.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Default.Options.UseForeColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aCE2,
            this.aCE3,
            this.aCE4});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(312, 551);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aCE2
            // 
            this.aCE2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnInfo});
            this.aCE2.Expanded = true;
            this.aCE2.Name = "aCE2";
            this.aCE2.Text = "INFO";
            // 
            // mnInfo
            // 
            this.mnInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnInfo.ImageOptions.SvgImage")));
            this.mnInfo.Name = "mnInfo";
            this.mnInfo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnInfo.Text = "Check your infomation";
            this.mnInfo.Click += new System.EventHandler(this.mnInfo_Click);
            // 
            // aCE3
            // 
            this.aCE3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnRegis});
            this.aCE3.Expanded = true;
            this.aCE3.Name = "aCE3";
            this.aCE3.Text = "REGIS";
            // 
            // mnRegis
            // 
            this.mnRegis.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnRegis.ImageOptions.SvgImage")));
            this.mnRegis.Name = "mnRegis";
            this.mnRegis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnRegis.Text = "Check your register course";
            this.mnRegis.Click += new System.EventHandler(this.mnRegis_Click);
            // 
            // aCE4
            // 
            this.aCE4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnLogout,
            this.mnClose});
            this.aCE4.Expanded = true;
            this.aCE4.Name = "aCE4";
            this.aCE4.Text = "SYSTEM";
            // 
            // mnLogout
            // 
            this.mnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnLogout.ImageOptions.SvgImage")));
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnLogout.Text = "Log out";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // mnClose
            // 
            this.mnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnClose.ImageOptions.SvgImage")));
            this.mnClose.Name = "mnClose";
            this.mnClose.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnClose.Text = "Shut down";
            this.mnClose.Click += new System.EventHandler(this.mnClose_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1013, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // frm_MainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 590);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::RedundantEnglishVip.Properties.Resources.logo;
            this.Name = "frm_MainStudent";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Redundant English";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement aCE2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aCE3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aCE4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnInfo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnRegis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnLogout;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnClose;
    }
}