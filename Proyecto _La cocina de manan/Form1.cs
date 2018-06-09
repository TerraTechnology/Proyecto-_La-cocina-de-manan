using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__La_cocina_de_manan
{
    public partial class fm_menuPrincipal : Form
    {
        public fm_menuPrincipal()
        {
            InitializeComponent();
        }

        int contadorProducto = 0;




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        void activadorCantidadProducto()
        {
            lb_cantidadProducto.Visible = true;
            contadorProducto++;
            lb_cantidadProducto.Text = Convert.ToString(contadorProducto);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            activadorCantidadProducto();
        }

        private void btn_item1_Click(object sender, EventArgs e)
        {
            activadorCantidadProducto();
            
            
        }

        private void btn_item2_Click(object sender, EventArgs e)
        {
            activadorCantidadProducto();
        }

        private void btn_item4_Click(object sender, EventArgs e)
        {
            activadorCantidadProducto();
        }

        private void pn_Carrito_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TerminarCompra_Click(object sender, EventArgs e)
        {

            fm_menuPrincipal ventanaUno = new fm_menuPrincipal();
            ventanaUno.Hide();


            Form2 ventanados = new Form2();
            ventanados.Show();

            

        }
    }
}
