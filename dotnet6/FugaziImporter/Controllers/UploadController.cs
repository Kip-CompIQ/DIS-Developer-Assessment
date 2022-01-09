
using Microsoft.AspNetCore.Mvc;

namespace FugaziImporter.Controllers;

[ApiController]
[Route("[controller]")]
public class UploadController : ControllerBase {
    public readonly ILogger<UploadController> _logger;

    public UploadController(ILogger<UploadController> logger){
        _logger = logger;
    }

    [HttpPost] 
    public ActionResult Upload(IFormFile file){
        return BadRequest($"Not implemented: {file.FileName} - {file.Length}");
    }
}