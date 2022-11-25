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

namespace MiamoDesktop.UI.WebFormsCategoriaProduto
{
    public partial class EditarCategoria : Form
    {
        public EditarCategoria()
        {
            InitializeComponent();
        }

        public void Limpar()
        {            
            txtId.Text = txtNomeCategoriaProduto.Text = string.Empty;
            gpBox1.Visible = gpBox2.Enabled = false;            
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpBox1.Visible = true;
            gpBox2.Enabled = true;

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
            CategoriaDTO objPesquisa = new CategoriaDTO();//modelo
            CategoriaBLL objPesqBLL = new CategoriaBLL();//metodo
            objPesquisa = objPesqBLL.SelecionarCategoria(codigo);

            if (objPesquisa.NomeCategoria != null)
            {

                //habilitando componentes
                txtNomeCategoriaProduto.Text = objPesquisa.NomeCategoria;
                
            }
            else
            {
                Limpar();
                MessageBox.Show("Não rolou a busca !!!");
                return;
            }



        }

        private void EditarCategoria_Load(object sender, EventArgs e)
        {
            gpBox1.Visible = gpBox2.Enabled = false;
            txtId.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CategoriaDTO objPesquisa = new CategoriaDTO();//Modelo
            CategoriaBLL objPesqBLL = new CategoriaBLL();//Modelo
            objPesquisa.IdCategoria = Convert.ToInt32(txtId.Text);
            objPesquisa.NomeCategoria = txtNomeCategoriaProduto.Text;

            objPesqBLL.EditarCategoria(objPesquisa);
            Limpar();
            MessageBox.Show("Categoria editada com sucesso!!");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
