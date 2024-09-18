using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcAlbumReview.Models;

namespace MvcAlbumReview.Data
{
    public class MvcAlbumReviewContext : DbContext
    {
        public MvcAlbumReviewContext (DbContextOptions<MvcAlbumReviewContext> options)
            : base(options)
        {
        }

        public DbSet<MvcAlbumReview.Models.Album> Album { get; set; } = default!;
    }
}
