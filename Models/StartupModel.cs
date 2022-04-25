using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIREST.Models
{
    public class StartupModel
    {
        private int codigo;
        private string nome;
        private string founders;
        public StartupModel() { }
        public StartupModel(int codigo, string nome, string founders)
        {
            this.Codigo = codigo
            ;
            this.Nome = nome;
            this.Founders = founders;
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
        public string Founders
        {
            get
            { return founders; }
            set { founders = value; }
        }
    }
}