﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public ICollection<Contato> Contatos { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}
