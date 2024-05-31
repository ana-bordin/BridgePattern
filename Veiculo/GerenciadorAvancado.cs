namespace Veiculo
{
    public class GerenciadorAvancado : GerenciadorVeiculo
    {
        public GerenciadorAvancado(IVeiculo Veiculo) : base(Veiculo) { }

        //ativar modo turbo
        public void AtivarTurbo()
        {
            Veiculo.Acelerar(30);
        }
    }
}
