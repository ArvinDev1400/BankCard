using Application.Interfaces;
using Application.Shared;

namespace Application.Services.DeleteCard;

public class DeleteCardService : IDeleteCardService
{
    private readonly IApplicationDbContext _dbContext;

    public DeleteCardService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ResultDto Execute(int id)
    {
        var card = _dbContext.Cards.Find(id);
        if (card is null)
        {
            return new ResultDto(false, "کارت مورد نظر یافت نشد.");
        }
        else
        {
            _dbContext.Cards.Remove(card);
            _dbContext.SaveChanges();
            return new ResultDto(true, "عملیات حذف با موفقیت انجام شد.");
        }
    }
}