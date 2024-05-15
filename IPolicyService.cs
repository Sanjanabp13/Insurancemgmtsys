using System;
namespace InsuranceManagementSystem.Service
{
    interface IPolicyService
    {
       public bool CreatePolicy();
       public Policy GetPolicy();
       public List<Policy> GetAllPolicies();
       public bool UpdatePolicy();
       public bool DeletePolicy();
    }
}

