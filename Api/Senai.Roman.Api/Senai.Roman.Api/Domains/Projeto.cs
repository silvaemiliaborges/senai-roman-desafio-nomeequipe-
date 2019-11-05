using System;
using System.Collections.Generic;

namespace Senai.Roman.Api.Domains
{
    public partial class Projeto
    {
        public int IdProjeto { get; set; }
        public string Nome { get; set; }
        public string Tema { get; set; }
        public int? NomeDoProfessor { get; set; }

        public Professor NomeDoProfessorNavigation { get; set; }
    }
}
