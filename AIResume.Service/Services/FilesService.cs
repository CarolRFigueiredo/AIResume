using AIResume.Domain.Dto;
using AIResume.Domain.Interface;
using System.Runtime.CompilerServices;
using System.Text;

namespace AIResume.Service.Services
{
    public class FilesService : IFilesService
    {
        public readonly IFilesRepository _filesRepository;

        public FilesService(IFilesRepository filesRepository)
        {
            _filesRepository = filesRepository;
        }

        public CreateFileResponse GetResumeFromFile(CreateFileRequest request)
        {
            //validar extensao do arquivo

            var text = ReadFile(request);

            //gerar resumo ia 
            //salvar no banco

            //gerar o retorno

            return new CreateFileResponse { Id = Guid.NewGuid(), Resume = text };
        }

        private string ReadFile(CreateFileRequest request)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(request.File.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    result.AppendLine(reader.ReadLine());
                }
            };

            return result.ToString();
        }
    }
}
