using System.Windows.Input;

namespace PaymentContext.Shared.Handlers 
{
    public interface ICommandHandler<T> where T : ICommand
}