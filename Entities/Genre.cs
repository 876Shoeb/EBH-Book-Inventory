using BookInventory.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookInventory.Entities
{
    public class Genre : IPrimaryProperties
    {
        public int Id { get; set; }
        [Column("Genre")]
        public string DescriptiveName { get; set; }
    }
}
