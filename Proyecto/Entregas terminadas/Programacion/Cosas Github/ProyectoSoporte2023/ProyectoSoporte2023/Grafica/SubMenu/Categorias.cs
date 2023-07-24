using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoporte2023.Grafica.SubMenu
{
    public partial class Categorias : Form
    {
        private Grafica.SubMenu.panelPuntajes puntajes;
           public Categorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (puntajes == null || puntajes.IsDisposed)
                puntajes = new Grafica.SubMenu.panelPuntajes();
            puntajes.Show(); //Mostrar la ventana
            puntajes.Focus();//Muestra la ventana en primer plano
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (puntajes == null || puntajes.IsDisposed)
                puntajes = new Grafica.SubMenu.panelPuntajes();
            puntajes.Show(); //Mostrar la ventana
            puntajes.Focus();//Muestra la ventana en primer plano
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (puntajes == null || puntajes.IsDisposed)
                puntajes = new Grafica.SubMenu.panelPuntajes();
            puntajes.Show(); //Mostrar la ventana
            puntajes.Focus();//Muestra la ventana en primer plano
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (puntajes == null || puntajes.IsDisposed)
                puntajes = new Grafica.SubMenu.panelPuntajes();
            puntajes.Show(); //Mostrar la ventana
            puntajes.Focus();//Muestra la ventana en primer plano
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (puntajes == null || puntajes.IsDisposed)
                puntajes = new Grafica.SubMenu.panelPuntajes();
            puntajes.Show(); //Mostrar la ventana
            puntajes.Focus();//Muestra la ventana en primer plano
        }
    }
}
