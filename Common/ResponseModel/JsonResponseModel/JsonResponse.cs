using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ResponseModel.JsonResponseModel
{
    public class JsonResponse
    {
        public JsonResponse() { }
        public string errorCode { get; set; }
        public string msg { get; set; }
        public string statusCode { get; set; }

        public void SetSuccessMessage(string errorCode, string msg,string statusCode)
        {
            this.errorCode = errorCode;
            this.msg = msg;
            this.statusCode = statusCode;
        }
        public void SetErrorMessage(string errorCode, string msg, string statusCode)
        {
            this.errorCode = errorCode;
            this.msg = msg;
            this.statusCode = statusCode;
        }
    }
}
