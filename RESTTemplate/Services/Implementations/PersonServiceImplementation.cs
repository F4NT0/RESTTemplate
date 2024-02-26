using RESTTemplate.Model;
using RESTTemplate.Model.Context;
using System;

namespace RESTTemplate.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private SQLiteContext _context;

        public PersonServiceImplementation(SQLiteContext context)
        {
            _context = context;
        }

        /**
         * -------------------------------------------------
         * IMPLEMENTAÇÃO DO MÉTODO CREATE (POST DO POSTMAN)
         * -------------------------------------------------
         * Adiciona uma pessoa no banco de dados
         */
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /**
         * ----------------------------------------------------------------
         *       IMPLEMENTAÇÃO DO MÉTODO READ ALL (GET DO POSTMAN)
         * ----------------------------------------------------------------
         * Busca todos os valores salvos do objeto Person no Banco de dados
         */
        public List<Person> FindAll()
        {
           return _context.Persons.ToList();
        }

        /**
         * ---------------------------------------------------------------
         *       IMPLEMENTAÇÃO DO MÉTODO READ BY ID (GET DO POSTMAN)
         * ---------------------------------------------------------------
         * Busca um objeto do tipo Person pelo ID de entrada na requisição
         */
        public Person FindbyID(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        /**
         * ---------------------------------------------------------------
         *      IMPLEMENTAÇÃO DO MÉTODO UPDATE (UPDATE DO POSTMAN)
         * ---------------------------------------------------------------
         * Atualiza os dados de uma Pessoa onde ele busca no banco pelo ID
         */
        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return person;
        }

        /**
         * Método auxiliar para verificar a existência de um dado no banco pelo ID
         */
        private bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
