using System;
using System.IO;

namespace PPL_Main.CodigosMain
{
    public class Projetil
    {

        public double gravidade = 9.81;
        private double velocidadeInicial1Projetil;
        private double velocidadeInicial2Projetil;
        private double velocidadeUsada;
        private double anguloLancamentoProjetil;
        private double tempoVoo;
        private string tipoMovimento;
        private string resolucaoRealParaOAngulo;
        private double velocidadeInicialEmXProjetil;
        private double velocidadeInicialEmYProjetil;
        private double posicaoEmYProjetil;

        public double VelocidadeInicial1Projetil
        {
            get { return velocidadeInicial1Projetil; }
            set { velocidadeInicial1Projetil = value; }
        }

        public double VelocidadeInicial2Projetil
        {
            get { return velocidadeInicial2Projetil; }
            set { velocidadeInicial2Projetil = value; }
        }

        public double VelocidadeUsada
        {
            get { return velocidadeUsada; }
            set { velocidadeUsada = value; }
        }
        
        public double AnguloLancamentoProjetil
        {
            get { return anguloLancamentoProjetil; }
            set { anguloLancamentoProjetil = value; }
        }

        public string TipoMovimento
        {
            get { return tipoMovimento; }
            set { tipoMovimento = value; }
        }

        public double TempoVoo
        {
            get { return tempoVoo; }
            set { tempoVoo = value; }
        }

        public string ResolucaoRealParaOAngulo
        {
            get { return resolucaoRealParaOAngulo; }
            set { resolucaoRealParaOAngulo = value; }
        }

        public double VelocidadeInicialEmXProjetil
        {
            get { return velocidadeInicialEmXProjetil; }
            set { velocidadeInicialEmXProjetil = value; }
        }

        public double VelocidadeInicialEmYProjetil
        {
            get { return velocidadeInicialEmYProjetil; }
            set { velocidadeInicialEmYProjetil = value; }
        }

        public double PosicaoEmYProjetil
        {
            get { return posicaoEmYProjetil; }
            set { posicaoEmYProjetil = value; }
        }

    }
}
