using System;
using System.Collections.Generic;
namespace Module_2_Assignment
{
    public class HrPerson
    {
        private List<Employee> _employees = new List<Employee>();
        public HrPerson() {

        }

        public void hireEmployee(String firstName, String lastName, String ssn) {
            Employee e = new Employee(firstName, lastName, ssn);
            _employees.Add(e);
            orientEmployee(e);
        }
         // HRManager delegates work to employee.
        private void orientEmployee(Employee emp) {
            emp.doFirstTimeOrientation("B101");
        }

        public void outputReport(String ssn) {
            // Find employee in list.
            foreach (Employee emp in _employees) {
                if (emp.getSsn()==(ssn)) {
                    // If found run report.
                    if (emp.hasMetWithHr() && emp.hasMetDeptStaff()
                            && emp.hasReviewedDeptPolicies() && emp.hasMovedIn()) {
                        emp.printReport();
                    }
                    break;
                }
            }
        }
    }
}