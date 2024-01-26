using AIResume.Domain.Dto;
using AIResume.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AIResume.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class FilesController : ControllerBase
    {
        private readonly IFilesService _filesService;
        public FilesController(IFilesService filesService)
        {
            _filesService = filesService;
        }

        [HttpPost("resume")]
        public IActionResult Post([Required][FromForm] CreateFileRequest request)
        {
            return Ok();
        }
    }
}
