namespace DiaryApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.lblDigitalClock = new System.Windows.Forms.Label();
            this.btnShowDesktop = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoadImage = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSideBar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideBar.Controls.Add(this.lblDigitalClock);
            this.pnlSideBar.Controls.Add(this.btnShowDesktop);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(199, 657);
            this.pnlSideBar.TabIndex = 1;
            // 
            // lblDigitalClock
            // 
            this.lblDigitalClock.BackColor = System.Drawing.Color.Black;
            this.lblDigitalClock.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalClock.ForeColor = System.Drawing.Color.White;
            this.lblDigitalClock.Location = new System.Drawing.Point(-1, 97);
            this.lblDigitalClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDigitalClock.Name = "lblDigitalClock";
            this.lblDigitalClock.Size = new System.Drawing.Size(200, 65);
            this.lblDigitalClock.TabIndex = 6;
            this.lblDigitalClock.Text = "12:00:00";
            this.lblDigitalClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowDesktop
            // 
            this.btnShowDesktop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowDesktop.Image = global::DiaryApp.Properties.Resources.computer_icon;
            this.btnShowDesktop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowDesktop.Location = new System.Drawing.Point(-1, 570);
            this.btnShowDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowDesktop.Name = "btnShowDesktop";
            this.btnShowDesktop.Size = new System.Drawing.Size(200, 86);
            this.btnShowDesktop.TabIndex = 6;
            this.btnShowDesktop.Text = "Show Desktop";
            this.btnShowDesktop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowDesktop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowDesktop.UseVisualStyleBackColor = true;
            this.btnShowDesktop.Click += new System.EventHandler(this.btnShowDesktop_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.label1);
            this.pnlFooter.Controls.Add(this.cboLoadImage);
            this.pnlFooter.Controls.Add(this.lblVersion);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(199, 532);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1152, 125);
            this.pnlFooter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Background Image: ";
            // 
            // cboLoadImage
            // 
            this.cboLoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoadImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoadImage.DropDownWidth = 220;
            this.cboLoadImage.FormattingEnabled = true;
            this.cboLoadImage.Location = new System.Drawing.Point(842, 49);
            this.cboLoadImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLoadImage.Name = "cboLoadImage";
            this.cboLoadImage.Size = new System.Drawing.Size(288, 24);
            this.cboLoadImage.TabIndex = 1;
            this.cboLoadImage.SelectedValueChanged += new System.EventHandler(this.cboLoadImage_SelectedValueChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(13, 49);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(85, 20);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version: ";
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.tsMenu.Location = new System.Drawing.Point(199, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1152, 98);
            this.tsMenu.TabIndex = 3;
            this.tsMenu.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.Image = global::DiaryApp.Properties.Resources.add_icon;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(88, 70);
            this.toolStripButton5.Text = "Add Memo";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Image = global::DiaryApp.Properties.Resources.search_icon;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(104, 70);
            this.toolStripButton4.Text = "Search Memo";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Image = global::DiaryApp.Properties.Resources.settings_icon;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton3.Text = "Settings";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Image = global::DiaryApp.Properties.Resources.tools_icon;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton2.Text = "Tools";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::DiaryApp.Properties.Resources.about_icon;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton1.Text = "About Us";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = global::DiaryApp.Properties.Resources.minimize_icon;
            this.btnMinimize.Location = new System.Drawing.Point(1196, 14);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(67, 62);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::DiaryApp.Properties.Resources.close_icon;
            this.btnClose.Location = new System.Drawing.Point(1269, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 62);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 657);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JaHCoto Diary App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnShowDesktop;
        private System.Windows.Forms.Label lblDigitalClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoadImage;
    }
}

