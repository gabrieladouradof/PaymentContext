using System.Reflection.Metadata;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using Flunt.Validations;

namespace PaymentContext.Domain.Entities 
{
    public abstract class Payment : Entity
    {
        // public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Adress adress, Email email)
        // {
        //     PaidDate = paidDate;
        //     ExpireDate = expireDate;
        //     Total = total;
        //     TotalPaid = totalPaid;
        //     Payer = payer;
        //     Document = document;
        //     Adress = adress;
        //     Email = email;
        // }

        public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string? payer, Document document, Adress adress, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Adress = adress;
            Email = email;

            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(0, Total, "Payment.Total", "O total nao pode ser zero")
                .IsGreaterOrEqualThan(Total, TotalPaid, "Payment.TotalPaid", "O valor pago é menor que o valor do pagamento")
            );
        }

        public string? Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get;private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string? Payer {get; private set;}
        public Document document { get; private set;}
        public Adress Adress { get; private set;}
        public Email Email { get; private set; }
    }
}
