namespace OopMethods
{
    internal class Person
    {
        public Person()
            : this(string.Empty, string.Empty)
        {
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
