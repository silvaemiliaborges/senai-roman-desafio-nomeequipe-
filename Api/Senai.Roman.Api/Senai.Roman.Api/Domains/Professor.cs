using System;
using System.Collections.Generic;

namespace Senai.Roman.Api.Domains
{
    public partial class Professor
    {
        public Professor()
        {
            Projeto = new HashSet<Projeto>();
        }

        public int IdProfessor { get; set; }
        public string NomeDoProfessor { get; set; }
        public int IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public ICollection<Projeto> Projeto { get; set; }
    }
}
