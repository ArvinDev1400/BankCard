using Domain.Enums;

namespace Application.Services.EditCard;

public class CardEditDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string CardNumber { get; set; } = string.Empty;
    public string? AccountNumber { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string? Shaba { get; set; }
    public string? CVV2 { get; set; }
    public BankName BankName { get; set; }
}