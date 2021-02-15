
namespace Presentation
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.dtpInfoDate = new System.Windows.Forms.DateTimePicker();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.pnlBarTitle = new System.Windows.Forms.Panel();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.pnlBarTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlContainer.Controls.Add(this.pnlForms);
            this.pnlContainer.Controls.Add(this.pnlMenu);
            this.pnlContainer.Controls.Add(this.pnlBarTitle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1333, 763);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.SystemColors.Control;
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(236, 49);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1097, 714);
            this.pnlForms.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.dtpInfoDate);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnPerson);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.lblName);
            this.pnlMenu.Controls.Add(this.lblPosition);
            this.pnlMenu.Controls.Add(this.pbxUser);
            this.pnlMenu.Controls.Add(this.btnGraphics);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnHistory);
            this.pnlMenu.Controls.Add(this.btnCalendar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 49);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(236, 714);
            this.pnlMenu.TabIndex = 1;
            // 
            // dtpInfoDate
            // 
            this.dtpInfoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInfoDate.Location = new System.Drawing.Point(16, 150);
            this.dtpInfoDate.Name = "dtpInfoDate";
            this.dtpInfoDate.Size = new System.Drawing.Size(177, 22);
            this.dtpInfoDate.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = global::Presentation.Properties.Resources.logout__1_1;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(4, 646);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(224, 55);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerson.FlatAppearance.BorderSize = 0;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPerson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPerson.Image = global::Presentation.Properties.Resources.patient__1_1;
            this.btnPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerson.Location = new System.Drawing.Point(4, 195);
            this.btnPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnPerson.Size = new System.Drawing.Size(224, 55);
            this.btnPerson.TabIndex = 1;
            this.btnPerson.Text = "Person";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::Presentation.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(184, 4);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(44, 41);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(127, 83);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPosition.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPosition.Location = new System.Drawing.Point(127, 104);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(62, 18);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Position";
            // 
            // pbxUser
            // 
            this.pbxUser.Image = global::Presentation.Properties.Resources.user__1_;
            this.pbxUser.Location = new System.Drawing.Point(21, 62);
            this.pbxUser.Margin = new System.Windows.Forms.Padding(4);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(89, 81);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUser.TabIndex = 4;
            this.pbxUser.TabStop = false;
            // 
            // btnGraphics
            // 
            this.btnGraphics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraphics.FlatAppearance.BorderSize = 0;
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGraphics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGraphics.Image = global::Presentation.Properties.Resources.bar_graph1;
            this.btnGraphics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraphics.Location = new System.Drawing.Point(4, 453);
            this.btnGraphics.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnGraphics.Size = new System.Drawing.Size(224, 55);
            this.btnGraphics.TabIndex = 5;
            this.btnGraphics.Text = "Graphics";
            this.btnGraphics.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSettings.Image = global::Presentation.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(4, 390);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(224, 55);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistory.Image = global::Presentation.Properties.Resources.History;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(4, 324);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(224, 55);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalendar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(4, 257);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(224, 55);
            this.btnCalendar.TabIndex = 2;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // pnlBarTitle
            // 
            this.pnlBarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlBarTitle.Controls.Add(this.lblMenuPrincipal);
            this.pnlBarTitle.Controls.Add(this.btnRest);
            this.pnlBarTitle.Controls.Add(this.btnMin);
            this.pnlBarTitle.Controls.Add(this.btnMax);
            this.pnlBarTitle.Controls.Add(this.btnClose);
            this.pnlBarTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlBarTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarTitle.Name = "pnlBarTitle";
            this.pnlBarTitle.Size = new System.Drawing.Size(1333, 49);
            this.pnlBarTitle.TabIndex = 0;
            this.pnlBarTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarTitle_MouseMove);
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(16, 11);
            this.lblMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(141, 25);
            this.lblMenuPrincipal.TabIndex = 4;
            this.lblMenuPrincipal.Text = "Menu Principal";
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRest.Image = global::Presentation.Properties.Resources.Normal;
            this.btnRest.Location = new System.Drawing.Point(1259, 15);
            this.btnRest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(21, 20);
            this.btnRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRest.TabIndex = 3;
            this.btnRest.TabStop = false;
            this.btnRest.Visible = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::Presentation.Properties.Resources.Minimize;
            this.btnMin.Location = new System.Drawing.Point(1217, 15);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(21, 20);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::Presentation.Properties.Resources.maximize;
            this.btnMax.Location = new System.Drawing.Point(1259, 15);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(21, 20);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Presentation.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(1296, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 763);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(907, 492);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.pnlBarTitle.ResumeLayout(false);
            this.pnlBarTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBarTitle;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.PictureBox btnRest;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.DateTimePicker dtpInfoDate;
    }
}