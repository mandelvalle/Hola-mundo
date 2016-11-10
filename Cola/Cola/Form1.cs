using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola
{
    public partial class Form1 : Form
    {
        Metodos Metodos = new Metodos();
        int cont = 0;
        int aux =0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {

            if (Metodos.EntraCliente() == true)
            {
                cont++;
                lbl2.Text = cont.ToString();
            }
            else
            {
                MessageBox.Show("Fila llena");
            }

        }

        private void btnCaja1_Click(object sender, EventArgs e)
        {
            if (aux < cont)
            {
                lblTurno.Visible = true;
                lbl3.Visible = true;
                lbl3.Text = Metodos.MPCliente();
                lblCaja.Visible = true;
                lbl4.Visible = true;
                lbl4.Text = "1";
                aux++;
            }
            
        }

        private void btnCaja2_Click(object sender, EventArgs e)
        {
            if (aux < cont)
            {
                lblTurno.Visible = true;
                lbl3.Visible = true;
                lbl3.Text = Metodos.MPCliente();
                lblCaja.Visible = true;
                lbl4.Visible = true;
                lbl4.Text = "2";
                aux++;
            }
        }

        private void btnCaja3_Click(object sender, EventArgs e)
        {
            if (aux < cont)
            {
                lblTurno.Visible = true;
                lbl3.Visible = true;
                lbl3.Text = Metodos.MPCliente();
                lblCaja.Visible = true;
                lbl4.Visible = true;
                lbl4.Text = "3";
                aux++;
            }
        }

        private void btnCaja4_Click(object sender, EventArgs e)
        {
            if (aux < cont)
            {
                lblTurno.Visible = true;
                lbl3.Visible = true;
                lbl3.Text = Metodos.MPCliente();
                lblCaja.Visible = true;
                lbl4.Visible = true;
                lbl4.Text = "4";
                aux++;
            }
        }
    }
        
}
 
 