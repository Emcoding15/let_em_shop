using backend.DTOs;
using Microsoft.AspNetCore.Http;

namespace backend.Services
{
    public interface IImageStorageService
    {
        Task<ImageUploadResultDto> UploadProductImageAsync(IFormFile file, CancellationToken cancellationToken);
    }
}
