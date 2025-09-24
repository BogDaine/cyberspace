using System.ComponentModel.DataAnnotations;

namespace cyberspace.Models
{
    public class ArtPost
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? Description { get; set; } // ? = nullable
        public string? Src { get; set; }
    }
}
