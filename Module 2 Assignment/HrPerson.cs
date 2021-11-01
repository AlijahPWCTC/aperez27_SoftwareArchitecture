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
        private void orientEmployee(Employee emp) {
            emp.doFirstTimeOrientation("B101");
        }

        public void outputReport(String ssn) {
            foreach (Employee emp in _employees) {
                if (emp.getSsn()==(ssn)) {
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