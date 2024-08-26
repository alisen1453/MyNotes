using System.ComponentModel.DataAnnotations;

namespace MyNotes.Models
{
    public class CategoryNote
    {
        [Key]
        public Guid NoteId { get; set; }
        public string? NoteName { get; set; }
        public string? NoteDescription { get; set; }
        public string? CategoryId { get; set; }
    }
}
