
namespace PaymentContext.Domain.Entities
{
    public class Student 
    {
        private IList<Subscription> _subscriptions;
        //geracao de construtor
        public Student(string? firstName, string? lastName, string? document, string? email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            //nao precisamos do aadress no momento
            _subscriptions = new List<Subscription>();
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Document { get; set; }
        public string? Email { get; set; }
        public string? Adress {get; set;}

        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray();}}
        
        public void AddSubscription(Subscription subscription)
        {
            //se ja tiver assinatura ativa, cancela
            //cancela todas as assinaturas, e coloca esta como principal
            foreach (var sub in Subscriptions)
                sub.Inactivate();
            
            _subscriptions.Add(subscription);
        }
    }
}