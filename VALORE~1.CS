using System;

namespace PPL_Main.CodigosMain
{
    public class ValoresCalculoEquacaoQuadratica
    {

        private double visaoA;
        private double visaoB;
        private double visaoC;
        private double discriminanteEmDelta;

        public double VisaoA
        {
            get { return visaoA; }
            set { visaoA = value; }
        }

        public double VisaoB
        {
            get { return visaoB; }
            set { visaoB = value; }
        }

        public double VisaoC
        {
            get { return visaoC; }
            set { visaoC = value; }
        }

        public double DiscriminanteEmDelta
        {
            get { return discriminanteEmDelta; }
            set { discriminanteEmDelta = value; }
        }

        public void CalculaDiscriminanteEmDelta()
        {

             DiscriminanteEmDelta = Math.Pow(VisaoB, 2) - 4 * VisaoA * VisaoC;

        }

    }
}
