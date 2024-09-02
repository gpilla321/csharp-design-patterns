using strategy_pattern.Models;

namespace strategy_pattern
{
    public static class Helper
    {
        public static List<Destination> GetDestinationList() => new List<Destination>() {
            new Destination(1, "Italy", 239),
            new Destination(2, "France", 187),
            new Destination(3, "Spain", 213)
        };

        public static List<PaymentMethod> GetPaymentMethods() => new List<PaymentMethod>()
        {
            new PaymentMethod() { Id = 1, Name = "Debit Card", Method = PaymentMethodEnum.DebitCard },
            new PaymentMethod() { Id = 2, Name = "Credit Card", Method = PaymentMethodEnum.CreditCard },
            new PaymentMethod() { Id = 3, Name = "Paypal", Method = PaymentMethodEnum.Paypal },
            new PaymentMethod() { Id = 4, Name = "Bank Transfer", Method = PaymentMethodEnum.BankTransfer }
        };
    }
}
