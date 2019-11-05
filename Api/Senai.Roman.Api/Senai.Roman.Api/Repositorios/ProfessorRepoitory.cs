using Microsoft.EntityFrameworkCore;
using Senai.Roman.Api.Domains;
using Senai.Roman.Api.Interfase;
using Senai.Roman.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Roman.Api.Repositorios
{
    public class ProfessorRepoitory : IProfessorRepository
    {
        public Professor BuscarPorEmailESenha(LoginViewModel login)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Professor professor = ctx.Professor.FirstOrDefault(x => x.Email == login.Email && x.Senha == login.Senha);
                if (professor == null)
                    return null;
                return professor;
            }
        }
    }
}
