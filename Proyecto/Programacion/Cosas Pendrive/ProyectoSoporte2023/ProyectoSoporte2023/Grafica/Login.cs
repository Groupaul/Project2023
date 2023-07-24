using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoporte2023
{
    public partial class FormLogin : Form
    {
        private Grafica.Menu menu;
        public FormLogin()
        {
            InitializeComponent();
        }

        /*private void btnMin_Click(object sender, EventArgs e)
        {
            // Al tocar el boton, Minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            // Si el programa esta en estado normal, al tocar el boton maximizar, si no al tocar el boton minimizar
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Cierra el programa
            Application.Exit();
        }
    */
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (menu == null || menu.IsDisposed)
                menu = new Grafica.Menu();
            menu.Show(); //Mostrar la ventana
            menu.Focus();//Muestra la ventana en primer plano
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
