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
    public partial class TelaCompra1 : Form
    {
        public TelaCompra1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venda vd = new venda();
            vd.ShowDialog();
        }
    }
}
