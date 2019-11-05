using Senai.Roman.Api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Roman.Api.Interfase
{
    public interface IProjetoRepository
    {
        List<Projeto> Listar();

        void Cadastrar(Projeto projeto);

        void Atulizar(Projeto projeto);

        void Deletar(int id);

        Projeto BuscarPorId(int id);


    }
}
