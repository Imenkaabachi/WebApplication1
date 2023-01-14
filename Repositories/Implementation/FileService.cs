using WebApplication1.Repositories.Abstract;

namespace WebApplication1.Repositories.Implementation
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
