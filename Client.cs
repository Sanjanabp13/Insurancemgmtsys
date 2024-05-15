using System;
namespace InsuranceManagementSystem.Model
{
	public class Client
	{
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ContactInfo { get; set; }
        public string Policy { get; set; }

        public Client() { }

        public Client(int clientId, string clientName, string contactInfo, string policy)
        {
            ClientId = clientId;
            ClientName = clientName;
            ContactInfo = contactInfo;
            Policy = policy;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Client ID: {ClientId}");
            Console.WriteLine($"Client Name: {ClientName}");
            Console.WriteLine($"Contact Info: {ContactInfo}");
            Console.WriteLine($"Policy: {Policy}");
        }

        public override string ToString()
        {
            return $"Client ID: {ClientId}, Client Name: {ClientName}, Policy: {Policy}";
        }

    }
}


