using System;
namespace InsuranceManagementSystem.Exception
{
	public class PolicyNotFoundException:ApplicationException
	{
        public PolicyNotFoundException(string? message) : base(message) { }
    }
}

