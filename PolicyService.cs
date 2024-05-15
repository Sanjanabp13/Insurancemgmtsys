using System;
using InsuranceManagementSystem.Model;


namespace InsuranceManagementSystem.Service
{
    public class PolicyService : IPolicyService
    {
        private readonly IPolicyRepository policyRepository;


        public PolicyService(IPolicyRepository policyRepository)
        {
            this.policyRepository = policyRepository;

        }

        public bool CreatePolicy()
        {
            try
            {
                Console.WriteLine("Enter policy details:");
                Console.Write("Policy number: ");
                string policyName = Console.ReadLine();
                Console.Write("Policy ID: ");
                int policyId = int.Parse(Console.ReadLine());
                

                Policy newPolicy = new Policy
                {
                    PolicyNumber = policyName,
                    PolicyId=policyId
                   
                };

                return policyRepository.CreatePolicy();
            }
            catch (ApplicationException ex)
            {
                
                throw new ApplicationException("Failed to create policy", ex);
            }

            public Policy GetPolicy()
            {
                try
                {
                    Console.Write("Enter policy ID: ");
                    int policyId = int.Parse(Console.ReadLine());
                    return policyRepository.GetPolicy(policyId);
                }
                catch (ApplicationException ex)
                {
                    
                    throw new ApplicationException("Failed to retrieve policy", ex);
                }

            }

            public List<Policy> GetAllPolicies(int policyId)
            {
                try
                {
                    
                    if (policyId > 0)
                    {
                        return policyRepository.GetAllPolicies(policyId);
                    }
                    else
                    {
                        Console.Write("Enter policy ID: ");
                        policyId = int.Parse(Console.ReadLine());

                        
                        return policyRepository.GetAllPolicies(policyId);
                    }
                }
                catch (ApplicationException ex)
                {
                    
                    throw new ApplicationException("Failed to retrieve policies", ex);
                }
            }
        }

            public bool UpdatePolicy(Policy policy)
            {
                try
                {
                    Console.Write("Enter policy ID to update: ");
                    int policyId = int.Parse(Console.ReadLine());

                    Policy existingPolicy = policyRepository.GetPolicy(policyId);
                    if (existingPolicy == null)
                    {
                        Console.WriteLine("Policy not found.");
                        return false;
                    }

                    Console.WriteLine("Enter updated policy details:");
                    Console.Write("Policy number: ");
                    string policyName = Console.ReadLine();
                    Console.Write("Policy name: ");
                    string name = Console.ReadLine();
                   
                    Policy updatedPolicy = new Policy
                    {
                        PolicyId = policyId,
                        PolicyName = policyName
                      
                    };

                    return policyRepository.UpdatePolicy(updatedPolicy);
                }
                catch (ApplicationException ex)
                {
                    
                    throw new ApplicationException("Failed to update policy", ex);
                }
            }

            public bool DeletePolicy()
            {
                try
                {
                    Console.Write("Enter policy ID to delete: ");
                    int policyId = int.Parse(Console.ReadLine());
                    return policyRepository.DeletePolicy(policyId);
                }
                catch (ApplicationException ex)
                {
                    
                    throw new ApplicationException("Failed to delete policy", ex);
                }
            }


        }
    }


