using ControleRemoto;

namespace controleRemoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new Tv();
            RemoteControl remote = new RemoteControl(tv);
            remote.TogglePower();

            IDevice radio = new Radio();
            AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);
            advancedRemote.TogglePower();
            advancedRemote.Mute();
        }
    }
}
