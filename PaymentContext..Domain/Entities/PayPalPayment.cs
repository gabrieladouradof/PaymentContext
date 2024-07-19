using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities 
{  
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
        string? transactionCode,
        DateTime paidDate, 
        DateTime expireDate, 
        decimal total, 
        decimal totalPaid, 
        string payer, 
        Document document,
        Adress adress,
        Email email): base(
            paidDate,
            expireDate,
            total, 
            totalPaid, 
            payer, 
            document, 
            adress, 
            email)
        //recebe do construtor e repassa com o base
        {
            TransactionCode = transactionCode;
        }

        public string? TransactionCode { get; private set; }
    }
}