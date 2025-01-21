using Microsoft.EntityFrameworkCore;
using FigureApp.Models;

namespace FigureApp.Data
{
    public class FigureContext : DbContext
    {
        public FigureContext(DbContextOptions<FigureContext> options) : base(options) { }

        public DbSet<Figure> Figures { get; set; }
    }
}
