using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcAlbumReview.Models
{
    public class AlbumGenreViewModel
    {
        public List<Album>? albums {  get; set; }
        public SelectList? Genres { get; set; }
        public string? AlbumGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
