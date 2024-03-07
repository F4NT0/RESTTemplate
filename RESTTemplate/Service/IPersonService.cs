using RESTTemplate.Model;

namespace RESTTemplate.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindbyID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
