using Microsoft.EntityFrameworkCore;
using RESTTemplate.Model;
using RESTTemplate.Model.Context;
using RESTTemplate.Repository;
using System;

namespace RESTTemplate.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private readonly IPersonRepository _repository;

        public PersonServiceImplementation(IPersonRepository personRepository)
        {
            _repository = personRepository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
           return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        
        public List<Person> FindAll()
        {
           return _repository.FindAll();
        }

        
        public Person FindbyID(long id)
        {
            return _repository.FindbyID(id);
        }
    }
}
