using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public partial class TelaFesta : Form
    {
        public TelaFesta(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();

            PopularComboBox(clientes, temas);
        }

        private Festa festa;
        public Festa Festa
        {
            set
            {
                TimeSpan horaInicio = value.horaInicio;
                TimeSpan horaFinal = value.horaFinal;

                string horaInicioString = $"{horaInicio.Hours:D2}:{horaInicio.Minutes:D2}";
                string horaFinalString = $"{horaFinal.Hours:D2}:{horaFinal.Minutes:D2}";

                dtHoraInicio.CustomFormat = "HH:mm";
                dtHoraTermino.CustomFormat = "HH:mm";

                tbEndereco.Text = value.enderecoFesta;
                tbValorEntrada.Text = value.valorEntrada.ToString();
                dtData.Text = value.data.ToString();

                dtHoraInicio.Format = DateTimePickerFormat.Custom;
                dtHoraInicio.Value = DateTime.ParseExact(horaInicioString, "HH:mm", CultureInfo.InvariantCulture);
                dtHoraTermino.Format = DateTimePickerFormat.Custom;
                dtHoraTermino.Value = DateTime.ParseExact(horaFinalString, "HH:mm", CultureInfo.InvariantCulture);

                cbCliente.SelectedItem = value.cliente;
                cbTema.SelectedItem = value.tema;

            }

            get
            {
                return festa;
            }
        }

        public void PopularComboBox(List<Cliente> clientes, List<Tema> temas)
        {
            foreach (Cliente cliente in clientes)
            {
                cbCliente.Items.Add(cliente);
            }

            foreach (Tema tema in temas)
            {
                cbTema.Items.Add(tema);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string endereco = tbEndereco.Text;
            TimeSpan horaComeco = dtHoraInicio.Value.TimeOfDay;
            TimeSpan horaFinal = dtHoraTermino.Value.TimeOfDay;
            DateTime data = dtData.Value;

            Tema tema = (Tema)cbTema.SelectedItem;
            Cliente cliente = (Cliente)cbCliente.SelectedItem;

            decimal valorTotal = 0;

            if (tema == null)
            {
                TelaPrincipal.Instancia.AtualizarRodape("O Campo tema é obrigatorio!");
                DialogResult = DialogResult.None;
            }


            else if (cliente == null)
            {
                TelaPrincipal.Instancia.AtualizarRodape("O Campo cliente é obrigatorio!");
                DialogResult = DialogResult.None;
            }

            else
            {
                foreach (Itens item in tema.itensCheck)
                {
                    valorTotal += Convert.ToDecimal(item.valor);
                }

                int numeroAlugueisCliente = cliente.festas.Count;
                decimal valorDesconto = 0;

                switch (numeroAlugueisCliente)
                {
                    case 0:
                        valorDesconto = 1;
                        break;

                    case 1:
                        valorDesconto = 0.95m;
                        break;

                    case 2:
                        valorDesconto = 0.9m;
                        break;

                    case 3:
                        valorDesconto = 0.85m;
                        break;

                    default:
                        valorDesconto = 0.85m;
                        break;
                }

                //valorTotal -= valorTotal / valorDesconto;
                valorTotal *= valorDesconto;


                cliente.temDesconto = true;
                cliente.alugado = true;


                festa = new Festa(endereco, cliente, tema, data, horaComeco, horaFinal, valorTotal);

                festa.cliente.festas.Add(festa);
                festa.cliente.contador++;

                string[] erros = festa.Validar();

                if (erros.Length > 0)
                {
                    TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                    DialogResult = DialogResult.None;
                }
            }


        }

        private void cbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal valorTotal = 0;

            Tema tema = cbTema.SelectedItem as Tema;

            foreach (Itens item in tema.itensCheck)
            {
                valorTotal += item.valor;
            }

            string valorEntrada = (valorTotal / 2).ToString();

            tbValorEntrada.Text = valorEntrada;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {

        }
    }
}
