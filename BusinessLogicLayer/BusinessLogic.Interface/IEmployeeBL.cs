using Common.EntityModel.Employee;
using Common.ResponseModel.EmployeeResponseModel;
using Common.ResponseModel.JsonResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessLogic.Interface
{
    public interface IEmployeeBL
    {
        EmployeeResponse CreateEmployees(EmployeeModel employeeModel, out JsonResponse resp);
        EmployeeResponse UpdateEmployees(EmployeeModel employeeModel, out JsonResponse resp);
        EmployeeResponse DeleteEmployees(EmployeeModel employeeModel, out JsonResponse resp);
        EmployeeResponse RetrieveSpecificEmployees(int Id, out JsonResponse resp);
        List<EmployeeResponse> RetrieveAllEmployees(out JsonResponse resp);
    }
}
