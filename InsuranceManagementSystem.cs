using System;
using InsuranceManagementSystem.Service;

internal class InsuranceSystem
{
     readonly IPolicyService _policyService;

    public InsuranceSystem()
    {
        _policyService = new PolicyService();
    }

    public void Menu()
        {
            while (true)
            {
                Console.WriteLine("WELCOME TO INSURANCE SYSTEM APPLICATION");
                Console.WriteLine("Here are the options from which you can choose:");
                Console.WriteLine("1. New User (Create Policy)");
                Console.WriteLine("2. Existing User");
                Console.WriteLine("3. Exit");
                Console.Write("Select an Option: ");
                int userOption = int.Parse(Console.ReadLine());

                switch (userOption)
                {
                    case 1:
                        
                        var newUser = _policyService.CreatePolicy();
                        if (newUser != null)
                        {
                            Console.WriteLine("New policy created successfully.");
                            _policyService.CreatePolicy();
                        }
                        break;
                    case 2:
                       
                        Console.WriteLine("1. CreatePolicy");
                        Console.WriteLine("2. Getpolicy");
                        Console.WriteLine("3. Getallpolicies");
                        Console.WriteLine("4. Updatepolicy");
                        Console.WriteLine("5. deletepolicy");
                        
                        Console.Write("Select an Option: ");
                        int existingUserMethodOption = int.Parse(Console.ReadLine());
                        switch (existingUserMethodOption)
                        {
                            case 1:
                                _policyService.CreatePolicy();
                                break;
                            case 2:
                                _policyService.GetPolicy();
                                break;
                            case 3:
                                _policyService.GetAllPolicies();
                                break;
                            case 4:
                                _policyService.UpdatePolicy();

                                break;
                            case 5:
                                _policyService.DeletePolicy();
                                break;
                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting the application.");
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
}

