using Common.EntityModel.Employee;
using Repository.DbHelpers;
using Repository.EmployeeRepo.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.EmployeeRepo
{
   public  class EmployeeRepo : IEmployeeRepo
    {
        Dao _dao = new Dao();
        public DataTable CreateEmployees(EmployeeModel employeeModel)
        {
            
            //DataTable dt = new DataTable();
            var sql = "EXEC proc_EmployeeOperation";
            sql += " @flag = 'i'";
            sql += ", @name = " + _dao.FilterString(employeeModel.Name);
            sql += ", @gender = " + _dao.FilterString(employeeModel.Gender);
            sql += ", @salary = " + _dao.FilterString(employeeModel.Salary.ToString());
            sql += ", @address = " + _dao.FilterString(employeeModel.Address);
            sql += ", @email = " + _dao.FilterString(employeeModel.Email);
            sql += ", @dob = " + _dao.ParseDate(employeeModel.Dob.ToString());
            sql += ", @occupation = " + _dao.FilterString(employeeModel.Occupation);
            sql += ", @idType = " + _dao.FilterString(employeeModel.IdType);
            sql += ", @walletNumber = " + _dao.FilterString(employeeModel.WalletNumber);
            sql += ", @mobileNumber = " + _dao.FilterString(employeeModel.MobileNumber);
            return _dao.ExecuteDataTable(sql);
           
        }
        public DataTable UpdateEmployees(EmployeeModel employeeModel)
        {

            var sql = "EXEC proc_EmployeeOperation";
            sql += " @flag = 'u'";
            sql += ", @name = " + _dao.FilterString(employeeModel.Name);
            sql += ", @gender = " + _dao.FilterString(employeeModel.Gender);
            sql += ", @salary = " + _dao.FilterString(employeeModel.Salary.ToString());
            sql += ", @address = " + _dao.FilterString(employeeModel.Address);
            sql += ", @email = " + _dao.FilterString(employeeModel.Email);
            sql += ", @dob = " + _dao.ParseDate(employeeModel.Dob.ToString());
            sql += ", @occupation = " + _dao.FilterString(employeeModel.Occupation);
            sql += ", @idType = " + _dao.FilterString(employeeModel.IdType);
            sql += ", @walletNumber = " + _dao.FilterString(employeeModel.WalletNumber);
            sql += ", @mobileNumber = " + _dao.FilterString(employeeModel.MobileNumber);
            sql += ", @Id = " + _dao.FilterString(employeeModel.Id.ToString());
            return _dao.ExecuteDataTable(sql);

        }
        public DataTable DeleteEmployees(EmployeeModel employeeModel)
        {

       
            var sql = "EXEC proc_EmployeeOperation";
            sql += " @flag = 'd'";
            sql += ", @Id = " + _dao.FilterString(employeeModel.Id.ToString());
            return _dao.ExecuteDataTable(sql);

        }
        public DataTable RetrieveAllEmployees()
        {

          
            var sql = "EXEC proc_EmployeeOperation";
            sql += " @flag = 'sa'";
            return _dao.ExecuteDataTable(sql);

        }
        public DataTable RetrieveSpecificEmployees(int Id)
        {

         
            var sql = "EXEC proc_EmployeeOperation";
            sql += " @flag = 's-one'";
            sql += ", @Id = " + _dao.FilterString(Id.ToString());
            return _dao.ExecuteDataTable(sql);

        }

        //public ApiResult CreateReceiver()
        //{
        //    var sql = "";
        //    return _dao.ParseDbResult(sql);
        //}
    }
}
