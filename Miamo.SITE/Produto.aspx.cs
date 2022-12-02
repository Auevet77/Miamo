using Miamo.BLL;
using Miamo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Miamo.SITE
{
    public partial class Produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(Request.QueryString["id"]);

            ProdutoBLL objProdutoBLL = new ProdutoBLL();

            ProdutoListDTO produtoDTO = objProdutoBLL.SelecionarProduto(idProduto);

            lblNome.Text = produtoDTO.NomeProduto;
            lblTamanho.Text = produtoDTO.TamanhoProduto;
            lblPreco.Text = produtoDTO.PrecoProduto.ToString();            
            lblCor.Text = produtoDTO.CorProduto;
            lblCategoriaProduto.Text = produtoDTO.CategoriaProduto;
            lblDescricao.Text = produtoDTO.DescricaoProduto;
            imgProduto.ImageUrl = produtoDTO.UrlImagemProduto.Replace("~", ".");

        }
    }
}