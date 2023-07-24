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
    public partial class panelIngresar : Form
    {
        public panelIngresar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //cierra el formulario
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion para que solo se ingresen Números (Regulado por las teclas segun su codigo ascii)
            //En el textbox deshabilitar el shortcut
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo Números ", " Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion para que solo se ingresen Letras (Regulado por las teclas segun su codigo ascii)
            //En el textbox deshabilitar el shortcut
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo Letras ", " Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void panelIngresar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion para que solo se ingresen Letras (Regulado por las teclas segun su codigo ascii)
            //En el textbox deshabilitar el shortcut
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo Letras ", " Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void mtbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion para que solo se ingresen Números (Regulado por las teclas segun su codigo ascii)
            //En el textbox deshabilitar el shortcut
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo Números ", " Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void mtbFechaCSalud_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion para que solo se ingresen Números (Regulado por las teclas segun su codigo ascii)
            //En el textbox deshabilitar el shortcut
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo Números ", " Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion para que solo se ingresen Letras (Regulado por las teclas segun su codigo ascii)
            //En el textbox deshabilitar el shortcut
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo Letras ", " Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion para que solo se ingresen Letras (Regulado por las teclas segun su codigo ascii)
            //En el textbox deshabilitar el shortcut
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo Letras ", " Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
    }

