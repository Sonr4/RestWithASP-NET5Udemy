using RestWithASPNETErudio.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETErudio.Model
{
    [Table("person")]
    public class Person : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required]
        [Column("address")]
        public string Address { get; set; }

        [Required]
        [Column("gender")]
        public string Gender { get; set; }
    }
}