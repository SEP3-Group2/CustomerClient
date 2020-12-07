using CustomerClient.Models;
using System.Threading.Tasks;

namespace CustomerClient.Data.ImagesService
{
    interface IImagesService
    {
        Task UploadImage(SaveFile files);

        Task<SaveFile> GetImages(string quantity, int productID);
    }
}
