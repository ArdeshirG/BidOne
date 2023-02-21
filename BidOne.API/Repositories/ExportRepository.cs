using System.Text.Json;

namespace BidOne.API.Repositories
{
    public class ExportRepository : IExportRepository
    {
        private string baseFileName = "ExportResult-";
        
        private readonly IWebHostEnvironment _env;

        private readonly ILogger _logger;

        public ExportRepository(IWebHostEnvironment env, ILogger<ExportRepository> logger)
        {
            _env = env;
            _logger = logger;
        }

        public async Task SaveAsJson<T>(T item)
        {
            try
            {
                string pathToSave = Path.Combine(_env.ContentRootPath, "Results");

                string fileName = $"{baseFileName}{typeof(T).Name}-{DateTime.Now:ddMMyyyy-HHmmss}.json";

                using FileStream fileStream = File.Create(Path.Combine(pathToSave, fileName));

                await JsonSerializer.SerializeAsync(fileStream, item);

                _logger.LogInformation($"Saved data to Json file: {fileName}");
            }
            catch (Exception)
            {
                _logger.LogError("Error on saving to Json file");
                throw;
            }
            
        }
    }
}
