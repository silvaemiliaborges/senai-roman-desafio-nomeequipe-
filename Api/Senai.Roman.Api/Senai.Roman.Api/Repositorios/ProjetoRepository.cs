using Senai.Roman.Api.Domains;
using Senai.Roman.Api.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Roman.Api.Repositorios
{
    public class ProjetoRepository : IProjetoRepository
    {

        public void Atulizar(Projeto projeto)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Projeto.Update(projeto);
                ctx.SaveChanges();
            }
        }

        public Projeto BuscarPorId(int id)
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Projeto.Find(id);
            }
        }

        public void Cadastrar(Projeto projeto)
            {
                using (RomanContext ctx = new RomanContext())
                {
                    ctx.Projeto.Add(projeto);
                    ctx.SaveChanges();
                }
            }

        public void Deletar(int id)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Projeto projeto = ctx.Projeto.Find(id);
                ctx.Projeto.Remove(projeto);
                ctx.SaveChanges();
            }
        }

        public List<Projeto> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Projeto.ToList();
            }
        }
    }
    }

