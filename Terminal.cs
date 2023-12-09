using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPnPDetecter
{
    internal class Terminal
    {
        public Terminal(int id, string name, string ip, string mac)
        {
            ID = id;
            Name = name;
            IP = ip;
            MAC = mac;
        }
        public int ID { get; private set; }

        public string Name { get; set; }

        public string IP { get; set; }

        public string MAC { get; set; }
    }
}
