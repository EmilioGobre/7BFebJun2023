namespace PeopleLibrary
{
    public class Person
    {
        // Fields
        public string Name;
        // Properties
        public string SurName { get; set; } 

        // Methods
        public string getSurName()
        {
            return SurName;
        }
        public void setSurname(string surname)
        {
            SurName = surname;
        }
    }
}