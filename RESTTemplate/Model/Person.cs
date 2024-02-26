using System.ComponentModel.DataAnnotations.Schema;

namespace RESTTemplate.Model
{
    [Table("persons")]
    public class Person
    {
        [Column("person_id")]
        public long Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}
