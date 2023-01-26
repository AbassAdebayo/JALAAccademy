namespace Question2
{
    public class Person
    {
        public string FirstName;

        public string LastName;

        public string Email;

        public string PhoneNumber;

        public string Address;

        public int Age;

        public string Gender;

        public Person(string firstName, string lastName, string email, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public Person(string firstName, string lastName, string email, string phoneNumber, string address, int age, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Age = age;
            Gender = gender;
        }
    }
}