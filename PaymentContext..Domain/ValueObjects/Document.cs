using System.Globalization;
using PaymentContext.Domain.Enums;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
    public Document(string number, EDocumentType type)
    {
        Number = number;
        Type = type;

        
    }
    
    public string Number { get; private set; }
    public EDocumentType Type { get; private set; }
}

    private bool Validate()
    {
        if (Type == EDocumentType.CNPJ && NumberFormatInfo.Length == 14)
            return true;
        
        if (Type == EDocumentType.CPF && NumberFormatInfo.Length == 11)
            return true;
        
        return false;
    }
}
