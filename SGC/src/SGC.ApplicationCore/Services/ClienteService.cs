using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC.ApplicationCore.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository ClienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            ClienteRepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente entity)
        {
            return ClienteRepository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
            ClienteRepository.Atualizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return ClienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return ClienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return ClienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            ClienteRepository.Remover(entity);
        }
    }
}
