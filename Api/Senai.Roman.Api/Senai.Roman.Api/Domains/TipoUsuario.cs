using System;
using System.Collections.Generic;

namespace Senai.Roman.Api.Domains
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Professor = new HashSet<Professor>();
        }

        public int IdTipoUsuario { get; set; }
        public string Nome { get; set; }

        public ICollection<Professor> Professor { get; set; }
    }
}
