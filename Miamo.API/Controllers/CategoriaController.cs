using Miamo.BLL;
using Miamo.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Miamo.API.Controllers
{
    public class CategoriaController : ApiController
    {
        //listar todos generos
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            var categoriaBLL = new CategoriaBLL();
            var listaCategoria = categoriaBLL.ListarCategoria();

            return Ok(listaCategoria);

        }

        //selecionar um genero por id
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get(int id)
        {
            var categoriaBLL = new CategoriaBLL();
            var categoria = categoriaBLL.SelecionarCategoria(id);

            return Ok(categoria);
        }

        //cadastrar Genero
        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(CategoriaDTO dados)
        {
            try
            {
                var categoriaBLL = new CategoriaBLL();
                categoriaBLL.CadastraCategoria(dados);

                return Ok();
            }
            catch
            {
                return BadRequest("Erro ao cadastrar");
            }
        }

        //Atualizar Genero
        [System.Web.Http.HttpPut]
        public IHttpActionResult Put(CategoriaDTO dados)
        {
            try
            {
                var categoriaBLL = new CategoriaBLL();
                categoriaBLL.EditarCategoria(dados);

                return Ok();
            }
            catch
            {
                return BadRequest("Erro ao atualizar");
            }
        }

        //Excluir Genero
        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var categoriaBLL = new CategoriaBLL();
                categoriaBLL.ExcluirCategoria(id);

                return Ok();
            }
            catch
            {
                return BadRequest("Erro ao Excluir");
            }
        }
    }
}
