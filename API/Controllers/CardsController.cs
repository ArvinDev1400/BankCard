using Application.Services.AddCard;
using Application.Services.GetList;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CardsController : ControllerBase
{


    private readonly IGetCardListService _getCardListService;
    private readonly IAddCardService _addCardService;

    public CardsController(IGetCardListService getCardListService , IAddCardService addCardService)
    {
        _getCardListService = getCardListService;
        _addCardService = addCardService;
    }


    [HttpGet]
    public IActionResult Get()
    {
        var result = _getCardListService.Execute();
        return Ok(result);
    }

    // GET api/<CardsController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<CardsController>
    [HttpPost]
    public IActionResult Post([FromBody] AddCardDto card)
    {
        var result = _addCardService.Execute(card);
        return Ok(result);
    }

    // PUT api/<CardsController>/5
    [HttpPut("{id}")]
    public void Put(int id , [FromBody] string value)
    {
    }

    // DELETE api/<CardsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
