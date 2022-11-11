using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paginadaPlanta
{
    public partial class Form1 : Form
    {
        public string Numbotao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Cinco_Click_1(object sender, EventArgs e)
        {
            if (Cinco.BackColor == Color.Blue)
            {
                TelaCompra1 compra = new TelaCompra1();
                compra.ShowDialog();
            }
        }

        private void Um_Click(object sender, EventArgs e)
        {
            if (Um.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            if (Tres.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            if (Dois.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            if (Quatro.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            if (Sete.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Oito_Click(object sender, EventArgs e)
        {
            if (Oito.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            if (Nove.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Onze_Click(object sender, EventArgs e)
        {
            if (Onze.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Dez_Click(object sender, EventArgs e)
        {
            if (Dez.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            if (Seis.BackColor == Color.Blue)
            {
                telaCompra compra = new telaCompra();
                compra.ShowDialog();
            }
        }
    }
}
