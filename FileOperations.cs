
using System.IO;

namespace AdvancedDesktopApp
{
    public static class FileOperations
    {
        public static string ReadFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return "File not found.";
        }

        public static void WriteFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }
    }
}
