using FestaAniversario.Infra.Dados.Arquivo.ModuloItens;
using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTema : Form
    {

        public TelaTema(IRepositorioItens repositorio)
        {
            InitializeComponent();
            this.repositorioItens = repositorio;
            PopularCBItens();
        }

        public TelaTema(IRepositorioItens repositorio, Tema tema)
        {
            InitializeComponent();
            this.repositorioItens = repositorio;
            this.tema = tema;
            PopularCBItens(tema);
        }

        private Tema tema;
        private IRepositorioItens repositorioItens;
        public Tema Tema
        {
            set
            {
                tbDescricao.Text = value.descricao;
                DeixarItensMarcados(Tema);
            }
            get
            {
                return tema;
            }
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            string descricao = tbDescricao.Text;
            decimal valor = 0;
            List<Itens> listaItens = new List<Itens>();
            List<Itens> listaCheck = new List<Itens>();

            foreach (Itens item in listaItensTema.CheckedItems)
            {
                valor += item.valor;
                listaCheck.Add(item);
            }

            tema = new Tema(descricao, valor, listaItens, listaCheck);

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                DialogResult = DialogResult.None;
            }

            DescamarcarItens(tema);
        }

        public void DeixarItensMarcados(Tema tema)
        {
            foreach (Itens item in tema.itensCheck)
            {
                int index = listaItensTema.Items.IndexOf(item);

                listaItensTema.SetItemChecked(index, true);
            }
        }

        public void DescamarcarItens(Tema tema)
        {
            foreach (Itens item in tema.itensCheck)
            {
                if (!listaItensTema.CheckedItems.Contains(item))
                    tema.itensCheck.Remove(item);
            }
        }

        public void PopularCBItens(Tema tema)
        {
            List<Itens> listaItens = repositorioItens.SelecionarTodos();

            foreach (Itens item in listaItens)
            {
                listaItensTema.Items.Add(item);
            }

            foreach (Itens item in tema.itensCheck)
            {
                int index = listaItensTema.Items.IndexOf(item);

                if (index >= 0)
                {
                    listaItensTema.SetItemChecked(index, true);
                }
            }
        }

        public void PopularCBItens()
        {
            List<Itens> listaItens = repositorioItens.SelecionarTodos();

            foreach (Itens item in listaItens)
            {
                listaItensTema.Items.Add(item);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void listaItensTema_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
