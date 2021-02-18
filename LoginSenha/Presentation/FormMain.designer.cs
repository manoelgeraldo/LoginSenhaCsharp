
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
            this.components = new System.ComponentModel.Container();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlBarTitle = new System.Windows.Forms.Panel();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.timerMostrar = new System.Windows.Forms.Timer(this.components);
            this.timerOcultar = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
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
            this.pnlForms.Location = new System.Drawing.Point(220, 49);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1113, 714);
            this.pnlForms.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.lblHora);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 49);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 714);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDiaSemana.Location = new System.Drawing.Point(231, 15);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(105, 17);
            this.lblDiaSemana.TabIndex = 11;
            this.lblDiaSemana.Text = "Dia da Semana";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::Presentation.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(168, 8);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(44, 41);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 8;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Location = new System.Drawing.Point(47, 57);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 31);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "Hora";
            // 
            // pnlBarTitle
            // 
            this.pnlBarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlBarTitle.Controls.Add(this.lblDiaSemana);
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
            this.lblMenuPrincipal.Location = new System.Drawing.Point(13, 10);
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
            // timerHora
            // 
            this.timerHora.Interval = 1;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // timerMostrar
            // 
            this.timerMostrar.Tick += new System.EventHandler(this.timerMostrar_Tick);
            // 
            // timerOcultar
            // 
            this.timerOcultar.Tick += new System.EventHandler(this.timerOcultar_Tick);
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
        private System.Windows.Forms.Panel pnlBarTitle;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.PictureBox btnRest;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Timer timerMostrar;
        private System.Windows.Forms.Timer timerOcultar;
    }
}