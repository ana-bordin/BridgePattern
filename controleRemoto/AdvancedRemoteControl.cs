using ControleRemoto;

namespace controleRemoto
{
    // Você pode estender classes a partir dessa hierarquia de abstração independentemente
    // das classes de dispositivo.

    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void Mute()
        {
            device.SetVolume(0);
        }
    }
}
