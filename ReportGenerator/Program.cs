namespace ReportGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var reportGenerator = new ReportGenerator();
            

            try
            {
                var invalidReport = reportGenerator.CreateReport("InvalidType");
                invalidReport.Generate();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
