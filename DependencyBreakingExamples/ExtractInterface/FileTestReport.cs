using System.IO;

namespace DependencyBreakingExamples.ExtractInterface
{
    public class FileTestReport
    {
        private readonly StreamWriter writer;

        public FileTestReport(FileInfo file)
        {
            writer = new StreamWriter(file.OpenWrite());
        }


        public void ReportSuccess(ITestCase test)
        {
            Write("Succesful: " + test.GetType() + "\n");
        }

        public void ReportFailure(ITestCase test)
        {
            Write("Failure: " + test.GetType() + "\n");
        }

        private void Write(string line)
        {
            writer.WriteLine(line);
        }

        public void Close()
        {
            writer.Close();
        }
    }
}