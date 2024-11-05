using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{

    public class ReportGenerator
    {
        public IReport CreateReport(string reportType)
        {
            Console.WriteLine("Please choose on of these formats to export: \n PDF \n Excel \n Word \n ASCCI");
            string userInput = Console.ReadLine();
            reportType = userInput.Trim().ToUpper();

            if (reportType == "PDF")
                return new PdfReport();
            else if (reportType == "EXCEL")
                return new ExcelReport();
            else if (reportType == "WORD")
                return new WordReport();
            else if(reportType == "ASCII")
                return new ASCIIReport();
            else
                throw new ArgumentException("Invalid report type");
        }

    }
}
