using Miamo.BLL;
using Miamo.DTO;
using System.IO;
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
            txtNomeProduto.Text = txtDescricaoProduto.Text = txtTamanhoProduto.Text = txtPrecoProduto.Text = txtCorProduto.Text = txtCategoriaProduto.Text = txtFornecedorProduto.Text = string.Empty;
            picBox1.Image = null;
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
            objCAD.IdCategoriaProduto = txtCategoriaProduto.Text;
            objCAD.IdFornecedor = txtFornecedorProduto.Text;

            //salvando a URL da imagem
            string nomeImg = txtNomeProduto.Text + ".jpg";
            string pasta = @"C:\Users\romilson.gmonteiro\source\repos\Miamo1\Miamo.UI\Img";
            string caminhoImg = Path.Combine(pasta, nomeImg);
            objCAD.UrlImagemProduto = caminhoImg;

            //salvando na pasta
            Image a = picBox1.Image;
            a.Save(caminhoImg);


            ProdutoBLL objCadastra = new ProdutoBLL();
            objCadastra.CadastraProduto(objCAD);
            Limpar();

            MessageBox.Show("Produto " + objCAD.NomeProduto + " cadastrado com sucesso!!");

        }

        //carregar imagem
        private void btnImagem_Click(object sender, EventArgs e)
        {
            //carregando imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
            if (dialog.ShowDialog()== DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                picBox1.ImageLocation = img;
            }
        }
    }
}
