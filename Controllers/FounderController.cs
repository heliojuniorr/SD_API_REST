using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using APIREST.Models;

namespace APIREST.Controllers
{
    [RoutePrefix("api/founder")]
    public class FounderController : ApiController
    {
        private static List<FounderModel> listaFundadores = new List<FounderModel>();
        [AcceptVerbs("POST")]
        [Route("CadastrarFundador")]
        public string CadastrarFundador(FounderModel fundador)
        {
            listaFundadores.Add(fundador);
            return "Fundador cadastrado com sucesso!";
        }
        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public string AlterarFundador(FounderModel fundador)
        {
            listaFundadores.Where(n => n.Codigo ==
            fundador.Codigo)
            .Select(s =>
            {
                s.Codigo = fundador.Codigo;
                s.Nome = fundador.Nome;
                s.Startups = fundador.Startups;
                return s;
            }).ToList();
            return "Fundador alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirFundador/{codigo}")]
        public string ExcluirFundador(int codigo)
        {
            FounderModel fundador = listaFundadores.Where(n => n.Codigo == codigo)
            .Select(n => n)
            .First();
            listaFundadores.Remove(fundador);
            return "Registro excluido com sucesso!";
        }
        [AcceptVerbs("GET")]
        [Route("ConsultarFundadorPorCodigo/{codigo}")]
        public FounderModel ConsultarFundadorPorCodigo(int codigo)
        {
            FounderModel fundador = listaFundadores.Where(n => n.Codigo == codigo)
            .Select(n => n)
            .FirstOrDefault();
            return fundador;
        }
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarios")]
        public List<FounderModel> ConsultarFundadores()
        {
            CarregarFundadores();
            return listaFundadores;
        }
        private void CarregarFundadores()
        {
            listaFundadores.Clear();
            listaFundadores.Add(new FounderModel(1, "NOME1", "startup 1"));
            listaFundadores.Add(new FounderModel(2, "NOME2", "startup 2"));
        }
    }
}