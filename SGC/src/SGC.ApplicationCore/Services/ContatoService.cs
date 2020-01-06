using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.ApplicationCore.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository ContatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            ContatoRepository = contatoRepository;
        }

        public Contato Adicionar(Contato entity)
        {
            return ContatoRepository.Adicionar(entity);
        }

        public void Atualizar(Contato entity)
        {
            ContatoRepository.Atualizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            return ContatoRepository.Buscar(predicado);
        }

        public Contato ObterPorId(int id)
        {
            return ContatoRepository.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return ContatoRepository.ObterTodos();
        }

        public void Remover(Contato entity)
        {
            ContatoRepository.Remover(entity);
        }
    }
}
