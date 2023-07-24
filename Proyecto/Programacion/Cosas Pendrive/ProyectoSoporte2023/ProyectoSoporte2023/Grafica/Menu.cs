using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoporte2023.Grafica
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing(); // Llamamos la funcion Diseño creada para poder usarla en nuestro codigo.
        }
        // Apartado Funciones:
        private void customizeDesing()
        {
            // Paneles a ocultar de los correspondientes botones
            sbparticipante.Visible = false;
            sbayuda.Visible = false;
            
            
        }

        private void hideSubMenu()
        {
            // Se utiliza la funcion ocultar
            if (sbparticipante.Visible == true)
                sbparticipante.Visible = false;            
            if (sbayuda.Visible == true)
                sbayuda.Visible = false;
           
        
        }

        private void showSubMenu(Panel subMenu)
        {
            // El apartado inicie escondido
            // Si al darle click esta escondido que se muestre
            // Si esta visible, que se esconda
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

            
        
        }
        private Form activeForm = null;
        private void openPanelContenedor(Form childForm)
        {
            // Funcionalidad que permite traer un Formulario (childForm) dentro de otro formulario
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }
        // Termina el apartado Funciones.

        /* private void btnClose_Click(object sender, EventArgs e)
         {
             // Cierra el programa
             Application.Exit();

         }

         private void btnMax_Click(object sender, EventArgs e)
         {
             // Si el programa esta en estado normal, al tocar el boton maximizar, si no al tocar el boton minimizar
             if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
             else this.WindowState = FormWindowState.Normal;
         }

         private void btnMin_Click(object sender, EventArgs e)
         {
             // Al tocar el boton, Minimizar
             this.WindowState = FormWindowState.Minimized;
         }*/

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnparticipante_Click(object sender, EventArgs e)
        {
            // Desplegar el subMenu
            showSubMenu(sbparticipante);
            
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Mostrar el contenido del boton
            openPanelContenedor(new Grafica.SubMenu.panelIngresar());
            // Esconde el subMenu despues de ejecutar el codigo          
            hideSubMenu();
            
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            // Desplegar el subMenu
            showSubMenu(sbayuda);

            
        }

        private void btncontacto_Click(object sender, EventArgs e)
        {
            // Contenido BETA
            MessageBox.Show("Si necesita soporte, contactar al telefono ---- ---- ---", "Soporte");
            hideSubMenu();
        }

        private void btnPuntaje_Click(object sender, EventArgs e)
        {
            // Mostrar el contenido del boton
            openPanelContenedor(new Grafica.SubMenu.Categorias());
            // Esconde el subMenu despues de ejecutar el codigo          
            hideSubMenu();
        }
    }
}
