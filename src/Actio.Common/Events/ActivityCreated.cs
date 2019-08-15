using System;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        protected ActivityCreated()
        {
        }

        public ActivityCreated(Guid userId, Guid id, string category, string name, string description, DateTime createdAt)
        {
            this.UserId = userId;
            this.Id = id;
            this.Category = category;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;

        }
        public Guid UserId { get; }

        public Guid Id { get; }
        public string Category { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }
    }
}