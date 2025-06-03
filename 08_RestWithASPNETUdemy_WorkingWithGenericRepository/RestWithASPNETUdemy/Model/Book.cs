using RestWithASPNETErudio.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("title")]
        public required string Title { get; set; }

        [Column("author")]
        public required string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }
}