using CustomerClient.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerClient.Data.ImagesService
{
    public class ImagesService : IImagesService
    {
        HttpClient client = new HttpClient();
        string uri = "https://localhost:44319/images";

        public async Task UploadImage(SaveFile files)
        {
            string filesSerialized = JsonSerializer.Serialize(files);

            HttpContent payload = new StringContent(
                filesSerialized,
                Encoding.UTF8,
                "application/json"
                );

            Console.WriteLine(filesSerialized);

            var response = await client.PostAsync($"{uri}", payload);
        }

        public async Task<SaveFile> GetImages(string quantity, int productID)
        {
            Console.WriteLine("Calling getimages...");
            string url = uri;
            url += $"/?quantity={quantity}&productID={productID}";
            Console.WriteLine(url);
            var message = await client.GetStringAsync(url);
            Console.WriteLine($"Got message: {message}");

            return JsonSerializer.Deserialize<SaveFile>(message);
        }
    }
}
