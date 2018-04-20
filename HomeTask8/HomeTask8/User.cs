namespace HomeTask8
{
    /// <summary>
    /// User description
    /// </summary>
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string sex { get; set; }
        public int age { get; set; }

        public User(string _firstName, string _lastName, string _sex, int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            sex = _sex;
            age = _age;
        }

        public override string ToString()
        {
            return "First Name :" + firstName + " Last Name :" + lastName + " Sex:" + sex + " Age:" + age;
        }
    }
}
