﻿using FestaAniversario.Infra.Dados.Arquivo.ModuloCliente;
using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestaAniversario.Infra.Dados.Arquivo.ModuloTema;
using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema repositorioTema;
        private IRepositorioItens repositorioItens;

        ListagemTemaControl listagemTema = new ListagemTemaControl();
        public ControladorTema(IRepositorioTema repositorioTema, IRepositorioItens repositorioItens)
        {
            this.repositorioTema = repositorioTema;
            this.repositorioItens = repositorioItens;
        }

        public override string ToolTipInserir => "Inserir Tema";

        public override string ToolTipEditar => "Editar Tema";

        public override string ToolTipExcluir => "Excluir Tema";

        public override void Editar()
        {
            Tema tema = ObterTemaSelecionado();

            if (tema == null)
            {
                MessageBox.Show("Selecione um tema primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTema telaTema = new TelaTema(repositorioItens, tema);
            int id = tema.id;

            telaTema.Tema = tema;

            bool nomeRepetido = false;

            do
            {
                if (telaTema.ShowDialog() == DialogResult.OK)
                {
                    Tema temaEditado = telaTema.Tema;

                    List<Tema> listaTemas = repositorioTema.SelecionarTodos();

                    if (listaTemas.Any(t => t.descricao.ToLower() == temaEditado.descricao.ToLower() && t.id != id))
                    {
                        TelaPrincipal.Instancia.AtualizarRodape("Descrição já utilizada!");
                        nomeRepetido = true;
                    }
                    else
                    {
                        temaEditado.id = id;
                        repositorioTema.Editar(id, temaEditado);
                        CarregarTemas();
                        nomeRepetido = false;
                    }
                }
                else
                {
                    nomeRepetido = false;
                }
            } while (nomeRepetido);
        }


        public override void Excluir()
        {
            Tema tema = ObterTemaSelecionado();

            if (tema == null)
            {
                MessageBox.Show("Selecione um tema primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if(tema.contador > 0)
            //{
            //    TelaPrincipal.Instancia.AtualizarRodape("Esse tema possui uma festa em aberto, não é possivel excluí-lo");
            //    return;
            //}

            DialogResult verificarExclusao = MessageBox.Show($"Deseja excluir o tema {tema.descricao}?", "Exclusão de Temas",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(verificarExclusao == DialogResult.OK)
            {
                foreach(Itens item in tema.itensCheck)
                {
                    item.contador--;
                }

                repositorioTema.Excluir(tema);
                CarregarTemas();
            }
        }

        public override void Inserir()
        {
            TelaTema telaTema = new TelaTema(repositorioItens);

            if(telaTema.ShowDialog() == DialogResult.OK)
            {
                List<Tema> listaTema = repositorioTema.SelecionarTodos();

                Tema tema = telaTema.Tema;

                if(listaTema.Any(x => x.descricao.ToLower() == tema.descricao.ToLower()))
                {
                    TelaPrincipal.Instancia.AtualizarRodape("Nao é possivel cadastrar um tema com a mesma descrição de outro tema!");
                    return;
                }

                repositorioTema.Inserir(tema);

                CarregarTemas();
            }
        }

        public Tema ObterTemaSelecionado()
        {
            int id = listagemTema.ObterIdSelecionado();

            return repositorioTema.SelecionarPorId(id);
        }

        public void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            
            listagemTema.AtualizarRegistros(temas);
        }

        public override UserControl ObterListagem()
        {
            if (listagemTema == null)
                listagemTema = new ListagemTemaControl();

            CarregarTemas();
            return listagemTema;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }

        public override void RealizarPagamento()
        {
            throw new NotImplementedException();
        }
    }
}
