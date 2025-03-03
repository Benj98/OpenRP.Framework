using SampSharp.Entities.SAMP;
using OpenRP.Framework.Features.PlayerSupport.Components;

namespace OpenRP.Framework.Features.PlayerSupport.Components
{
    public class SupportMessage 
    {
        public Player Sender { get; }
        public bool IsStaff { get; }
        public string Message { get; }
        public DateTime SentAt { get; }
        
        public SupportMessage(Player sender, bool isStaff, string message)
        {
            Sender = sender;
            IsStaff = isStaff;
            Message = message;
            SentAt = DateTime.Now;
        }
    }
}