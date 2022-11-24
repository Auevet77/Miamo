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
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtNomeProduto.Text = txtDescricaoProduto.Text = txtTamanhoProduto.Text = txtPrecoProduto.Text = txtCorProduto.Text = txtImagemProduto.Text = txtCategoriaProduto.Text = txtFornecedorProduto.Text = string.Empty;
            //rb1.Checked = false; rb2.Checked = false;
            txtNomeProduto.Focus();
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
            ProdutoDTO objCAD = new ProdutoDTO();

            objCAD.NomeProduto = txtNomeProduto.Text;
            objCAD.DescricaoProduto = txtDescricaoProduto.Text;
            objCAD.TamanhoProduto = txtTamanhoProduto.Text;
            objCAD.PrecoProduto = txtPrecoProduto.Text;
            objCAD.CorProduto = txtCorProduto.Text;
            objCAD.UrlImagemProduto = txtImagemProduto.Text;
            objCAD.CategoriaProduto = txtCategoriaProduto.Text;
            
            ProdutoBLL objCadastra = new ProdutoBLL();
            objCadastra.CadastraProduto(objCAD);
            Limpar();

            MessageBox.Show("Produto " + objCAD.NomeProduto + " cadastrado com sucesso!!");

        }
    }
}
