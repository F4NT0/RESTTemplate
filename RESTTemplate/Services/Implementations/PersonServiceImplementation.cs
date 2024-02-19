using RESTTemplate.Model;

namespace RESTTemplate.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindbyID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Gabriel",
                LastName = "Fanto",
                Address = "Porto Alegre",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Gabriel" + i,
                LastName = "Fanto" + i,
                Address = "Porto Alegre" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
