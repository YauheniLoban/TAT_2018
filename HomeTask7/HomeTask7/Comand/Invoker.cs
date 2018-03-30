using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7
{
    class Invoker
    {
        IComand comand;

        public void SetCommand(IComand com)
        {
            comand = com;
        }
        public IEnumerable<Car> Execute()
        {
           return comand.Execute();
        }
    }
}
