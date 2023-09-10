using BookInventory.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookInventory.Entities
{
    public class Condition : IPrimaryProperties
    {
        public int Id { get ; set ; }
        [Column("BookCondition")]
        public string DescriptiveName { get; set; }
    }
}
