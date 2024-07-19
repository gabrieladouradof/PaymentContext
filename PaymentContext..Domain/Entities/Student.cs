
using System.Text.RegularExpressions;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student 
    {
        private IList<string> Notifications;
        private IList<Subscription> _subscriptions;
        //geracao de construtor
        public Student(Name name, string? document, string? email)
        {
            Name = name;
            Document = document;
            Email = email;
            //nao precisamos do aadress no momento
            _subscriptions = new List<Subscription>();

    
        }

        public Name Name { get; set; }    
        public string? Document { get; set; }
        public string? Email { get; set; }
        public string? Adress {get; set;}

        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray();}}
        
        public void AddSubscription(Subscription subscription)
        {
            //implementando validacoes
            //if (true)
             //   throw 


            //se ja tiver assinatura ativa, cancela
            //cancela todas as assinaturas, e coloca esta como principal
            foreach (var sub in Subscriptions)
                sub.Inactivate();
            
            _subscriptions.Add(subscription);
        }
    }
}