using WebApplication1.Models.Domain;
using WebApplication1.Repositories.Abstract;

namespace WebApplication1.Repositories.Implementation
{
    public class GenreService : IGenreService
    {
        private readonly CinemaContext ctx;

        public GenreService(CinemaContext ctx)
        {
            this.ctx = ctx;
        }
        public bool Add(Genre model)
        {
            try
            {
                ctx.Genres.Add(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.GetById(id);
                if (data == null)
                    return false;
                ctx.Genres.Remove(data);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Genre GetById(int id)
        {
            return ctx.Genres.Find(id);
        }

        public IQueryable<Genre> List()
        {
            var data=ctx.Genres.AsQueryable();
            return data;
        }

        public bool Update(Genre model)
        {
            try
            {
                ctx.Genres.Update(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
