using Application.Shared;

namespace Application.Services.GetById;

public interface IGetCardByIdService
{
    ResultDto<CardByIdDto> Execute(int id);
}