using Application.Interfaces;

namespace Application.Services.GetList;

public interface IGetCardList
{
    List<CardListDto> Execute();
}

public class GetCardList : IGetCardList
{
    private readonly IApplicationDbContext _dbContext;

    public GetCardList(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public List<CardListDto> Execute()
    {
        var cardList = _dbContext.Cards
            .Select(c => new CardListDto()
            {
                Id = c.Id ,
                FirstName = c.FirstName ,
                LastName = c.LastName ,
                CardNumber = c.CardNumber
            }).ToList();

        return cardList;

    }
}

public class CardListDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string CardNumber { get; set; }

}