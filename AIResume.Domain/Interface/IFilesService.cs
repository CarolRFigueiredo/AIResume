using AIResume.Domain.Dto;

namespace AIResume.Domain.Interface
{
    public interface IFilesService
    {
        public CreateFileResponse GetResumeFromFile(CreateFileRequest request);
    }
}
