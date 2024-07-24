//manipuladores
using System;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Services; //armazenam se no domain
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler :
        Notifiable<Notification>,
        IHandler<CreateBoletoSubscriptionCommand>,
        IHandler<CreatePayPalSubscriptionCommand>
        {
            private readonly IStudentRepository _repository;
            private readonly IEmailService _emailService;

        public SubscriptionHandler(IStudentRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public ICommandResult Handle(CreateBoletoSubscriptionCommand)
        {
            //Fail fast validations
            CommandResult.Validate();
            if(CommandResult.Invalid)
            {
                AddNotifications(command);
                return new CommandResult(false, "nao foi possível realizar sua assinatura.");
            }

            //Verifica se o documento ja foi cadastrado
            if(_repository.DocumentExists(CommandResult.Document))
               AddNotification("Document", "Este CPF ja esta em uso");

             //Verifica se o email ja foi cadastrado
            if(_repository.DocumentExists(CommandResult.Email))
               AddNotification("Email", "Este CPF ja esta em uso");

            //GERAR OS VOs
            var name = new Name(CommandResult.FirstName, CommandResult.LastName);
            var document = new Document(command.Document, EDocumentType.CPF);
            var email = new Email(command.Email);
            var adress = new Adress((command.Street, CommandResult.Number, command.Neighborhood, command.City, CommandResult. ));

            var Payment = newBoletoPayment (
                command.BarCode,
                command.BoletoNumber,
                command.paidDate,
                command.ExpireDate,
                command.total,
                command.totalPaid,
                command.payer,
                command.document,
                command.adress,
                command.email): base(
                    paidDate,
                    expireDate,
                    total,
                    totalPaid,
                    payer,
                    document,
                    adress,
                    email);
                    {

                    }    
        }

        public ICommandResult Handle(CreatePayPalSubscriptionCommand command)
        {
            throw new NotImplementedException();
        }
    }
}