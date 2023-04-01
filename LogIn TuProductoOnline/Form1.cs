using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_TuProductoOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //Verificaciones de que los campos del usuario y clave no esten vacíos 
            //y asi activar el boton de acceso
            if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtClave.Text))
            {
                btnAcceso.Enabled = false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtUsuario.Text) && txtClave.Text != "")
                {
                    btnAcceso.Enabled = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtClave.Text) && txtUsuario.Text != "")
                    {
                        btnAcceso.Enabled = false;
                    }
                    else
                    {
                        btnAcceso.Enabled = true;
                    }
                }
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            //Verificaciones de que los campos del usuario y clave no esten vacíos 
            //y asi activar el boton de acceso
            if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtClave.Text)) 
            {
                btnAcceso.Enabled = false;
            }
            else 
            {
                if (string.IsNullOrEmpty(txtUsuario.Text) && txtClave.Text != "")
                {
                    btnAcceso.Enabled = false;
                }
                else 
                {
                    if (string.IsNullOrEmpty(txtClave.Text) && txtUsuario.Text != "")
                    {
                        btnAcceso.Enabled = false;
                    }
                    else 
                    {
                        btnAcceso.Enabled = true;
                    }
                }
            }
        }
    }
}
