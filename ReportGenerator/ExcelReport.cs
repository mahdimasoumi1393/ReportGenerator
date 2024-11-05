namespace ReportGenerator
{
    public class ExcelReport : IReport
    {
        public void Generate() => Console.WriteLine("Excel Report Generated.");
    }
}
