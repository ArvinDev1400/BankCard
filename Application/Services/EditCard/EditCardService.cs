using Application.Interfaces;
using Application.Shared;

namespace Application.Services.EditCard;

public class EditCardService : IEditCardService
{

    public readonly IApplicationDbContext _dbContext;

    public EditCardService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ResultDto Execute(CardEditDto card)
    {
        var findCard = _dbContext.Cards.Find(card.Id);
        if (findCard is null)
        {
            return new ResultDto(false , "کارت بانکی با مشخصات ارسالی یافت نشد.");
        }
        else
        {
            findCard.Update(card.FirstName , card.LastName , card.CardNumber , card.AccountNumber , card.ExpirationDate , card.Shaba , card.CVV2 , card.BankName);
            _dbContext.SaveChanges();
            return new ResultDto(true , "اطلاعات کارت با موفقیت ویرایش شد");
        }
    }
}