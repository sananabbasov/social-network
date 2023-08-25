using System;
using K401SocialApp.Core.Utilities.EmailHelper;
using K401SocialApp.Entities.SharedModels;
using MassTransit;

namespace K401SocialApp.Business.Consumers
{
    public class ReciveEmailConsumer : IConsumer<SendEmailConfirmationCommand>
    {
        private readonly IEmailSender _emailSender;

        public ReciveEmailConsumer(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task Consume(ConsumeContext<SendEmailConfirmationCommand> context)
        {
            //_emailSender.SendMail(context.Message.Email, context.Message.Token,true);
        }
    }
}

