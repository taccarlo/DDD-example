using Ardalis.Specification;

namespace NimblePros.DotNetConf.Core.ProjectAggregate.Specifications;

public class IncompleteItemsSpec : Specification<ToDoItem>
{
    public IncompleteItemsSpec()
    {
        Query.Where(item => !item.IsDone);
    }
}
