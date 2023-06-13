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

        private Tema tema;
        private IRepositorioItens repositorioItens;
        public Tema Tema
        {
            set
            {
                tbDescricao.Text = value.descricao;
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

            foreach (Itens item in listaItensTema.CheckedItems)
            {

                valor += Convert.ToDecimal(item.valor);
            }

            tema = new Tema(descricao, valor);

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                DialogResult = DialogResult.None;
            }
        }

        public void PopularCBItens()
        {
            List<Itens> listaItens = repositorioItens.SelecionarTodos();

            foreach(Itens item in listaItens)
            {
                listaItensTema.Items.Add(item);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
