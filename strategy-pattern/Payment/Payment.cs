using strategy_pattern.Models;

namespace strategy_pattern.Payment
{
    public class Payment
    {
        private IPaymentStrategy _payment;

        public Payment(IPaymentStrategy payment)
        {
            _payment = payment;
        }

        public async Task<PaymentResult> Pay(int amount)
        {
            return await _payment.Pay(amount);
        }
    }
}
