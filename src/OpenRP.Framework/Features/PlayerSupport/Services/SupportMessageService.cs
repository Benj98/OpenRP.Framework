using OpenRP.Framework.Features.PlayerSupport.Components;
using OpenRP.Framework.Shared.Chat.Enums;
using OpenRP.Framework.Shared.Chat.Extensions;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenRP.Framework.Features.PlayerSupport.Services
{
    public class SupportMessageService : ISupportMessageService
    {
        private readonly IEntityManager _entityManager;

        public SupportMessageService(IEntityManager entityManager)
        {
            _entityManager = entityManager;
        }

        public SupportMessage AddMessage(SupportTicket ticket, Player sender, string message, bool isStaff = false)
        {
            SupportMessage supportMessage = new SupportMessage(sender, isStaff, message);
            ticket.Messages.Add(supportMessage);

           SendSupportMessage(ticket, supportMessage);

            return supportMessage;
        }

        private void SendSupportMessage(SupportTicket ticket, SupportMessage message)
        {
            throw new NotImplementedException();
        }
    }
}