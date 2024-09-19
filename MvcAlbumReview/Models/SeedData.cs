using Microsoft.EntityFrameworkCore;
using MvcAlbumReview.Data;

namespace MvcAlbumReview.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcAlbumReviewContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcAlbumReviewContext>>()))

                if (context.Album.Any())
                {
                    return;
                }
                else
                {
                    context.Album.AddRange(
                        new Album
                        {
                            ArtistName = "Racionais Mc",
                            Title = "Sobrevivendo no Inferno",
                            ReleaseDate = DateTime.Parse("1997-12-1"),
                            Genre = "RAP",
                            Rating = 9.7M,
                            Review = ""
                        },
                        new Album
                        {
                            ArtistName = "BK'",
                            Title = "Castelos & Ruinas",
                            ReleaseDate = DateTime.Parse("2016-05-21"),
                            Genre = "RAP",
                            Rating = 9.5M
                        }
                        );
                    context.SaveChanges();
                }
        }
    }
}   
                
           
            
