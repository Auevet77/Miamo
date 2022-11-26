using Miamo.DTO;
using Miamo.BLL;
using System.IO;
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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        //limpar
        public void Limpar()
        {
            txtNome.Text = txtSenha.Text = txtEmail.Text = string.Empty;
            rb1.Checked = false; rb2.Checked = false;
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioDTO objCAD = new UsuarioDTO();

            objCAD.NomeUsuario = txtNome.Text;
            objCAD.SenhaUsuario = txtSenha.Text;
            objCAD.EmailUsuario = txtEmail.Text;

            if (rb1.Checked)
            {
                objCAD.TpUsuario = "1";
            }
            else if (rb2.Checked)
            {
                objCAD.TpUsuario = "2";
            }
            
            UsuarioBLL objCadastra = new UsuarioBLL();
            objCadastra.CadastraUsuario(objCAD);
            Limpar();

            MessageBox.Show("Usuário " + objCAD.NomeUsuario + " cadastrado com sucesso!!");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
