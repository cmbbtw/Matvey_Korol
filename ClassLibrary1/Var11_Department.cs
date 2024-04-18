using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Var11_Department
    {
        private string _name;
        private Employee _manager;
        private Var12_Organisation _organization;

        public Var11_Department(string name, Employee manager, Var12_Organisation organization)
        {
            _name = name;
            _manager = manager;
            _organization = organization;
        }
    }
}
