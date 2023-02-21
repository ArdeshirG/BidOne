namespace BidOne.API.Repositories
{
    public interface IExportRepository
    {
        Task SaveAsJson<T>(T item);
    }
}
