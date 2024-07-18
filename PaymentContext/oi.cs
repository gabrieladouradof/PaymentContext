cimal total, 
            decimal totalPaid, 
            string payer, 
            string document,
            string adress, string email): base(
            paidDate,
            expireDate,
            total, 
            totalPaid, 
            payer, 
            document, 
            adress, 
            email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string? BarCode { get; private set
