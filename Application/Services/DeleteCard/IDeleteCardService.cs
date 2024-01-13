using Application.Shared;

namespace Application.Services.DeleteCard;

public interface IDeleteCardService
{
    ResultDto Execute(int id);
}