using Microsoft.AspNetCore.Http;

namespace AIResume.Domain.Dto
{
    public class CreateFileRequest
    {
        public IFormFile File { get; set; }
    }
}
