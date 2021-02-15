
namespace Presentation
{
    partial class FormLogin
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
            this.pnlSideLogin = new System.Windows.Forms.Panel();
            this.pnlLoginMain = new System.Windows.Forms.Panel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.btnCloseLogin = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlLoginMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideLogin
            // 
            this.pnlSideLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.pnlSideLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlSideLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideLogin.Name = "pnlSideLogin";
            this.pnlSideLogin.Size = new System.Drawing.Size(267, 375);
            this.pnlSideLogin.TabIndex = 0;
            this.pnlSideLogin.TabStop = true;
            this.pnlSideLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSideLogin_MouseMove);
            // 
            // pnlLoginMain
            // 
            this.pnlLoginMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlLoginMain.Controls.Add(this.lblErrorMessage);
            this.pnlLoginMain.Controls.Add(this.linkPass);
            this.pnlLoginMain.Controls.Add(this.btnCloseLogin);
            this.pnlLoginMain.Controls.Add(this.lblLogin);
            this.pnlLoginMain.Controls.Add(this.btnLogin);
            this.pnlLoginMain.Controls.Add(this.txtPass);
            this.pnlLoginMain.Controls.Add(this.txtUserName);
            this.pnlLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginMain.Location = new System.Drawing.Point(267, 0);
            this.pnlLoginMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLoginMain.Name = "pnlLoginMain";
            this.pnlLoginMain.Size = new System.Drawing.Size(666, 375);
            this.pnlLoginMain.TabIndex = 1;
            this.pnlLoginMain.TabStop = true;
            this.pnlLoginMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlLoginMain_MouseMove);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.SystemColors.Info;
            this.lblErrorMessage.Location = new System.Drawing.Point(106, 207);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(101, 17);
            this.lblErrorMessage.TabIndex = 5;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // linkPass
            // 
            this.linkPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.linkPass.AutoSize = true;
            this.linkPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPass.ForeColor = System.Drawing.Color.DarkGray;
            this.linkPass.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkPass.LinkColor = System.Drawing.Color.DimGray;
            this.linkPass.Location = new System.Drawing.Point(273, 327);
            this.linkPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(136, 17);
            this.linkPass.TabIndex = 4;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "Esqueceu a Senha?";
            this.linkPass.MouseEnter += new System.EventHandler(this.linkPass_MouseEnter);
            this.linkPass.MouseLeave += new System.EventHandler(this.linkPass_MouseLeave);
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseLogin.Image = global::Presentation.Properties.Resources.Close;
            this.btnCloseLogin.Location = new System.Drawing.Point(632, 13);
            this.btnCloseLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(21, 20);
            this.btnCloseLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseLogin.TabIndex = 4;
            this.btnCloseLogin.TabStop = false;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogin.Location = new System.Drawing.Point(292, 30);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(100, 33);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogin.Location = new System.Drawing.Point(109, 261);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(459, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(109, 166);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(458, 32);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Senha";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.Location = new System.Drawing.Point(109, 91);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(458, 32);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Usuário";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 375);
            this.Controls.Add(this.pnlLoginMain);
            this.Controls.Add(this.pnlSideLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseMove);
            this.pnlLoginMain.ResumeLayout(false);
            this.pnlLoginMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideLogin;
        private System.Windows.Forms.Panel pnlLoginMain;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel linkPass;
        private System.Windows.Forms.PictureBox btnCloseLogin;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}