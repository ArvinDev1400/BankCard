using Application.Interfaces;
using Application.Shared;
using Domain.Entities;

namespace Application.Services.AddCard;

public class AddCardService : IAddCardService
{
    private readonly IApplicationDbContext _dbContext;

    public AddCardService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }



    public ResultDto Execute(AddCardDto card)
    {
        var newCard = new Card(card.FirstName , card.LastName , card.CardNumber , card.AccountNumber , card.ExpirationDate ,
            card.Shaba , card.CVV2 , card.BankName);

        _dbContext.Cards.Add(newCard);
        _dbContext.SaveChanges();
        return new ResultDto(true , "عملیات افزودن کارت جدید با موفقیت انجام شد");
    }
}