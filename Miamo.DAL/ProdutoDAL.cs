using Miamo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamo.DAL
{
    public class ProdutoDAL : Conexao
    {
        //inserir
        public void Cadastrar(ProdutoDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Produto (NomeProduto,DescricaoProduto,TamanhoProduto,PrecoProduto,CorProduto,UrlImagemProduto,IdCategoriaProduto,IdFornecedor) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.NomeProduto);
                cmd.Parameters.AddWithValue("@v2", objCad.DescricaoProduto);
                cmd.Parameters.AddWithValue("@v3", objCad.TamanhoProduto);
                cmd.Parameters.AddWithValue("@v4", objCad.PrecoProduto);
                cmd.Parameters.AddWithValue("@v5", objCad.CorProduto);
                cmd.Parameters.AddWithValue("@v6", objCad.UrlImagemProduto);
                cmd.Parameters.AddWithValue("@v7", objCad.IdCategoriaProduto);
                cmd.Parameters.AddWithValue("@v8", objCad.IdFornecedor);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //listar
        public List<ProdutoListDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdProduto, NomeProduto , DescricaoProduto , TamanhoProduto , CorProduto , PrecoProduto , NomeCategoria FROM Produto JOIN CategoriaProduto ON IdCategoriaProduto = IdCategoria", conn);
                dr = cmd.ExecuteReader();
                List<ProdutoListDTO> Lista = new List<ProdutoListDTO>();
                while (dr.Read())
                {
                    ProdutoListDTO obj = new ProdutoListDTO();
                    obj.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    obj.NomeProduto = dr["NomeProduto"].ToString();
                    obj.DescricaoProduto = dr["DescricaoProduto"].ToString();
                    obj.TamanhoProduto = dr["TamanhoProduto"].ToString();
                    obj.PrecoProduto = dr["PrecoProduto"].ToString();
                    obj.CorProduto = dr["CorProduto"].ToString();                    
                    obj.CategoriaProduto = dr["NomeCategoria"].ToString();

                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Produto!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        //editar
        public void Editar(ProdutoDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Produto SET NomeProduto=@v1,TamanhoProduto=@v2,PrecoProduto=@v3,CorProduto=@v4,UrlImagemProduto=@v5,IdCategoriaProduto=@v6, DescricaoProduto=@v8, IdFornecedor=@v9 WHERE IdProduto=@v7", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.NomeProduto);
                cmd.Parameters.AddWithValue("@v2", objEdita.TamanhoProduto);
                cmd.Parameters.AddWithValue("@v3", objEdita.PrecoProduto);
                cmd.Parameters.AddWithValue("@v4", objEdita.CorProduto);
                cmd.Parameters.AddWithValue("@v5", objEdita.UrlImagemProduto);
                cmd.Parameters.AddWithValue("@v6", objEdita.IdCategoriaProduto);
                cmd.Parameters.AddWithValue("@v7", objEdita.IdProduto);
                cmd.Parameters.AddWithValue("@v8", objEdita.DescricaoProduto);
                cmd.Parameters.AddWithValue("@v9", objEdita.IdFornecedor);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar o registro!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        //excluir
        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Produto WHERE IdProduto=@v6", conn);
                cmd.Parameters.AddWithValue("@v6", objExclui);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o registro!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        //filtrar
        public List<FiltroProdutoDTO> Filtrar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdProduto,DescricaoProduto,NomeProduto,TamanhoProduto,PrecoProduto,CorProduto,UrlImagemProduto,NomeCategoria FROM Produto JOIN CategoriaProduto ON IdCategoriaProduto = IdCategoria", conn);
                dr = cmd.ExecuteReader();
                List<FiltroProdutoDTO> Lista = new List<FiltroProdutoDTO>();
                while (dr.Read())
                {
                    FiltroProdutoDTO obj = new FiltroProdutoDTO();
                    obj.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    obj.NomeProduto = dr["NomeProduto"].ToString();
                    obj.TamanhoProduto = dr["TamanhoProduto"].ToString();
                    obj.PrecoProduto = dr["PrecoProduto"].ToString();
                    obj.CorProduto = dr["CorProduto"].ToString();
                    obj.UrlImagemProduto = dr["UrlImagemProduto"].ToString();
                    obj.CategoriaProduto = dr["NomeCategoria"].ToString();
                    obj.DescricaoProduto = dr["DescricaoProduto"].ToString();
                    

                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar Produto!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        public List<FiltroProdutoDTO> Filtrar(int IdCategoria)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdProduto,DescricaoProduto,NomeProduto,TamanhoProduto,PrecoProduto,CorProduto,UrlImagemProduto,NomeCategoria FROM Produto JOIN CategoriaProduto ON IdCategoriaProduto =IdCategoria WHERE IdCategoriaProduto = @v1", conn);
                cmd.Parameters.AddWithValue("@v1", IdCategoria);

                dr = cmd.ExecuteReader();
                List<FiltroProdutoDTO> Lista = new List<FiltroProdutoDTO>();
                while (dr.Read())
                {
                    FiltroProdutoDTO obj = new FiltroProdutoDTO();
                    obj.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    obj.NomeProduto = dr["NomeProduto"].ToString();
                    obj.TamanhoProduto = dr["TamanhoProduto"].ToString();
                    obj.PrecoProduto = dr["PrecoProduto"].ToString();
                    obj.CorProduto = dr["CorProduto"].ToString();
                    obj.UrlImagemProduto = dr["UrlImagemProduto"].ToString();
                    obj.CategoriaProduto = dr["NomeCategoria"].ToString();
                    obj.DescricaoProduto = dr["DescricaoProduto"].ToString();

                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar Produto!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }


        public ProdutoListDTO Selecionar(int idProduto)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdProduto,NomeProduto,DescricaoProduto,TamanhoProduto,PrecoProduto,CorProduto,UrlImagemProduto,NomeCategoria FROM Produto JOIN CategoriaProduto ON IdCategoriaProduto = IdCategoria WHERE IdProduto=" + idProduto, conn);
                dr = cmd.ExecuteReader();
                ProdutoListDTO obj = new ProdutoListDTO();
                if (dr.Read())
                {
                    obj.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    obj.NomeProduto = dr["NomeProduto"].ToString();
                    obj.TamanhoProduto = dr["TamanhoProduto"].ToString();
                    obj.PrecoProduto = dr["PrecoProduto"].ToString();
                    obj.CorProduto = dr["CorProduto"].ToString();
                    obj.UrlImagemProduto = dr["UrlImagemProduto"].ToString();
                    obj.CategoriaProduto = dr["NomeProduto"].ToString();
                    obj.DescricaoProduto = dr["DescricaoProduto"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao selecionar Produto!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }


    }
}