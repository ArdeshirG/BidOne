using BidOne.API.Repositories;
using Moq;

namespace BidOne.API.Test.Repositories
{
    internal class ExportRepositoryMock
    {
        public Mock<IExportRepository> mockRepo;
        public ExportRepositoryMock()
        {
            mockRepo = new Mock<IExportRepository>();
        }
    }
}
