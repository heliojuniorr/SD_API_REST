using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using APIREST.Models;

namespace APIREST.Controllers
{
    [RoutePrefix("api/startup")]
    public class StartupController : ApiController
    {
        private static List<StartupModel> listaStartups = new
        List<StartupModel>();
        [AcceptVerbs("POST")]
        [Route("CadastrarStartup")]
        public string CadastrarStartup(StartupModel startup)
        {
            listaStartups.Add(startup);
            return "Startup cadastrada com sucesso!";
        }
        [AcceptVerbs("PUT")]
        [Route("AlterarStartup")]
        public string AlterarStartup(StartupModel startup)
        {
            listaStartups.Where(n => n.Codigo ==
            startup.Codigo)
            .Select(s =>
            {
                s.Codigo = startup.Codigo;
                s.Nome = startup.Nome;
                s.Founders = startup.Founders;
                return s;
            }).ToList();
            return "Startup alterada com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirStartup/{codigo}")]
        public string ExcluirStartup(int codigo)
        {
            StartupModel startup = listaStartups.Where(n => n.Codigo == codigo)
            .Select(n => n)
            .First();
            listaStartups.Remove(startup);
            return "Registro excluido com sucesso!";
        }
        [AcceptVerbs("GET")]
        [Route("ConsultarStartupPorCodigo/{codigo}")]
        public StartupModel ConsultarStartupPorCodigo(int codigo)
        {
            StartupModel startup = listaStartups.Where(n => n.Codigo == codigo)
            .Select(n => n)
            .FirstOrDefault();
            return startup;
        }
        [AcceptVerbs("GET")]
        [Route("ConsultarStartups")]
        public List<StartupModel> ConsultarStartups()
        {
            CarregarStartups();
            return listaStartups;
        }
        private void CarregarStartups()
        {
            listaStartups.Clear();
            listaStartups.Add(new StartupModel(1, "NOME1", "founder 1"));
            listaStartups.Add(new StartupModel(2, "NOME2", "founder 2"));
        }
    }
}