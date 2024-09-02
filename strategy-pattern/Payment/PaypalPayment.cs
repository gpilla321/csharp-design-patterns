using strategy_pattern.Models;
using strategy_pattern.Service;

namespace strategy_pattern.Payment
{
    internal class PaypalPayment : IPaymentStrategy
    {
        public async Task<PaymentResult> Pay(int amount)
        {
            var success = await FakePaymentService.PaypalPay(amount);

            return new PaymentResult
            {
                Success = success,
                Message = "Success"
            };
        }
    }
}
