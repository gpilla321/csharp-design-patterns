using strategy_pattern.Models;
using strategy_pattern.Service;

namespace strategy_pattern.Payment
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public async Task<PaymentResult> Pay(int amount)
        {
            var success = await FakePaymentService.BankTransferPay(amount);

            return new PaymentResult
            {
                Success = success,
                Message = "Success"
            };
        }
    }
}
