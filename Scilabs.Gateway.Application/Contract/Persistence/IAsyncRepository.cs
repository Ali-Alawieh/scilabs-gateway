namespace Scilabs.Gateway.Application.Contract.Persistence;

public interface IAsyncRepository<T> where T : class
{
    Task<IReadOnlyList<T>> ListAllAsync();
}