using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    /// <summary>
    /// Create information about user data
    /// </summary>
    public class DataCreator
    {
        public double AverageAge(List<User> users)
        {
            double avarageAge = users.Average(user => user.age);
            return avarageAge;
        }

        public List<User> OldestUsers(List<User> users)
        {
            int maxAge = users.Max(user => user.age);
            var oldestUsers = from user in users
                              where (user.age == maxAge)
                              select user;
            return oldestUsers.ToList();
        }

        public List<string> MostPopularWomanName(List<User> users)
        {
            var womenList = from user in users
                           where (user.sex == "woman")
                           select user;
            if(womenList.ToList().Count()!=0)
            {
                var womanNamesGroup = womenList.GroupBy(woman => woman.firstName).
                    Select(woman => new { Name = woman.Key, Count = woman.Count() });
                var maxWomanNamesNumber = womanNamesGroup.Max(womanName => womanName.Count);
                var popularWomanName = womanNamesGroup.Where(womanName => womanName.Count == maxWomanNamesNumber)
                                                      .Select(womanName => womanName.Name);
                return popularWomanName.ToList();
            }
            else
            {
                return null;

            }
        }
    }
}
