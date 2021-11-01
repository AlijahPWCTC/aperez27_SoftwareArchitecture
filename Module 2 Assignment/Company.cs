namespace Module_2_Assignment
{
    public class Company
    {
        private HrPerson _hr;

        public Company() {
            _hr = new HrPerson();
        }

        public void hireEmployee(string firstName, string lastName, string ssn) {
            _hr.hireEmployee(firstName, lastName, ssn);
            _hr.outputReport(ssn);
        }
    }
}