using strategy_pattern.Models;

namespace strategy_pattern.Payment
{
    public interface IPaymentStrategy
    {
        Task<PaymentResult> Pay(int amount);
    }
}
