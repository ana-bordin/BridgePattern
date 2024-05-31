namespace Veiculo
{
    public class Carro : IVeiculo
    {
        private bool Ligado = false;
        private int Velocidade = 0;

        public bool EstaLigado()
        {
            return Ligado;
        }

        public void Ligar()
        {
            Ligado = true;
        }

        public void Desligar()
        {
            if (Velocidade == 0)
                Ligado = false;
        }

        public int PegarVelocidade()
        {
            return Velocidade;
        }

        public int Acelerar()
        {
            return Velocidade++;
        }

        public int Acelerar(int valor)
        {
            if (Ligado)
            {
                Velocidade += valor;
            }
            return Velocidade;
        }

        public int Frear()
        {
            if (Ligado)
            {
                Velocidade--;
            }
            return Velocidade;
        }
    }
}
