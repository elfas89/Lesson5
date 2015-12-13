using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class TVset
    {
        private int channel;

        public int Channel
        {
            get
            {
                return channel;
            }
        }


        public void NextChannel()
        {
            channel += 1;
        }

        public void PrevChannel()
        {
            if (channel > 1)
            {
                channel -= 1;
            }

        }

        public void SetChannel(int channel)
        {
            if (channel > 0)
            {
                this.channel = channel;
            }

        }

    }
}
