using Application.Shared;

namespace Application.Services.AddCard;
public interface IAddCardService
{
    ResultDto Execute(AddCardDto card);
}