using WebApplication1.Data.Repositories.Abstract;

namespace WebApplication1.Data.Repositories.Implementation
{
    public class FileService : IFileService
    {
        public bool DeleteImage(string imageFileName)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> SaveImage(IFormFile imageFile)
        {
            throw new NotImplementedException();
        }
    }
}
