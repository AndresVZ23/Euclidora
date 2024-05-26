using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Caratula : Form
    {
        private MenuPrincipal ObjMenuPrincipal;
        private Integrantes ObjIntegrantes;
        public Caratula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            ObjMenuPrincipal = new MenuPrincipal();

            ObjMenuPrincipal.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Integrantes_Click(object sender, EventArgs e)
        {
            ObjIntegrantes = new Integrantes();

            ObjIntegrantes.ShowDialog();
        }
    }
}
