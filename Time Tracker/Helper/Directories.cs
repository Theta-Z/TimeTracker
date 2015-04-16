using System.IO;

namespace Time_Tracker.Helper
{
    public class Directories
    {
        public static void CreateLocalDirectoryIfNotExists(string path)
        {
            var local = Directory.GetCurrentDirectory();
            var directory = Path.Combine(local, path);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }

        public static bool LocalDirectoryExists(string path)
        {
            var local = Directory.GetCurrentDirectory();
            var directory = Path.Combine(local, path);

            return Directory.Exists(directory);
        }

        public static bool LocalFileExists(string path)
        {
            var local = Directory.GetCurrentDirectory();
            var directory = Path.Combine(local, path);

            return File.Exists(directory);
        }

        public static string LocalDirectoryPath(string path)
        {
            var local = Directory.GetCurrentDirectory();
            var directory = Path.Combine(local, path);

            return directory;
        }
    }
}