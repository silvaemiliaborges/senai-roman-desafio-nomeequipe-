using Senai.Roman.Api.Domains;
using Senai.Roman.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Roman.Api.Interfase
{
    public interface IProfessorRepository
    {
        Professor BuscarPorEmailESenha(LoginViewModel login);

        
    }
}
