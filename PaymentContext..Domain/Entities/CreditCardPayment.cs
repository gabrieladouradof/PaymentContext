namespace PaymentContext.Domain.Entities 
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string? cardHolderName, 
            string? cardNumber, 
            string? lastTransactionNumber, 
            DateTime paidDate, 
            DateTime expireDate, 
            decimal total, 
            decimal totalPaid, 
            string payer, 
            string document,
            string adress, string email): base(
            paidDate,
            expireDate,
            total, 
            totalPaid, 
            payer, 
            document, 
            adress, 
            email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string? CardHolderName { get; private set;}
        public string? CardNumber { get; private set; } //ultimos 4 digitos
        public string? LastTransactionNumber { get; private set; }
    }
}