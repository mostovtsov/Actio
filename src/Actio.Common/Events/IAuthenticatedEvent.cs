using System;
namespace Actio.Common.Events
{
    public interface IAuthenticatedEvent
    {
        Guid UserId { get; }
    }
}