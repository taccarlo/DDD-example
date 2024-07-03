using Ardalis.Specification;

namespace NimblePros.DotNetConf.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
