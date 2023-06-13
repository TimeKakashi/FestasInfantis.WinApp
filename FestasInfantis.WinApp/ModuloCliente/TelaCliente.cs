using FestaInfantil.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            set
            {
                tbEndereco.Text = value.endereco;
                tbNome.Text = value.nome;
                tbNumero.Text = value.telefone;
            }
            get
            {
                return cliente;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string endereco = tbEndereco.Text;
            string telefone = tbNumero.Text;



            cliente = new Cliente(nome, telefone, endereco);

            string[] erros = cliente.Validar();

            if(erros.Length > 0) 
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
