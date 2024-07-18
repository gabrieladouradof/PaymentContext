using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var student = new Student ("Andre", "Baltieri", "12332112312", "hello@balta.io");
          
            //solid - letra s - responsabilidade unica
            student.FirstName = "";


        }
    }
}