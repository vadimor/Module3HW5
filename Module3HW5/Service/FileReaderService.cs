using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace Module3HW5.Service
{
    public class FileReaderService
    {
        public async Task<string> ReadFilesAsync(params string[] paths)
        {
            var list = new List<Task<string>>();
            foreach (var item in paths)
            {
                list.Add(ReadFileAsync(item));
            }

            await Task.WhenAll(list);
            var stringBuilder = new StringBuilder();
            foreach (var item in list.Select((s) => s.Result))
            {
                stringBuilder.Append(item);
            }

            return stringBuilder.ToString();
        }

        private async Task<string> ReadFileAsync(string path)
        {
            var str = await File.ReadAllTextAsync(path);
            return str;
        }
    }
}
