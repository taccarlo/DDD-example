using System;
using MediatR;

namespace NimblePros.DotNetConf.SharedKernel;

public abstract class BaseDomainEvent : INotification
{
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
