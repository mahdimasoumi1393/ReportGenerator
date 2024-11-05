namespace ReportGenerator
{
    public class ASCIIReport : IReport
    {
        public void Generate() => Console.WriteLine("ASCII Report Generated.");
    }
}
