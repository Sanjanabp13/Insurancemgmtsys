using System;
namespace InsuranceManagementSystem.Model
{
	public class Claim
	{
        public int ClaimId { get; set; }
        public string ClaimNumber { get; set; }
        public DateTime DateFiled { get; set; }
        public decimal ClaimAmount { get; set; }
        public string Status { get; set; }
        public string Policy { get; set; }
        public int ClientId { get; set; }

        public Claim() { }

        public Claim(int claimId, string claimNumber, DateTime dateFiled, decimal claimAmount, string status, string policy, int clientId)
        {
            ClaimId = claimId;
            ClaimNumber = claimNumber;
            DateFiled = dateFiled;
            ClaimAmount = claimAmount;
            Status = status;
            Policy = policy;
            ClientId = clientId;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Claim ID: {ClaimId}");
            Console.WriteLine($"Claim Number: {ClaimNumber}");
            Console.WriteLine($"Date Filed: {DateFiled}");
            Console.WriteLine($"Claim Amount: {ClaimAmount}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Policy: {Policy}");
            Console.WriteLine($"Client ID: {ClientId}");
        }
        public override string ToString()
        {
            return $"Claim ID: {ClaimId}, Claim Number: {ClaimNumber}, Status: {Status}";
        }

    }
}

