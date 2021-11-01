using System;
using System.Collections.Generic;
namespace Module_2_Assignment
{
    public class Employee
    {
        private string REQUIRED_MSG = " is mandatory ";
        private  string NEWLINE = "\n";

        private string _firstName;
        private string _lastName;
        private string _ssn;
        private bool _metWithHr;
        private bool _metDeptStaff;
        private bool _reviewedDeptPolicies;
        private bool _movedIn;
        private string _cubeId;
        private DateTime _orientationDate;
        private EmployeeReportService _reportService = new EmployeeReportService();

        public Employee(string _firstName, string lastName, string ssn) {
            set_firstName(_firstName);
            setLastName(lastName);
            setSsn(ssn);
        }

        private string getFormattedDate() {
            return _orientationDate.ToString("MMMM dd, yyyy");
        }

        public void doFirstTimeOrientation(string cubeId) {
            _orientationDate = DateTime.Today;
            meetWithHrForBenefitAndSalaryInfo();
            meetDepartmentStaff();
            reviewDeptPolicies();
            moveIntoCubicle(cubeId);
        }

        private void meetWithHrForBenefitAndSalaryInfo() {
            _metWithHr = true;
            _reportService.addData(_firstName + " " + _lastName + " met with HR on "
                    + getFormattedDate() + NEWLINE);
        }

        private void meetDepartmentStaff() {
            _metDeptStaff = true;
            _reportService.addData(_firstName + " " + _lastName + " met with dept staff on "
                    + getFormattedDate() + NEWLINE);
        }

        public void reviewDeptPolicies() {
            _reviewedDeptPolicies = true;
            _reportService.addData(_firstName + " " + _lastName + " reviewed dept policies on "
                    + getFormattedDate() + NEWLINE);
        }

        public void moveIntoCubicle(string cubeId) {
            setCubeId(cubeId);

            this._movedIn = true;
            _reportService.addData(_firstName + " " + _lastName + " moved into cubicle "
                    + cubeId + " on " + getFormattedDate() + NEWLINE);
        }

        public string get_firstName() {
            return _firstName;
        }

        public void set_firstName(string _firstName) {
            if (_firstName == null || _firstName.Equals("")) {
                throw new ArgumentException("First name" + REQUIRED_MSG);
            }
            this._firstName = _firstName;
        }

        public string getLastName() {
            return _lastName;
        }
        public void setLastName(string lastName) {
            if (lastName == null || lastName.Equals("")) {
                throw new ArgumentException("Last name" + REQUIRED_MSG);
            }
            this._lastName = lastName;
        }

        public string getSsn() {
            return _ssn;
        }

        public void setSsn(string ssn) {
            if (ssn == null || ssn.Equals("")) {
                throw new ArgumentException("SSN" + REQUIRED_MSG);
            }
            this._ssn = ssn;
        }

        public bool hasMetWithHr() {
            return _metWithHr;
        }

        public bool hasMetDeptStaff() {
            return _metDeptStaff;
        }

        public bool hasReviewedDeptPolicies() {
            return _reviewedDeptPolicies;
        }

        public bool hasMovedIn() {
            return _movedIn;
        }

        public string getCubeId() {
            return _cubeId;
        }

        public void setCubeId(string cubeId) {
            if (cubeId == null || cubeId.Equals("")) {
                throw new ArgumentException("Cube ID" + REQUIRED_MSG);
            }
            this._cubeId = cubeId;
        }

        public DateTime getOrientationDate() {
            return _orientationDate;
        }

        public void setOrientationDate(DateTime orientationDate) {
            if (orientationDate == null) {
                throw new ArgumentException("orientationDate" + REQUIRED_MSG);
            }
            this._orientationDate = orientationDate;
        }

        public void printReport() {
            _reportService.outputReport();
        }

        public string tostring() {
            return "Employee{" + "_firstName=" + _firstName + ", lastName=" + _lastName + ", ssn=" + _ssn + '}';
        }
    }
}