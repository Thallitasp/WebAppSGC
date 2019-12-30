using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Fulano da Silva",
                    Cpf = "111111112"
                },

                new Cliente
                {
                    Nome = "Beltrano da Silva",
                    Cpf = "111111113"
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "37552675",
                    Email = "contato1@email.com",
                    Cliente = clientes[0]
                },

                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "37552775",
                    Email = "contato2@email.com",
                    Cliente = clientes[1]
                },

            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
