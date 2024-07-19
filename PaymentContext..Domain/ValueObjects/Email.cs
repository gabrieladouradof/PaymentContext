namespace PaymentContext.Domain.ValueObjects 
{
    public class Email
    {
        public Email(string adress)
        {
            Adress = adress;
        }

        public string? Adress { get; set; }
        
    }
}