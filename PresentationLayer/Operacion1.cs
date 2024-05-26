using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Operacion1 : Form
    {
        public Operacion1()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            TxbPrimerNumero.Text = string.Empty;
        }
        private void EnabledButton()
        {
            BtnCalcular.Enabled = true;
        }
        private void DisabledButton()
        {
            BtnCalcular.Enabled = false;
        }

        private void Operacion1_Load(object sender, EventArgs e)
        {
            ClearData();
            DisabledButton();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double[] Numeros = new double[1];

                Numeros[0] = Convert.ToDouble(TxbPrimerNumero.Text);

                if (Numeros[0] >= 1 && CkbMCD.Checked == true)
                {
                    MessageBox.Show("EL RESULTADO DEL MCD ES: " + Numeros[0].ToString(), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("EL VALOR DEL R1 ES: 1", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("LA ECUACION ES: " + Numeros[0].ToString() + " = ( 1 * " + Numeros[0].ToString() + " )", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                else if (Numeros[0] >= 1 && CkbMCM.Checked == true)
                {
                    MessageBox.Show("EL RESULTADO DEL MCM ES: " + Numeros[0].ToString(), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearData();
                }
            }
            catch (Exception)
            {
                ClearData();

                MessageBox.Show("INGRESE NUMEROS NATURALES", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CkbMCD_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbMCD.Checked == true)
            {
                CkbMCM.Enabled = false;
                EnabledButton();
            }
            else
            {
                CkbMCM.Enabled = true;
                DisabledButton();
            }
        }
        private void CkbMCM_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbMCM.Checked == true)
            {
                CkbMCD.Enabled = false;
                EnabledButton();
            }
            else
            {
                CkbMCD.Enabled = true;
                DisabledButton();
            }
        }
    }
}