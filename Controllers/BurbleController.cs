using burble_api.Models;
using burble_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burble_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BurbleController : ControllerBase
{
    private readonly ILogger<BurbleController> _logger;
    private readonly IBurbRepository _burbRepository;

    public BurbleController(ILogger<BurbleController> logger, IBurbRepository repository)
    {
        _logger = logger;
        _burbRepository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Burble>>> GetBurbs()
    {
        return Ok(await _burbRepository.GetAllBurbs());
    }
    
    [HttpGet]
    [Route("{burbId}")]
    public async Task<ActionResult<Burble>> GetBurbById(string burbId)
    {
        var burb = await _burbRepository.GetBurbById(burbId);
        if(burb == null){
            return NotFound();
        }
        return Ok(burb);
    }

    [HttpGet]
    [Route("{username}")]
    public async Task<ActionResult<Burble>> GetUserBurbs(string username)
    {
        var burb = await _burbRepository.GetBurbsByUsername(username);
        if(burb == null){
            return NotFound();
        }
        return Ok(burb);
    }

    [HttpPost]
    public async Task<ActionResult<Burble>> CreateBurb(Burble burb)
    {
        if(!ModelState.IsValid || burb == null)
        {
            return BadRequest();
        }
        var newBurb = await _burbRepository.CreateBurb(burb);
        return Created(nameof(GetBurbById), burb);
    }

    [HttpPut]
    [Route("{burbId}")]
    public async Task<ActionResult<Burble>> UpdateBurb(Burble burb)
    {
        if(!ModelState.IsValid || burb == null)
        {
            return BadRequest();
        }
        return Ok(await _burbRepository.UpdateBurb(burb));
    }

    [HttpDelete]
    [Route("{burbId}")]
    public async Task<ActionResult> DeleteBurb(string burbId)
    {
        await _burbRepository.DeleteBurbById(burbId);
        return NoContent();
    }
}