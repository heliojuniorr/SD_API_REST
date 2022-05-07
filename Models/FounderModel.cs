using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIREST.Models
{
    public class FounderModel
    {
        private int codigo;
        private string nome;
        private string startups;
        public FounderModel() { }
        public FounderModel
        (int codigo, string nome, string startups)
        {
            this.Codigo = codigo
            ;
            this.Nome = nome;
            this.Startups = startups;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Startups
        {
            get
            { return startups; }
            set { startups = value; }
        }

    }
}