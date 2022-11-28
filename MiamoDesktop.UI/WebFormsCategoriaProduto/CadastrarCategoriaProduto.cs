using Miamo.BLL;
using Miamo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiamoDesktop.UI.WebFormsProduto
{
    public partial class CadastrarCategoriaProduto : Form
    {
        public CadastrarCategoriaProduto()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtNomeCategoriaProduto.Text = string.Empty;
            txtNomeCategoriaProduto.Focus();
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
            CategoriaDTO objCAD = new CategoriaDTO();

            objCAD.NomeCategoria = txtNomeCategoriaProduto.Text;

            CategoriaBLL objCadastra = new CategoriaBLL();
            objCadastra.CadastraCategoria(objCAD);
            Limpar();

            MessageBox.Show("Categoria de produto " + objCAD.NomeCategoria + " cadastrada com sucesso!!");
        }
    }
}
