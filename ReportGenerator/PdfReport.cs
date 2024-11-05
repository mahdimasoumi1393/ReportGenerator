namespace ReportGenerator
{
    public class PdfReport : IReport
    {
        public void Generate() => Console.WriteLine("PDF Report Generated.");
    }
}
