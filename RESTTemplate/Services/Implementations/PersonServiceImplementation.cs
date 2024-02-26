using RESTTemplate.Model;
using RESTTemplate.Model.Context;

namespace RESTTemplate.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private SQLiteContext _context;

        public PersonServiceImplementation(SQLiteContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
           return _context.Persons.ToList();
        }

        public Person FindbyID(long id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
