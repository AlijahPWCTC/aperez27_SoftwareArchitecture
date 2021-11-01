using System;
namespace Module_2_Assignment
{
    public class EmployeeReportService
    {
        private string _report = "";

        public void addData(string data) {
            _report += data;
        }

        public void outputReport() {
            Console.WriteLine(_report);
        }

        public void clearReport() {
            _report = "";
        }
    }
}