using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CommandResult: ICommandResult
    {
        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message; 
        }

        public static string? FirstName { get; internal set; }
        public bool Success { get; set; }
        public string? Message { get; set; }

    }
}