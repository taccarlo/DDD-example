using NimblePros.DotNetConf.Core.ProjectAggregate;
using NimblePros.DotNetConf.SharedKernel;

namespace NimblePros.DotNetConf.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
    public ToDoItem CompletedItem { get; set; }

    public ToDoItemCompletedEvent(ToDoItem completedItem)
    {
        CompletedItem = completedItem;
    }
}
