namespace strategy_pattern.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public PaymentMethodEnum Method { get; set; }
    }

    public enum PaymentMethodEnum
    {
        DebitCard,
        CreditCard,
        Paypal,
        BankTransfer
    }
}
