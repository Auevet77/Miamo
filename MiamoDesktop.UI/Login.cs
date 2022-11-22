using Miamo.BLL;
using Miamo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiamoDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //pegando informação digitada pelo usuario
                string objUser = txtUsuario.Text;
                string objSenha = txtSenha.Text;

                //iniciando objeto DTO
                UsuarioAutenticaDTO objModelo = new UsuarioAutenticaDTO();
                UsuarioBLL objValida = new UsuarioBLL();
                objModelo = objValida.AutenticarUser(objUser, objSenha);
                if (objModelo!= null)
                {
                    switch (objModelo.TpUsuario)
                    {
                        case "1":
                            Session.nomeUsuario = txtUsuario.Text.Trim();
                            MainAdm obj = new MainAdm();
                            obj.Show();
                            this.Visible = false;
                            break;
                        case "2":
                            Session.nomeUsuario = txtUsuario.Text.Trim();
                            MainUser obj2 = new MainUser();
                            obj2.Show();
                            this.Visible = false;
                            break;
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuário não cadastrado!!" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = txtSenha.Text = string.Empty;
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
