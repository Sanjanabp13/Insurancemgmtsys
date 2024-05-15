using System;
namespace InsuranceManagementSystem.Model
{
	public class Payment
	{
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public int ClientId { get; set; }

        public Payment() { }

        public Payment(int paymentId, DateTime paymentDate, decimal paymentAmount, int clientId)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            PaymentAmount = paymentAmount;
            ClientId = clientId;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Payment ID: {PaymentId}");
            Console.WriteLine($"Payment Date: {PaymentDate}");
            Console.WriteLine($"Payment Amount: {PaymentAmount}");
            Console.WriteLine($"Client ID: {ClientId}");
        }
        public override string ToString()
        {
            return $"Payment ID: {PaymentId}, Payment Date: {PaymentDate}, Amount: {PaymentAmount}";
        }
    }
}

