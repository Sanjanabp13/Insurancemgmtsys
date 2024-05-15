using System;
namespace InsuranceManagementSystem.Repositories
{
	public interface IPolicyRepository
	{
        List<Policy> GetAllPolicies(int policyId);
        Policy GetPolicy(int policyId);
        bool CreatePolicy(Policy policy);
        bool UpdatePolicy(Policy policy);
        bool DeletePolicy(int policyId);
    }
}

