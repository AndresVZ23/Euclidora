namespace PresentationLayer{
    public partial class Operaciones
    {
        public Operaciones() { }
    }
    public partial class Operaciones
    {
        public double CalculoMCD_02(double N1, double N2)
        {
            if (N2 == 0)
                return N1;

            return CalculoMCD_02(N2, N1 % N2);
        }
        public double CalculoMCD_03(double N1, double N2, double N3)
        {
            return CalculoMCD_02(CalculoMCD_02(N1, N2), N3);
        }
        public double CalculoMCD_04(double N1, double N2, double N3, double N4)
        {
            return CalculoMCD_02(CalculoMCD_02(CalculoMCD_02(N1, N2), N3), N4);
        }
        public double CalculoMCM_02(double N1, double N2)
        {
            return (N1 * N2) / CalculoMCD_02(N1, N2);
        }
        public double CalculoMCM_03(double N1, double N2, double N3)
        {
            double[] Aux = new double[1];
            Aux[0] = CalculoMCM_02(N1, N2);

            return CalculoMCM_02(Aux[0], N3);
        }
        public double CalculoMCM_04(double N1, double N2, double N3, double N4)
        {
            double[] Aux = new double[2];
            Aux[0] = CalculoMCM_02(N1, N2);
            Aux[1] = CalculoMCM_02(N3, N4);

            return CalculoMCM_02(Aux[0], Aux[1]);
        }
    }
}