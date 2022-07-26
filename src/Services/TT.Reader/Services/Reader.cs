using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace TT.Reader.Services
{
    public class Reader : Interfaces.IReader
    {
        private readonly CsvConfiguration _config;

        public Reader()
        {
            _config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
        }

        public List<T> Read<T>(string filePath, Func<T, bool> predicate = null) where T : class
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, _config);
            var list = csv.GetRecords<T>().Where(predicate).ToList();
            return list;
        }
    }
}
