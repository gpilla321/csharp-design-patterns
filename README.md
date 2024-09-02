This is a small simulation of a real world scenario. 


## Pick a destination
Choose between Italy, France or Spain. 

## Pick your payment method
Debit card, credit card, Paypal or bank transfer.

Then the strategy patterns starts to act.

### IPayment 
Interface with a simple `Pay(amount: number)` method.

Each payment method will (or should) contact a third party service to validate the transaction. Since it's a simulation, no third-party api was called. I faked everything just in order to simulate the environment.

![image](https://github.com/user-attachments/assets/e42c671b-dbb8-41f1-850a-9973e8451900)

Here's the workflow diagram
![image](https://github.com/user-attachments/assets/9c6a9ed3-30c9-4e38-8875-2a10c76f9d10)
