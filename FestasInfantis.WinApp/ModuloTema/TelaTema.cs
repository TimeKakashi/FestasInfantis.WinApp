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
        public TelaTema()
        {
            InitializeComponent();
        }

        private Tema tema;

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

            foreach (Itens item in listaItensTema.Items)
            {
                valor += item.valor;
            }

            tema = new Tema(descricao, valor);

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                DialogResult = DialogResult.None;
            }
        }
    }
}
