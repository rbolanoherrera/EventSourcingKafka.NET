using CQRS.Core.Messages;

namespace CQRS.Core.Events
{
    public class BaseEvent : Message
    {
        public int Version { get; set; }
        public string Type { get; set; }
        
        protected BaseEvent(string type)
        {
            this.Type = type;
        }
    }
}