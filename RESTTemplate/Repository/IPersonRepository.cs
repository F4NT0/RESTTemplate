using RESTTemplate.Model;

namespace RESTTemplate.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindbyID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
