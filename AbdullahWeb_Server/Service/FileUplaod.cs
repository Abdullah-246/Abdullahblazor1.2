using AbdullahWeb_Server.Service.IService;
using Microsoft.AspNetCore.Components.Forms;
using System.IO;

namespace AbdullahWeb_Server.Service
{
    public class FileUplaod : IFileUplaod
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUplaod(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;   
        }

        public bool DeleteFile(string filePath)
        {
            if (File.Exists(_webHostEnvironment.WebRootPath + filePath))
            {
                File.Delete(_webHostEnvironment.WebRootPath + filePath);
                return true;
            }
            return false;
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            FileInfo fileInfo = new(file.Name);
            var fileName=Guid.NewGuid().ToString()+fileInfo.Extension;
            var folderDirectory = $"{_webHostEnvironment.WebRootPath}\\images\\product";
            if (!Directory.Exists(folderDirectory))
            {
                Directory.CreateDirectory(folderDirectory);
            }
            var filepath=Path.Combine(folderDirectory, fileName);

            await using FileStream fs = new FileStream(filepath, FileMode.Create);
            await file.OpenReadStream().CopyToAsync(fs);

            var fullPath=$"/images/product/{fileName}";
            return fullPath;
        }
    }
}
