﻿using FestaInfantil.Dominio.ModuloCompartilhado;
using System.Text.RegularExpressions;
using System;
using System.Text.RegularExpressions;
using FestaInfantil.Dominio.ModuloFesta;

namespace FestaInfantil.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }

        public bool temDesconto = false;

        public List<Festa> festas;

        public  int contador = 0;

        public bool alugado = false;

        private Cliente cliente;

        public Cliente()
        {
            
        }

        public Cliente(string nome, string telefone, string endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
            festas = new List<Festa>();
        }

        public override string ToString()
        {
            return nome;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome) || nome.Length < 5)
                erros.Add("O campo nome esta invalido!");

            if(!VerificarNumeroTelefone(telefone))
                erros.Add("O campo telefone esta invalido!");

            if (string.IsNullOrEmpty(endereco) || endereco.Length < 10)
                erros.Add("O campo endereco esta invalido!");

            return erros.ToArray();

        }

        public override void AtualizarInformacoes(Cliente registroAtualziado)
        {
            this.nome = registroAtualziado.nome;
            this.telefone = registroAtualziado.telefone;
            this.endereco = registroAtualziado.endereco;
        }

        public bool VerificarNumeroTelefone(string telefone)
        {
            string cel = telefone;

            cel = Regex.Replace(cel, @"\s+", "");

            bool numeroValido = Regex.IsMatch(cel, @"^\d{2}\d{9}$");

            if (numeroValido)
                return true;

            else
                return false;

        }
    }
}
