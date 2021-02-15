﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;


namespace Presentation
{
    public partial class FormMain : Form
    {
        //Constructor
        public FormMain()
        {
            InitializeComponent();
            //Elimina as inconsitencias da interface grafica (not 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        #region Funcionalidades do Formulário
        //REDIMENCIONA TAMANHO DO FORMULARIO EM TEMPO DE EXECUÇÃO ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------RETANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pnlContainer.Region = region;
            this.Invalidate();
        }
        //----------------COLOR E GRIP DE RETANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        //BOTÃO FECHAR
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;
        //BOTAO MINIMIZAR
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //BOTAO RESTAURAR
        private void btnRest_Click(object sender, EventArgs e)
        {
            btnMax.Visible = true;
            btnRest.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        //BOTAO MAXIMIZAR
        private void btnMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMax.Visible = false;
            btnRest.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        //ARRASTAR FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //Metodo Abrir Formulário dentro de Panel
        private void OpenForms<MyForm>() where MyForm : Form, new()
        {
            Form formulario;
            formulario = pnlForms.Controls.OfType<MyForm>().FirstOrDefault();//Busca o formulario
            
            //formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MyForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlForms.Controls.Add(formulario);
                pnlForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler (CloseForms);
            }
            //Se formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        //Fecha formulario
        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //Botão SideBar abre e sinaliza que formulário está aberto;
        private void btnPerson_Click(object sender, EventArgs e)
        {
            OpenForms<Person>();
            btnPerson.BackColor = Color.FromArgb(12, 61, 92);
        }

        //Botão SideBar perde a cor ao formulário se fechado; 
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Person"] == null)
                btnPerson.BackColor = Color.FromArgb(4, 41, 68);
        }

        //carrega formulario
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadUserData();
            ManagePermissions();
        }
        //administra as permissões
        private void ManagePermissions()
        {
            if (UserLoginCache.Position == PositionCache.Administrator)
            {
                //Codes
            }
        }
        //Mostrar os dados de quem está logado
        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirstName;
            lblPosition.Text = UserLoginCache.Position;
            dtpInfoDate.Format = DateTimePickerFormat.Custom;
            dtpInfoDate.CustomFormat = "dd/MM/yy - H:mm";
        }
        //Faz o logout do sistema
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}