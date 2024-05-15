using System;
using Microsoft.Extensions.Configuration;

namespace InsuranceManagementSystem.Util
{
	public class Dbutil
	{
        private static IConfiguration _iconfiguration;
        static Dbutil()
        {
            GetAppSettingsFile();
        }

        public static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            _iconfiguration = builder.Build();

        }

        public static string GetConnectionString()
        {
            return _iconfiguration.GetConnectionString("LocalConnectionString");
        }
    }
}

