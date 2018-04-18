using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    /// <summary>
    /// Declare commands
    /// </summary>
    interface ICommand
    {
        void ExecuteAverageAge();
        void ExecuteOldestUser();
        void ExecutePopularWomanName();
    }
}
