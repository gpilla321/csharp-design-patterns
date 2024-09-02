namespace strategy_pattern.Service
{
    public static class FakePaymentService
    {
        public static async Task<bool> PaypalPay(int amount)
        {
            await FakeResponseTime();

            // Fake payment processing
            return true;
        }

        public static async Task<bool> DebitCardPay(int amount)
        {
            await FakeResponseTime();

            // Fake payment processing
            return true;
        }

        public static async Task<bool> CreditCardPay(int amount)
        {
            await FakeResponseTime();

            // Fake payment processing
            return true;
        }

        public static async Task<bool> BankTransferPay(int amount)
        {
            await FakeResponseTime();

            // Fake payment processing
            return true;
        }

        private static async Task FakeResponseTime()
        {
            var random = new Random();
            int randomNumber = random.Next(2, 7);

            await Task.Delay(randomNumber * 1000);
        }
    }
}
