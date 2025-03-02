using System;

class CreditCard
{
    public string CardNumber { get; }
    public string Name { get; }
    public DateTime Date { get; }
    public string CVC { get; }
    public string PinCode { get; private set; }
    public decimal CreditLimit { get; }
    public decimal Balance { get; private set; }

    public CreditCard(string cardNumber, string name, DateTime date, string cvc, decimal creditLimit)
    {
        CardNumber = cardNumber;
        Name = name;
        Date = date;
        CVC = cvc;
        CreditLimit = creditLimit;
        Balance = 0;
        PinCode = "0000";
    }

    public void Add(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Account is replenished by {amount} UAH. Current balance: {Balance} UAH");
    }

    public void Spend(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"You spent {amount} UAH. Now balance: {Balance} UAH");
        }
        else
        {
            decimal deficit = amount - Balance;
            if (deficit <= CreditLimit)
            {
                Console.WriteLine("You have used credit money");
                Balance -= amount;
                Console.WriteLine($"You spent {amount} UAH. Now balance: {Balance} UAH");
            }
            else
            {
                Console.WriteLine("Transaction declined! Not enough funds.");
            }
        }
    }

    public void ChangePin(string newPin)
    {
        PinCode = newPin;
        Console.WriteLine("PIN code successfully changed.");
    }
}

class Program
{
    static void Main()
    {
        CreditCard card = new CreditCard("7890 6754 3456 6789", "Maxim Apelsit", new DateTime(2025, 01, 22), "1234", 500);

        card.Add(19000);
        card.Spend(9000);
        card.Spend(500);
        card.Spend(1000);
        card.Spend(8700);
        card.ChangePin("9870");
    }
}