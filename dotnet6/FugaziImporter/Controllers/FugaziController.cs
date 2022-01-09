using Microsoft.AspNetCore.Mvc;

namespace FugaziImporter.Controllers;

[ApiController]
[Route("[controller]")]
public class FugaziController : ControllerBase {
    public readonly ILogger<FugaziController> _logger;

    public FugaziController(ILogger<FugaziController> logger){
        _logger = logger;
    }

    [HttpGet]
    public ActionResult GetAllFgzImported(){
        return BadRequest("Not implemented");
    }

    [HttpGet("{id}")]
    public ActionResult GetFgzImportedById(int id){
        return BadRequest($"Not implemented: {id}");
    }
}