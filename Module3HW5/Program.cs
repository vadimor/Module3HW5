using Module3HW5.Service;

namespace Module3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileReaderService = new FileReaderService();
            var str = fileReaderService.ReadFilesAsync("Hello.txt", "word.txt").GetAwaiter().GetResult();
            System.Console.WriteLine(str);
        }
    }
}
