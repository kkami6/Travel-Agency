using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace TestingLayer
{
    [TestFixture]
    public class EmployeesConextTests
    {
        static EmployeesContext employeesConext;

        public EmployeesConextTests()
        {
            employeesConext = new EmployeesContext(TestManager.dbContext);
        }

        [Test]
        public void CreateEmployee()
        {
            Employee employee = new Employee("Kaloyan", "Preslavov", "Magnaurski", 38, "Manager", 8000);
            employeesConext.Create(employee);

            Employee lastEmployee = TestManager.dbContext.Employees.Last();

            Assert.That(lastEmployee.Name, Is.EqualTo(employee.Name), "The Create() method does not work!!!! :(");
        }

        [Test]

        public void ReadEmployee()
        {
            Employee employee = new Employee("Kaloyan", "Preslavov", "Magnaurski", 38, "Manager", 8000);
            employeesConext.Create(employee);

            Employee emp = employeesConext.Read(1);

            Assert.That(emp.Name == "Kaloyan" || emp.SecondName == "Preslavov", "The Read() method does not work :(");
        }

        [Test]

        public void ReadAllEmployees()
        {
            int employeesBefore = TestManager.dbContext.Employees.Count();

            int employeesAfter = employeesConext.ReadAll().Count;

            Assert.That(employeesBefore == employeesAfter, "The ReadAll() method does not work :(");
        }

        [Test]

        public void UpdateEmployee()
        {
            Employee newEmp = new Employee("Kaloyan", "Preslavov", "Magnaurski", 38, "Manager", 8000);
            employeesConext.Create(newEmp);
            

            Employee lastEmp = employeesConext.ReadAll().Last();
            lastEmp.Name = "Viktor";

            employeesConext.Update(lastEmp, false);

            Assert.That(employeesConext.Read(lastEmp.EmployeeId).Name == "Viktor" , "The Update() does not work!!!");
        }

        [Test]

        public void DeleteEmployee()
        {
            Employee newEmp = new Employee("Kaloyan", "Preslavov", "Magnaurski", 38, "Manager", 8000);
            employeesConext.Create(newEmp);

            List<Employee> employees = employeesConext.ReadAll();
            int empBefore = employees.Count();
            Employee lastEmp = employees.Last();
            employeesConext.Delete(lastEmp.EmployeeId);

            int empAfter = employeesConext.ReadAll().Count;
            Assert.That(empBefore == empAfter + 1, "The Delete() method does not work :(");
        }
    }
}
