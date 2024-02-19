namespace RESTTemplate.Model
{
    /*
     * ------------------------
     *  MODEL DO OBJETO PERSON
     * ------------------------
     * Primeiro passo na criação de uma API REST
     * class: Aqui estão os objetos e atributos necessários para definir uma pessoa
     * Documentação de uso se encontra no vault do obsidian no Github: https://github.com/F4NT0/CSharp_Dotnet
     */
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
