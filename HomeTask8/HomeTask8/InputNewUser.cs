using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    /// <summary>
    /// creating a new user
    /// </summary>
    class InputNewUser
    {
        public List<User> users = new List<User>();

        /// <summary>
        /// entering user information
        /// </summary>
        public void AddUsers()
        {
            try
            {
                Console.WriteLine("Input first name  ");
                string userFirstName = Console.ReadLine();
                Console.WriteLine("Input last name  ");
                string userLastName = Console.ReadLine();
                Console.WriteLine("Input gender(woman or man) ");
                string userGender = Console.ReadLine();
                Console.WriteLine("Input age  ");
                int userAge = Int32.Parse(Console.ReadLine());
                users.Add(new User(userFirstName, userLastName, userGender, userAge));
                if (FindNamesakes(userLastName).Count > 1)
                {
                    NamesakesEventArgs args = new NamesakesEventArgs();
                    args.Namesakes = FindNamesakes(userLastName);
                    OnOutputNamesakes(args);
                }
            }
            catch (FormatException)
            {
               throw new FormatException("Wrong number format");
            }
        }

        private List<User> FindNamesakes(string inputtedLastName)
        {
            var namesakeUsers = users.Where(user => user.lastName == inputtedLastName).Select(user => user);
            return namesakeUsers.ToList();
        }
        protected virtual void OnOutputNamesakes(NamesakesEventArgs ev)
        {
            EventHandler<NamesakesEventArgs> handler = OutputNamesakes;
            handler(this, ev);
        }
        public event EventHandler<NamesakesEventArgs> OutputNamesakes;
    }
}
