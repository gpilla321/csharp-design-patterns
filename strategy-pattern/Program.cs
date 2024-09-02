using strategy_pattern;
using strategy_pattern.Models;
using strategy_pattern.Payment;

var destination = SelectedDestination();
PrintDivider();
Console.WriteLine($"You selected: {destination.Id} - {destination.Name} for EUR {destination.Price}");
PrintDivider();

var paymentMethod = SelectedPaymentMethod();

PrintDivider();

Console.WriteLine($"You selected: {paymentMethod.Name}");
Console.WriteLine("Making payment...");

IPaymentStrategy paymentStrategy = null;

switch (paymentMethod.Method)
{
    case PaymentMethodEnum.CreditCard:
        paymentStrategy = new CreditCardPayment();
        break;
    case PaymentMethodEnum.DebitCard:
        paymentStrategy = new DebitCardPayment();
        break;
    case PaymentMethodEnum.Paypal:
        paymentStrategy = new PaypalPayment();
        break;
    case PaymentMethodEnum.BankTransfer:
        paymentStrategy = new BankTransferPayment();
        break;
    default:
        Console.WriteLine("Invalid payment method");
        break;
}

if (paymentStrategy != null)
{
    var paymentContext = new Payment(paymentStrategy);
    var paymentResult = await paymentContext.Pay(destination.Price);
    Console.WriteLine($"Success! You paid {destination.Price} using {paymentMethod.Name}");
}

Console.WriteLine("Press any key to exit");
Console.ReadLine();

static Destination SelectedDestination()
{
    var destionationList = Helper.GetDestinationList();

    Console.WriteLine("Select a destination:");

    destionationList.ForEach(_ => Console.WriteLine($"{_.Id}. {_.Name} - {_.Price}$"));

    var result = Console.ReadLine();
    var record = destionationList.FirstOrDefault(x => x.Id == int.Parse(result));

    if (record == null)
    {
        Console.WriteLine("Invalid destination. Finishing the app");
        Environment.Exit(0);
    }

    return record;
}

static PaymentMethod SelectedPaymentMethod()
{
    var paymentMethodList = Helper.GetPaymentMethods();

    Console.WriteLine("Select a payment method:");

    paymentMethodList.ForEach(_ => Console.WriteLine($"{_.Id}. {_.Name}"));

    var result = Console.ReadLine();
    var record = paymentMethodList.FirstOrDefault(x => x.Id == int.Parse(result));

    if (record == null)
    {
        Console.WriteLine("Invalid payment method. Finishing the app");
        Environment.Exit(0);
    }

    return record;
}
static void PrintDivider() => Console.WriteLine("- - - - - - - ");