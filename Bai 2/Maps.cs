using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai2lab1
{
    internal class Maps
    {
        public string ID;
        public string Name;
        public string _inGame="lienMinhHuyenThoai";
        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
        }
        public string ShowData()
        {
            return "ID: " + ID + " |Name: " + Name + " |inGame: " + _inGame;
        }
    }
}