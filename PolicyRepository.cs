using System;
using InsuranceManagementSystem.Model;
using System.Data.SqlClient;

namespace InsuranceManagementSystem.Repositories
{
	public class PolicyRepository : IPolicyRepository
    {
        private readonly string connectionString;

        public PolicyRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        public PolicyRepository()
        {
            sqlConnection = new SqlConnection(" Server = localhost; Database = CourierManagementSystem; User ID = sa; Password = dockerStrongPwd123; TrustServerCertificate = True");
            cmd = new SqlCommand();

        }

        public List<Policy> GetAllPolicies()
        {
            List<Policy> policies = new List<Policy>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT PolicyId, PolicyName FROM Policies";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Policy policy = new Policy
                        {
                            PolicyId = Convert.ToInt32(reader["PolicyId"]),
                            PolicyName = reader["PolicyName"].ToString()
                        };
                        policies.Add(policy);
                    }
                }
            }
            return policies;
        }

        public Policy GetPolicy(int policyId)
        {
            Policy policy = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT PolicyName FROM Policies WHERE PolicyId = @PolicyId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PolicyId", policyId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        policy = new Policy
                        {
                            PolicyId = policyId,
                            PolicyName = reader["PolicyName"].ToString()
                        };
                    }
                }
            }
            return policy;
        }

        public bool CreatePolicy(Policy policy)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Policies (PolicyName) VALUES (@PolicyName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PolicyName", policy.PolicyName);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool UpdatePolicy(Policy policy)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Policies SET PolicyName = @PolicyName WHERE PolicyId = @PolicyId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PolicyName", policy.PolicyName);
                command.Parameters.AddWithValue("@PolicyId", policy.PolicyId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool DeletePolicy(int policyId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Policies WHERE PolicyId = @PolicyId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PolicyId", policyId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}



