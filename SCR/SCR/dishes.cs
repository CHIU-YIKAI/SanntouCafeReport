using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCR
{
    class dishes
    {
        public string _name;
        public int _orignPrice;
        public int _costPrice;
        public string _groupName;
        public dishes(string name, int oringPrice, int costPrice, string groupName)
        {
            _name = name;
            _orignPrice = oringPrice;
            _costPrice = costPrice;
            _groupName = groupName;
        }
    }
}
