using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixart
{
    delegate void OL();
    delegate void SL(int data, string login);
    class Handlers
    {
        public event OL LoginEvent;
        public void OnLogin()
        {
            LoginEvent();
        }
        public event SL SendLoginEvent;
        public void SendLogin(int data, string login)
        {
            SendLoginEvent(data, login);
        }
    }
}
