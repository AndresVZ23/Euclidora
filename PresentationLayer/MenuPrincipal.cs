using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MenuPrincipal : Form
    {
        private Operacion1 ObjOperacion1;
        private Operacion2 ObjOperacion2;
        private Operacion3 ObjOperacion3;
        private Operacion4 ObjOperacion4;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Cantidad()
        {
            CmbNumeros.Items.Add(1);
            CmbNumeros.Items.Add(2);
            CmbNumeros.Items.Add(3);
            CmbNumeros.Items.Add(4);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Cantidad();
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(CmbNumeros.SelectedIndex);

            if (N == 0)
            {
                ObjOperacion1 = new Operacion1();

                ObjOperacion1.ShowDialog();
            }
            else if (N == 1)
            {
                ObjOperacion2 = new Operacion2();

                ObjOperacion2.ShowDialog();
            }
            else if (N == 2)
            {
                ObjOperacion3 = new Operacion3();

                ObjOperacion3.ShowDialog();
            }
            else if (N == 3)
            {
                ObjOperacion4 = new Operacion4();

                ObjOperacion4.ShowDialog();
            }
        }
    }
}