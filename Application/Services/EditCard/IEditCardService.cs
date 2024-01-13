using Application.Shared;

namespace Application.Services.EditCard;

public interface IEditCardService
{
    ResultDto Execute(CardEditDto card);
}