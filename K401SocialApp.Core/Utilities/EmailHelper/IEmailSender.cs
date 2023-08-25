using System;
namespace K401SocialApp.Core.Utilities.EmailHelper
{
	public interface IEmailSender
	{
        bool SendMail(string mailAddress, string message, bool bodyHtml);
    }
}

