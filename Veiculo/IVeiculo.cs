namespace Veiculo
{
    public interface IVeiculo
    {
        bool EstaLigado();
        void Ligar();
        void Desligar();
        int PegarVelocidade();
        int Acelerar();
        int Acelerar(int valor);
        int Frear();
    }
}
