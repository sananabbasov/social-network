using System;
using Microsoft.Extensions.Configuration;

namespace K401SocialApp.Core.Configurations
{
	public static class DatabaseConfiguration
	{
        public static string ConntectionString {
			get
			{
				ConfigurationManager configurationManager = new();
				configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../K401SocialApp.WebApi"));
				configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("DefaultConnection");
            }
		}
	}
}

