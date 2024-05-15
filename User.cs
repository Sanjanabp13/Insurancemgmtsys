using System;
namespace InsuranceManagementSystem.Model
{
	public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User() { }

        public User(int userId, string username, string password, string role)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Role = role;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"User ID: {UserId}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Role: {Role}");
        }


        public override string ToString()
        {
            return $"User ID: {UserId}, Username: {Username}, Role: {Role}";
        }
    }
}
	

