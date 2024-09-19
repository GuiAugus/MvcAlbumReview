using System.ComponentModel.DataAnnotations;

namespace MvcAlbumReview.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Rating { get; set; }
    }
}
