//classe criada para padronizar todos os valueobjects, herdando de notifiable (derivada do Flunt.Notifications)
using Flunt.Validations;
using Flunt.Notifications;

namespace PaymentContext.Shared.ValueObjects
{
    public abstract class ValueObject : Notifiable<Notification>
    {

    }
}