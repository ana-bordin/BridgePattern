namespace Veiculo
{
    public class GerenciadorVeiculo
    {
        protected IVeiculo Veiculo;

        public GerenciadorVeiculo(IVeiculo veiculo)
        {
            this.Veiculo = veiculo;
        }

        public void Ligar()
        {
            Veiculo.Ligar();
        }

        public void Desligar()
        {
            if (Veiculo.PegarVelocidade() != 0)
            {
                Veiculo.Desligar();
            }
        }

        public void Acelerar()
        {
            Veiculo.Acelerar();
        }

        public void Acelerar(int valor)
        {
            Veiculo.Acelerar(valor);
        }

        public void Frear()
        {
            Veiculo.Frear();
        }
    }
}
