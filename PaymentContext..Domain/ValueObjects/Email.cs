using System.Diagnostics.Contracts;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects 
{
    public class Email
    {
        public Email(string adress)
        {
            Adress = adress;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Adress, "Email.Adress", "E-mail inválido")
            );
            
        }
        

        public string? Adress { get; set; }
        
    }
}