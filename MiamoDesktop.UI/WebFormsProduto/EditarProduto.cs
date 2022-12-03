using Miamo.BLL;
using Miamo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiamoDesktop.UI.WebFormsProduto
{
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtId.Text = txtNomeProduto.Text = txtDescricaoProduto.Text = txtTamanhoProduto.Text = txtPrecoProduto.Text = txtCorProduto.Text = txtFornecedorProduto.Text = string.Empty;
            cboCategoria.Text = "";
            picBox1.Image = null;
            gpBox1.Visible = gpBox2.Enabled = false;
            txtId.Enabled = btnPesquisar.Enabled = true;
            txtId.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            gpBox1.Visible = gpBox2.Enabled = false;
            txtId.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpBox1.Visible = true;
            gpBox2.Enabled = true;
            txtId.Enabled = btnPesquisar.Enabled = false;

            //checando preenchimento do campo Id
            int codigo;
            if (!int.TryParse(txtId.Text, out codigo))
            {
                Limpar();
                MessageBox.Show("Digite o Id da Categoria!!");
                txtId.Focus();
                btnPesquisar.Enabled = true;
                return;
            }

            //chamando metodos
            codigo = Convert.ToInt32(txtId.Text);
            ProdutoListDTO objPesquisa = new ProdutoListDTO();//modelo
            ProdutoBLL objPesqBLL = new ProdutoBLL();//metodo
            objPesquisa = objPesqBLL.SelecionarProduto(codigo);

            if (objPesquisa.NomeProduto != null)
            {
                CategoriaBLL objCadastra = new CategoriaBLL();

                List<CategoriaDTO> listarCategoria = objCadastra.ListarCategoria();

                cboCategoria.DataSource = listarCategoria;
                cboCategoria.DisplayMember = "NomeCategoria";
                cboCategoria.ValueMember = "IdCategoria";
                //cboCategoria.Text = "";

                //habilitando componentes
                txtNomeProduto.Text = objPesquisa.NomeProduto;
                txtDescricaoProduto.Text = objPesquisa.DescricaoProduto;
                txtTamanhoProduto.Text = objPesquisa.TamanhoProduto;
                txtPrecoProduto.Text = objPesquisa.PrecoProduto.ToString("C2");
                txtCorProduto.Text = objPesquisa.CorProduto;
                cboCategoria.Text = objPesquisa.CategoriaProduto.ToString();
                txtFornecedorProduto.Text = objPesquisa.IdFornecedor.ToString();
                picBox1.ImageLocation = objPesquisa.UrlImagemProduto;
            }
            else
            {
                Limpar();
                MessageBox.Show("Não rolou a busca !!!");
                return;
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ProdutoDTO objPesquisa = new ProdutoDTO();//Modelo
            ProdutoBLL objPesqBLL = new ProdutoBLL();//Modelo
            objPesquisa.IdProduto = Convert.ToInt32(txtId.Text);
            objPesquisa.NomeProduto = txtNomeProduto.Text;
            objPesquisa.DescricaoProduto = txtDescricaoProduto.Text;
            objPesquisa.TamanhoProduto = txtTamanhoProduto.Text;
            objPesquisa.PrecoProduto = Convert.ToDecimal(txtPrecoProduto.Text.Replace("R$",""));
            objPesquisa.CorProduto = txtCorProduto.Text;
            objPesquisa.IdCategoriaProduto = cboCategoria.SelectedValue.ToString();
            objPesquisa.IdFornecedor = Convert.ToInt32(txtFornecedorProduto.Text);

            //salvando a URL da imagem
            if (picBox1.Image != null)
            {
                string nomeImg = txtNomeProduto.Text + ".jpg";
                string pasta = @"C:\Users\romilson.gmonteiro\source\repos\Miamo\Miamo.SITE\Img";              
                string caminhoImg = Path.Combine(pasta, nomeImg);
                objPesquisa.UrlImagemProduto = caminhoImg;

                //salvando na pasta
                Image a = picBox1.Image;
                a.Save(caminhoImg);
            }
            else
            {
                MessageBox.Show("Selecione uma imagem!!");
                return;
            }

            objPesqBLL.EditarProduto(objPesquisa);
            Limpar();
            MessageBox.Show("Produto editado com sucesso!!");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja mesmo eliminar o registro?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //manipulando o valor escolhido mo messagebox
            if (msg == DialogResult.Yes)
            {
                ProdutoBLL objExcluiBLL = new ProdutoBLL();//metodo
                int codigo = Convert.ToInt32(txtId.Text);
                objExcluiBLL.ExcluirProduto(codigo);
                Limpar();
            }
            else if (msg == DialogResult.No)
            {
                Limpar();
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            //carregando imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                picBox1.ImageLocation = img;
            }
        }

        private void txtPrecoProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal Valor = Convert.ToDecimal(txtPrecoProduto.Text.Replace("R$", ""));
                txtPrecoProduto.Text = Valor.ToString("C2");

            }
            catch
            {
                txtPrecoProduto.Text = "";
            }
        }

        private void txtPrecoProduto_Enter(object sender, EventArgs e)
        {
            txtPrecoProduto.Text = txtPrecoProduto.Text.Replace("R$ ", "");
        }
    }
}
