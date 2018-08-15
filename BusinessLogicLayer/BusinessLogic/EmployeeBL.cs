using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.EntityModel.Employee;
using Common.ResponseModel.EmployeeResponseModel;
using Common.ResponseModel.JsonResponseModel;
using Repository;
using Repository.EmployeeRepo;
using BusinessLogicLayer.BusinessLogic.Interface;

namespace BusinessLogicLayer.BusinessLogic
{
    public class EmployeeBL: IEmployeeBL
    {
        //public EmployeeBL(IEmployeeBL e)
        //{
        //}
        public EmployeeResponse CreateEmployees(EmployeeModel employeeModel, out JsonResponse resp)
        {
            try
            {
                EmployeeResponse employeeResponse = null;
                JsonResponse response = null;

                EmployeeRepo emp = new EmployeeRepo();
                var dt = emp.CreateEmployees(employeeModel);
                if (dt.Rows[0]["ErrorCode"].Equals("0"))
                {
                    employeeResponse = new EmployeeResponse();
                    employeeResponse.Name = dt.Rows[0]["Name"].ToString();
                    employeeResponse.Gender = dt.Rows[0]["Gender"].ToString();
                    employeeResponse.Occupation = dt.Rows[0]["Occupation"].ToString();
                    employeeResponse.Address = dt.Rows[0]["Address"].ToString();
                    employeeResponse.Dob = Convert.ToDateTime(dt.Rows[0]["Dob"].ToString());
                    employeeResponse.Email = dt.Rows[0]["Email"].ToString();
                    employeeResponse.IdType = dt.Rows[0]["IdType"].ToString();
                    employeeResponse.MobileNumber = dt.Rows[0]["MobileNumber"].ToString();
                    employeeResponse.WalletNumber = dt.Rows[0]["WalletNumber"].ToString();
                    employeeResponse.Salary = Convert.ToDouble(dt.Rows[0]["Salary"].ToString());
                    response = new JsonResponse();
                    response.SetSuccessMessage("0", dt.Rows[0]["mes"].ToString(), "200");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }
                else
                {
                    string message = dt.Rows[0]["mes"].ToString();
                    response = new JsonResponse();
                    response.SetErrorMessage("1", dt.Rows[0]["mes"].ToString(), "404");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }

                if (employeeResponse == null)
                {
                    employeeResponse = new EmployeeResponse();
                }
                return employeeResponse;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public EmployeeResponse UpdateEmployees(EmployeeModel employeeModel, out JsonResponse resp)
        {
            try
            {
                EmployeeResponse employeeResponse = null;
                JsonResponse response = null;

                EmployeeRepo emp = new EmployeeRepo();
                var dt = emp.UpdateEmployees(employeeModel);
                if (dt.Rows[0]["ErrorCode"].Equals("0"))
                {
                    employeeResponse = new EmployeeResponse();
                    employeeResponse.Name = dt.Rows[0]["Name"].ToString();
                    employeeResponse.Gender = dt.Rows[0]["Gender"].ToString();
                    employeeResponse.Occupation = dt.Rows[0]["Occupation"].ToString();
                    employeeResponse.Address = dt.Rows[0]["Address"].ToString();
                    employeeResponse.Dob = Convert.ToDateTime(dt.Rows[0]["Dob"].ToString());
                    employeeResponse.Email = dt.Rows[0]["Email"].ToString();
                    employeeResponse.IdType = dt.Rows[0]["IdType"].ToString();
                    employeeResponse.MobileNumber = dt.Rows[0]["MobileNumber"].ToString();
                    employeeResponse.WalletNumber = dt.Rows[0]["WalletNumber"].ToString();
                    employeeResponse.Salary = Convert.ToDouble(dt.Rows[0]["Salary"].ToString());
                    response = new JsonResponse();
                    response.SetSuccessMessage("0", dt.Rows[0]["mes"].ToString(), "200");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }
                else
                {
                    string message = dt.Rows[0]["mes"].ToString();
                    response = new JsonResponse();
                    response.SetErrorMessage("1", dt.Rows[0]["mes"].ToString(), "404");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }

                if (employeeResponse == null)
                {
                    employeeResponse = new EmployeeResponse();
                }
                return employeeResponse;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public EmployeeResponse DeleteEmployees(EmployeeModel employeeModel, out JsonResponse resp)
        {
            try
            {
                EmployeeResponse employeeResponse = null;
                JsonResponse response = null;

                EmployeeRepo emp = new EmployeeRepo();
                var dt = emp.DeleteEmployees(employeeModel);
                if (dt.Rows[0]["ErrorCode"].Equals("0"))
                {
                    //employeeResponse = new EmployeeResponse();
                    //employeeResponse.Name = dt.Rows[0]["Name"].ToString();
                    //employeeResponse.Gender = dt.Rows[0]["Gender"].ToString();
                    //employeeResponse.Occupation = dt.Rows[0]["Occupation"].ToString();
                    //employeeResponse.Address = dt.Rows[0]["Address"].ToString();
                    //employeeResponse.Dob = Convert.ToDateTime(dt.Rows[0]["Dob"].ToString());
                    //employeeResponse.Email = dt.Rows[0]["Email"].ToString();
                    //employeeResponse.IdType = dt.Rows[0]["IdType"].ToString();
                    //employeeResponse.MobileNumber = dt.Rows[0]["MobileNumber"].ToString();
                    //employeeResponse.WalletNumber = dt.Rows[0]["WalletNumber"].ToString();
                    //employeeResponse.Salary = Convert.ToDouble(dt.Rows[0]["Salary"].ToString());
                    response = new JsonResponse();
                    response.SetSuccessMessage("0", dt.Rows[0]["mes"].ToString(), "200");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }
                else
                {
                    string message = dt.Rows[0]["mes"].ToString();
                    response = new JsonResponse();
                    response.SetErrorMessage("1", dt.Rows[0]["mes"].ToString(), "404");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }

                if (employeeResponse == null)
                {
                    employeeResponse = new EmployeeResponse();
                }
                return employeeResponse;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public EmployeeResponse RetrieveSpecificEmployees(int Id, out JsonResponse resp)
        {
            try
            {
                EmployeeResponse employeeResponse = null;
                JsonResponse response = null;

                EmployeeRepo emp = new EmployeeRepo();
                var dt = emp.RetrieveSpecificEmployees(Id);
                if (dt.Rows[0]["ErrorCode"].Equals("0"))
                {

                    employeeResponse = new EmployeeResponse();
                    employeeResponse.Name = dt.Rows[0]["Name"].ToString();
                    employeeResponse.Gender = dt.Rows[0]["Gender"].ToString();
                    employeeResponse.Occupation = dt.Rows[0]["Occupation"].ToString();
                    employeeResponse.Address = dt.Rows[0]["Address"].ToString();
                    employeeResponse.Dob = Convert.ToDateTime(dt.Rows[0]["Dob"].ToString());
                    employeeResponse.Email = dt.Rows[0]["Email"].ToString();
                    employeeResponse.IdType = dt.Rows[0]["IdType"].ToString();
                    employeeResponse.MobileNumber = dt.Rows[0]["MobileNumber"].ToString();
                    employeeResponse.WalletNumber = dt.Rows[0]["WalletNumber"].ToString();
                    employeeResponse.Salary = Convert.ToDouble(dt.Rows[0]["Salary"].ToString());
                    response = new JsonResponse();
                    response.SetSuccessMessage("0", dt.Rows[0]["mes"].ToString(), "200");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }
                else
                {
                    string message = dt.Rows[0]["mes"].ToString();
                    response = new JsonResponse();
                    response.SetErrorMessage("1", dt.Rows[0]["mes"].ToString(), "404");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }

                if (employeeResponse == null)
                {
                    employeeResponse = new EmployeeResponse();
                }
                return employeeResponse;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public List<EmployeeResponse> RetrieveAllEmployees(out JsonResponse resp)
        {
            try
            {
                List<EmployeeResponse> lstEmployeeResponse = new List<EmployeeResponse>();

                JsonResponse response = null;

                EmployeeRepo emp = new EmployeeRepo();
                var dt = emp.RetrieveAllEmployees();
                if (dt.Rows[0]["ErrorCode"].Equals("0"))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        EmployeeResponse empResp = new EmployeeResponse();
                        empResp.Name = row["Name"].ToString();
                        empResp.Gender = row["Gender"].ToString();
                        empResp.Occupation = row["Occupation"].ToString();
                        empResp.Address = row["Address"].ToString();
                        empResp.Dob = Convert.ToDateTime(row["Dob"].ToString());
                        empResp.Email = row["Email"].ToString();
                        empResp.MobileNumber = row["MobileNumber"].ToString();
                        empResp.WalletNumber = row["WalletNumber"].ToString();
                        empResp.Salary = Convert.ToDouble(row["Salary"].ToString());
                        lstEmployeeResponse.Add(empResp);
                    }


                    //employeeResponse = new EmployeeResponse()
                    //{
                    //    Name = dt.Rows[0]["Name"].ToString()
                    //};
                    response = new JsonResponse();
                    response.SetSuccessMessage("0", dt.Rows[0]["mes"].ToString(), "200");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }
                else
                {
                    string message = dt.Rows[0]["mes"].ToString();
                    response = new JsonResponse();
                    response.SetErrorMessage("1", dt.Rows[0]["mes"].ToString(), "400");
                    resp = new JsonResponse();
                    resp.statusCode = response.statusCode;
                    resp.errorCode = response.errorCode;
                    resp.msg = response.msg;
                }

                if (lstEmployeeResponse == null)
                {
                    lstEmployeeResponse = new List<EmployeeResponse>();
                }
                return lstEmployeeResponse;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }
}
