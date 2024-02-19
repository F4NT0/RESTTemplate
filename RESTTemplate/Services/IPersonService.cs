using RESTTemplate.Model;

namespace RESTTemplate.Services
{
    /*
     * ----------------------------
     *  SERVICE DO OBJETO PERSON
     * ----------------------------
     * Passo após a criação do Model Person
     * Interface: Aqui se encontram as estruturas bases dos métodos utilizados no nosso CRUD
     * Documentação de uso se encontra no vault do obsidian no Github: https://github.com/F4NT0/CSharp_Dotnet
     */
    public interface IPersonService
    {
        Person Create(Person person); // Cria uma nova pessoa no banco de dados
        Person FindbyID(long id); // Busca uma pessoa específica pelo seu ID
        List<Person> FindAll(); // Busca todas as pessoas cadastradas
        Person Update(Person person); // Atualiza uma pessoa definida no objeto
        void Delete(long id); // Deleta uma pessoa específica pelo seu ID

    }
}
