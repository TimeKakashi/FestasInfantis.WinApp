using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public partial class FiltroDeFesta : Form
    {
        public FiltroDeFesta()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    string filtro = radioButton.Text;
                    break;
                }
            }
        }

        public string ObterStatus()
        {
            if (rbAbertas.Checked)
            {
                return "abertas";
            }
            else if (rbFinalizadas.Checked)
            {
                return "finalizadas";
            }
            else if (rbEndereco.Checked)
            {
                return "endereco";
            }
            else
                return "todas";
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}