using System;

namespace DependencyBreakingExamples.ExtractInterface
{
    public class TestRunner
    {
        private readonly FileTestReport report;

        public TestRunner(FileTestReport report)
        {
            this.report = report;
        }

        public void Run(ITestCase test)
        {
            try
            {
                test.Run();
                report.ReportSuccess(test);
            }
            catch (Exception)
            {
                report.ReportFailure(test);
            }
        }
    }
}