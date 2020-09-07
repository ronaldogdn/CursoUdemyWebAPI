using API_asp.net_core_curso_Udemy.DataBase;
using API_asp.net_core_curso_Udemy.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_asp.net_core_curso_Udemy.Controllers
{
    //ControllerBase é mais indica para criação da API pois não tem View
    public class PalavrasController : ControllerBase
    {
        private readonly MimicContext _banco;
        public PalavrasController(MimicContext banco)
        {
            _banco = banco;
        }
        //também pode ser IActionResult
        //ambiente do aplicativo
        public ActionResult ObterTodas()
        {
            //transforma para Json
            //return new JsonResult(_banco.Palavras);
            //ou Ok converte para o tipo mais comum que é o Json
            return Ok(_banco.Palavras);
        }
        //WEB
        public ActionResult Obter(int id)
        {
            //procura pelo respectivo ID
            return Ok(_banco.Palavras.Find(id));
        }
        public ActionResult Cadastrar(Palavra palavra)
        {
            _banco.Palavras.Add(palavra);
            return Ok();
        }
        public ActionResult Atualizar(int id,Palavra palavra)
        {
            _banco.Palavras.Update(palavra);
            return Ok();
        }
        public ActionResult Deletar(int id)
        {
            _banco.Palavras.Remove(_banco.Palavras.Find(id));
            return Ok();
        }
    }
}
