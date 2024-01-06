using Domain.Enums;

namespace Domain.Entities;

public class Card
{
    public Card()
    { }

    public int Id { get; set; }
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string CardNumber { get; private set; }
    public string? AccountNumber { get; private set; }
    public DateTime ExpirationDate { get; private set; }
    public string? Shaba { get; private set; }
    public string? CVV2 { get; private set; }
    public BankName BankName { get; private set; }

    public Card(
        string firstName ,
        string lastName ,
        string cardNumber ,
        string accountNumber ,
        DateTime expirationDate ,
        string shaba ,
        string cvv2 ,
        BankName bankName)
    {

        FirstName = firstName;
        LastName = lastName;
        CardNumber = cardNumber;
        AccountNumber = accountNumber;
        ExpirationDate = expirationDate;
        Shaba = shaba;
        CVV2 = cvv2;
        BankName = bankName;
    }
}