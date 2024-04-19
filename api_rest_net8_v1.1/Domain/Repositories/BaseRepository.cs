using Dws.Note_one.Api.Persistence.Contexts;


namespace Dws.Note_one.Api.Domain.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
             _context = context;
        }
    }
}