namespace Question3
{
    public class MyMethod
    {
        public string Check(string firstName, string lastName)
        {
             var name =  firstName + " " + lastName;
             return name;
        }

        public int Check(int age)
        {
            return age;
        }
    }
}