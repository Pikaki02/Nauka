using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    
    public class Publisher
    {
        public event MessageHndler MessageEvent;
        public void SendMessage(string message)
        {
            if(MessageEvent != null)
            {
                MessageEvent(message);
            }
        }
    }
}
