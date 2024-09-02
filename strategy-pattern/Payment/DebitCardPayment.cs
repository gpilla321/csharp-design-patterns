using strategy_pattern.Models;
using strategy_pattern.Service;

namespace strategy_pattern.Payment
{
    public class DebitCardPayment : IPaymentStrategy
    {
        public async Task<PaymentResult> Pay(int amount)
        {
            var success = await FakePaymentService.DebitCardPay(amount);

            return new PaymentResult
            {
                Success = success,
                Message = "Success"
            };
        }
    }
}
