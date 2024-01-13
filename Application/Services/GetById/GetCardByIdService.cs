using Application.Interfaces;
using Application.Shared;

namespace Application.Services.GetById;

public class GetCardByIdService : IGetCardByIdService
{

    private readonly IApplicationDbContext _dbContext;

    public GetCardByIdService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ResultDto<CardByIdDto> Execute(int id)
    {
        var result = _dbContext.Cards.Find(id);
        if (result is null)
        {
            return new ResultDto<CardByIdDto>()
            {
                IsSuccess = false ,
                Message = "مشخصات کارت بانکی یافت نشد." ,
                Data = null
            };
        }
        else
        {
            return new ResultDto<CardByIdDto>()
            {
                IsSuccess = true ,
                Message = "مشخصات کارت بانکی برگشت داده شد" ,
                Data = new CardByIdDto()
                {
                    Id = result.Id ,
                    AccountNumber = result.AccountNumber ,
                    BankName = result.BankName ,
                    CVV2 = result.CVV2 ,
                    CardNumber = result.CardNumber ,
                    ExpirationDate = result.ExpirationDate ,
                    FirstName = result.FirstName ,
                    LastName = result.LastName ,
                    Shaba = result.Shaba
                }
            };
        }
    }
}