using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    /// <summary>
    /// Create invoker of commands
    /// </summary>
    class Invoker
    {
        ICommand command;

        /// <summary>
        /// Initialize command
        /// </summary>
        public void SetCommand(ICommand _command)
        {
            command = _command;
        }

        /// <summary>
        /// Call command for finding average age
        /// </summary>
        public void CalculateAverageAge()
        {
            command.ExecuteAverageAge();
        }

        /// <summary>
        /// Call command for finding the oldest user
        /// </summary>
        public void FindOldestUser()
        {
            command.ExecuteOldestUser();
        }

        /// <summary>
        /// Call command for finding the most popular woman name
        /// </summary>
        public void FindPopularWomanName()
        {
            command.ExecutePopularWomanName();
        }
    }
}
