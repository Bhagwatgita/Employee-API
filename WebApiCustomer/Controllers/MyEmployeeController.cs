using BusinessLogicLayer;
using BusinessLogicLayer.BusinessLogic;
using BusinessLogicLayer.BusinessLogic.Interface;
using Common.EntityModel.Employee;
using Common.ResponseModel.EmployeeResponseModel;
using Common.ResponseModel.JsonResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiCustomer.Controllers
{

    [RoutePrefix("api/v1/employees")]
    public class MyEmployeeController : ApiController
    {
        private IEmployeeBL _repository;

        public MyEmployeeController(IEmployeeBL repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateEmployee(EmployeeModel employee)
        {
            var jsonResponse = new JsonResponse();
           // IEmployeeBL emp = new EmployeeBL(_repository);
            if (ModelState.IsValid)
            {
                var response = _repository.CreateEmployees(employee, out jsonResponse);
                if (jsonResponse.errorCode.Equals("0"))
                {
                    return Content<EmployeeResponse>(HttpStatusCode.Created, response);
                }
                else
                {
                    return Json<JsonResponse>(jsonResponse);
                }
            }
            else
            {
                return Json<JsonResponse>(jsonResponse);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult UpdateEmployee(EmployeeModel employee)
        {
            var jsonResponse = new JsonResponse();
           // IEmployeeBL emp = new EmployeeBL(_repository);
            if (ModelState.IsValid)
            {
                var response = _repository.UpdateEmployees(employee, out jsonResponse);
                if (jsonResponse.errorCode.Equals("0"))
                {
                    return Content<EmployeeResponse>(HttpStatusCode.Created, response);
                }
                else
                {
                    return Json<JsonResponse>(jsonResponse);
                }
            }
            else
            {
                return Json<JsonResponse>(jsonResponse);
            }
        }
        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeleteEmployee(EmployeeModel employee)
        {
            var jsonResponse = new JsonResponse();
           // IEmployeeBL emp = new EmployeeBL(_repository);
            if (ModelState.IsValid)
            {
                var response = _repository.DeleteEmployees(employee, out jsonResponse);
                if (jsonResponse.errorCode.Equals("0"))
                {
                    return Content<JsonResponse>(HttpStatusCode.Created, jsonResponse);
                }
                else
                {
                    return Json<JsonResponse>(jsonResponse);
                }
            }
            else
            {
                return Json<JsonResponse>(jsonResponse);
            }
        }
        [HttpGet]
        [Route("retrieveOne/{Id:int}")]
        public IHttpActionResult RetrieveSpecificEmployee(int Id)
        {
            var jsonResponse = new JsonResponse();
           // IEmployeeBL emp = new EmployeeBL(_repository);
            if (ModelState.IsValid)
            {
                var response = _repository.RetrieveSpecificEmployees(Id, out jsonResponse);
                if (jsonResponse.errorCode.Equals("0"))
                {
                    return Content<EmployeeResponse>(HttpStatusCode.Created, response);
                }
                else
                {
                    return Json<JsonResponse>(jsonResponse);
                }
            }
            else
            {
                return Json<JsonResponse>(jsonResponse);
            }
        }
        [HttpGet]
        [Route("retrieveAll")]
        public IHttpActionResult RetrieveAllEmployee(EmployeeModel employee)
        {
            var jsonResponse = new JsonResponse();
           // IEmployeeBL emp = new EmployeeBL(_repository);
            if (ModelState.IsValid)
            {
                var response = _repository.RetrieveAllEmployees(out jsonResponse);
                if (jsonResponse.errorCode.Equals("0"))
                {
                    return Content<List<EmployeeResponse>>(HttpStatusCode.Created, response);
                }
                else
                {
                    return Json<JsonResponse>(jsonResponse);
                }
            }
            else
            {
                return Json<JsonResponse>(jsonResponse);
            }
        }
    }
}
