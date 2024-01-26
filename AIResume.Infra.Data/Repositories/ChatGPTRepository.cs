using AIResume.Domain.Interface;

namespace AIResume.Infra.Data.Repositories
{
    public class ChatGPTRepository : IChatGPTRepository
    {
        private readonly HttpClient _httpClient;
        public ChatGPTRepository(HttpClient httpClient)
        { 
            _httpClient = httpClient;
        }

        public void Exemplo()
        {
            _httpClient.GetAsync("/createResume");
        }
    }
}
