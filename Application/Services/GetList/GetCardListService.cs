using Application.Interfaces;

namespace Application.Services.GetList;

public class GetCardListService : IGetCardListService
{
    private readonly IApplicationDbContext _dbContext;

    public GetCardListService(IApplicationDbContext dbContext)
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
                CardNumber = c.CardNumber ,
                CVV2 = c.CVV2

            }).ToList();

        return cardList;

    }
}