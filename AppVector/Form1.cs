using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVector
{
    public partial class Frmvectores : Form
    {
        //creando una instancia de mi clase vector
        clsVector v = new clsVector();
        public Frmvectores()
        {
            InitializeComponent();
        }
        private void mostrarVector() {
            lbresultado.Text = "";
            for (int i = 0; i < v.longitud(); i++) {
                lbresultado.Text = lbresultado.Text + v.obtenervalor(i) + ",";
            }
            lbresultado.Text = lbresultado.Text + "]";
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        

        private void cantidaddeParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.cantPares();
            MessageBox.Show("Cant. de Elementos pares: " + c.ToString());

        }

        private void ordenarMenorAmayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.OrdenarMenorAmayor();
            mostrarVector();
        }

        private void eliminarElementoPosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt16(txtvalor.Text);
            v.EliminarElementoPos(p);
            mostrarVector();
        }

        private void invertirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
              v.invertir();
            mostrarVector();
        }

        private void invertirCadaEDelVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.InvertirCadaElemento();
            mostrarVector();
        }

        private void cantidadDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidadCapicua = v.CantCapicua();
            MessageBox.Show("La cantidad de números capicúa es: " + cantidadCapicua);
        }

        private void cantidadDeEPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CantPrimos = v.CantPrimos();
            MessageBox.Show("La cantidad de números Primo es: " + CantPrimos);
        }
    }
}
