using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookInventory.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        [DisplayName("Subjects")]
        public int GenreId { get; set; }
        [NotMapped]
        public virtual ICollection<SelectListItem>? Genres { get; set; }  
        [DisplayName("Condition")]
        public int ConditionId { get; set; }
        [NotMapped]
        public virtual ICollection<SelectListItem>? Conditions { get; set; }

        public int CallNumberId { get; set; } = 1;
        public bool IsAvailable { get; set; }
    }
}
