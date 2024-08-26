using System.ComponentModel.DataAnnotations;

namespace MyNotes.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public List<CategoryNote> Notes { get; set; }
    }
}
