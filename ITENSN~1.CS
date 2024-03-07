using System;

namespace PPL_Main.CodigosMain
{
    public class ItensNaAtmosfera
    {

        public double valorAltura { get; protected set; }
        protected double valorGraviade = 10;
        protected double velocidadeInicialEmYItensNaAtmosfera;

        public virtual void DeterminaAltura(double tempoDecorrido)
        {
            valorAltura = (velocidadeInicialEmYItensNaAtmosfera * tempoDecorrido) - (valorGraviade / 2) * Math.Pow(tempoDecorrido, 2);
        }

    }
}
