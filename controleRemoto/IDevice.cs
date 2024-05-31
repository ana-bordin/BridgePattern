using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRemoto
{
    // A interface "implementação" declara métodos comuns a todas as classes concretas
    // de implementação. Ela não precisa coincidir com a interface de abstração. Na
    // verdade, as duas interfaces podem ser inteiramente diferentes. Tipicamente a
    // interface de implementação fornece apenas operações primitivas, enquanto que a
    // abstração define operações de alto nível baseada naquelas primitivas.

    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int percent);
        int GetChannel();
        void SetChannel(int channel);
    }

}
