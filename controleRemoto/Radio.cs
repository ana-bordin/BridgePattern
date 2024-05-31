using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRemoto
{
    public class Radio : IDevice
    {
        private bool enabled = false;
        private int volume = 30;
        private int channel = 1;

        public bool IsEnabled()
        {
            return enabled;
        }

        public void Enable()
        {
            enabled = true;
        }

        public void Disable()
        {
            enabled = false;
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetVolume(int percent)
        {
            volume = percent;
        }

        public int GetChannel()
        {
            return channel;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
        }
    }
}
