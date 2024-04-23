using Microsoft.AspNetCore.Components.Forms;
using System.Net;

namespace AbdullahWeb_Server.Service.IService
{
    public interface IFileUplaod
    {
        Task<string> UploadFile(IBrowserFile file);
        bool DeleteFile(string filePath);
    }
}
