using Common.EntityModel.Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EmployeeRepo.Interface
{
    public interface IEmployeeRepo
    {
        DataTable CreateEmployees(EmployeeModel employeeModel);
        DataTable UpdateEmployees(EmployeeModel employeeModel);
        DataTable DeleteEmployees(EmployeeModel employeeModel);
        DataTable RetrieveAllEmployees();
        DataTable RetrieveSpecificEmployees(int Id);
    }
}
