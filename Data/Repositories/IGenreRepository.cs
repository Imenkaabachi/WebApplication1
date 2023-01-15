using WebApplication1.Models;

namespace WebApplication1.Data.Repositories
{
    public interface IGenreService
    {
        bool Add(Genre model);

        bool Update(Genre model);

        Genre GetById(int id);

        bool Delete(int id);

        IQueryable<Genre> List();
    }
}
