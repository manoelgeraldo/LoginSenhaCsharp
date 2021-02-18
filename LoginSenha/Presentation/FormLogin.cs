using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace Presentation
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Implementa o placeholder e faz a mudança da cor do usuario e senha;
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Usuário")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.LightGray;
            }
            txtUserName.BorderStyle = BorderStyle.None;
        }
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Usuário";
                txtUserName.ForeColor = Color.DarkGray;
            }
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Senha")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
            txtPass.BorderStyle = BorderStyle.None;
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Senha";
                txtPass.ForeColor = Color.DarkGray;
                txtPass.UseSystemPasswordChar = false;
            }
            txtPass.BorderStyle = BorderStyle.FixedSingle;
        }
        #endregion

        //Fechar formulário Login;
        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //end

        //Ativar botão Login;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "Usuário" && txtUserName.TextLength > 2)
            {
                if (txtPass.Text != "Senha")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUserName.Text, txtPass.Text);

                    if (validLogin == true)
                    {
                        FormMain mainMenu = new FormMain();
                        MessageBox.Show("Seja Bem-vindo" + " " +UserLoginCache.FirstName + " " + UserLoginCache.LastName, "CSharp Login");
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuário ou Senha não correspondem!");
                        txtPass.Text = "Senha";
                        txtUserName.Focus();
                    }
                }
                else
                {
                    msgError("Informe sua Senha!");
                    txtPass.Focus();
                }
            }
            else msgError("Informe seu Nome de Usuário e Senha!");
        }
        //Cria variável p mostrar msg de erro no login;
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "* " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUserName.Text = "Usuário";
            txtPass.Text = "Senha";
            txtPass.UseSystemPasswordChar = false;
            lblErrorMessage.Visible = false;
            this.Show();
        }
        #region ARRASTAR FORMULARIO;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnlLoginMain_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnlSideLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //Ativa cor do link com ponteiro
        private void linkPass_MouseEnter(object sender, EventArgs e)
        {
            linkPass.LinkColor = Color.DarkGray;
        }
        private void linkPass_MouseLeave(object sender, EventArgs e)
        {
            linkPass.LinkColor = Color.DimGray;
        }
    }
}