namespace Ovningar20220901
{
    public class Person
    {
        private string _firstName = null!;
        private string _lastName = null!;

        public string Name()
        {
            return $"{_firstName} {_lastName}";
        }
        public override string ToString()
        {
            return Name();
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }


        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
