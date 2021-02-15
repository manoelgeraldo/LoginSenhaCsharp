
namespace Presentation
{
    partial class Person
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseFormPerson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseFormPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário Aberto";
            // 
            // btnCloseFormPerson
            // 
            this.btnCloseFormPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseFormPerson.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCloseFormPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFormPerson.Image = global::Presentation.Properties.Resources.Close;
            this.btnCloseFormPerson.Location = new System.Drawing.Point(777, 5);
            this.btnCloseFormPerson.Name = "btnCloseFormPerson";
            this.btnCloseFormPerson.Size = new System.Drawing.Size(16, 16);
            this.btnCloseFormPerson.TabIndex = 1;
            this.btnCloseFormPerson.TabStop = false;
            this.btnCloseFormPerson.Click += new System.EventHandler(this.btnCloseFormPerson_Click);
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseFormPerson);
            this.Controls.Add(this.label1);
            this.Name = "Person";
            this.Text = "FormPerson";
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseFormPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCloseFormPerson;
    }
}