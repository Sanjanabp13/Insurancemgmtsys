using System;
namespace InsuranceManagementSystem.Model
{
	public class Policy
	{
        private int policyId;
        private string policyName;

        
        public Policy()
        {
        }

        
        public Policy(int policyId, string policyName)
        {
            this.policyId = policyId;
            this.policyName = policyName;
        }

        
        public int PolicyId
        {
            get { return policyId; }
            set { policyId = value; }
        }

        public string PolicyNumber
        {
            get { return policyName; }
            set { policyName = value; }
        }

        
        public void PrintDetails()
        {
            Console.WriteLine($"Policy ID: {policyId}");
            Console.WriteLine($"Policy Number: {policyName}");
        }

       
        public override string ToString()
        {
            return $"Policy ID: {policyId}, Policy Number: {policyName}";
        }
    }
}


