using OpenRP.Framework.Shared.Chat.Enums;
using OpenRP.Framework.Features.PlayerSupport.Enums;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using System;
using System.Collections.Generic;

namespace OpenRP.Framework.Features.PlayerSupport.Components
{
    public abstract class SupportTicket
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Resolved { get; protected set; }
        public string Response { get; protected set; }
        public Player Staff { get; set; }
        public RequestType Type { get; }
        public List<SupportMessage> Messages { get;} = new List<SupportMessage>();

        protected SupportTicket(int ticketId, Player player, RequestType type)
        {
            Id = ticketId;
            Player = player;
            CreatedAt = DateTime.Now;
            Type = type;
            Resolved = false;
        }

        public virtual void Resolve(Player staff, string reason)
        {
            Resolved = true;
            Response = reason;
            Staff = staff;
        }

        public virtual void Deny(Player staff, string reason)
        {
            Resolved = true;
            Response = reason;
            Staff = staff;
        }
    }
}