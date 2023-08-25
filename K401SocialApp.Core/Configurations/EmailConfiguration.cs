using System;
using Microsoft.Extensions.Configuration;

namespace K401SocialApp.Core.Configurations
{
	public static class EmailConfiguration
	{
		public static string Email { get{ return GetConfiguration().GetSection("EmailSettings:Email").Value; } }
        public static string Password { get { return GetConfiguration().GetSection("EmailSettings:Password").Value; } }
        public static string Smtp { get { return GetConfiguration().GetSection("EmailSettings:Smtp").Value; } }
        public static int Port { get { return Convert.ToInt32(GetConfiguration().GetSection("EmailSettings:Port").Value); } }

        private static ConfigurationManager GetConfiguration()
		{
			ConfigurationManager configuration = new();
			configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../K401SocialApp.WebApi"));
            configuration.AddJsonFile("appsettings.json");
			return configuration;
        }


    }
}

