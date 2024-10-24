
using Xunit;

namespace AdvancedDesktopApp.Tests
{
    public class BusinessLogicTests
    {
        [Fact]
        public void TestFileOperations()
        {
            string content = "Test content";
            string path = "test.txt";
            FileOperations.WriteFile(path, content);
            string readContent = FileOperations.ReadFile(path);
            Assert.Equal(content, readContent);
        }
    }
}
