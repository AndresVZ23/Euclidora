using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Operacion2 : Form
    {
        public Operacion2()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            TxbPrimerNumero.Text = string.Empty;
            TxbSegundoNumero.Text = string.Empty;
        }
        private void EnabledButton()
        {
            BtnCalcular.Enabled = true;
        }
        private void DisabledButton()
        {
            BtnCalcular.Enabled = false;
        }

        private void Operacion2_Load(object sender, EventArgs e)
        {
            ClearData();
            DisabledButton();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones ObjOperaciones = new Operaciones();

                string Ecuacion = string.Empty;

                double[] R = new double[2];
                double[] Numeros = new double[2];

                Numeros[0] = Convert.ToDouble(TxbPrimerNumero.Text);
                Numeros[1] = Convert.ToDouble(TxbSegundoNumero.Text);

                R[0] = ObjOperaciones.CalculoMCM_02(Numeros[0], Numeros[1]) / Numeros[0];
                R[1] = (ObjOperaciones.CalculoMCD_02(Numeros[0], Numeros[1]) - (R[0] * Numeros[0])) / Numeros[1];

                if (Numeros[0] >= 1 && Numeros[1] >= 1 && CkbMCD.Checked == true)
                {
                    double Resultado = ObjOperaciones.CalculoMCD_02(Numeros[0], Numeros[1]);
                    Ecuacion = Resultado + " = (" + R[0] + " * " + Numeros[0] + ") + (" + R[1] + " * " + Numeros[1] + ")";
                    MessageBox.Show("EL RESULTADO DEL MCD ES: " + Resultado.ToString(), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("LOS VALORES R1 Y R2 SON: " + R[0].ToString() + " " + R[1].ToString(), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("LA ECUACION ES: " + Ecuacion, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearData();
                }
                else if (Numeros[0] >= 1 && Numeros[1] >= 1 && CkbMCM.Checked == true)
                {
                    double Resultado = ObjOperaciones.CalculoMCM_02(Numeros[0], Numeros[1]);

                    MessageBox.Show("EL RESULTADO DEL MCM ES: " + Resultado.ToString(), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearData();
                }
            }
            catch (Exception)
            {
                ClearData();

                MessageBox.Show("INGRESE NUMEROS NATURALES", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}