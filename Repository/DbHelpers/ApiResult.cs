using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DbHelpers
{
    public class ApiResult
    {
        private string _errorCode = "1";
        private string _msg = "Error";
        private string _id = "0";


        public ApiResult() { }

        public string ErrorCode
        {
            set { _errorCode = value; }
            get { return _errorCode; }
        }

        public string Msg
        {
            set { _msg = value; }
            get { return _msg; }
        }

        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Extra { get; set; }
        public string Extra2 { get; set; }

        public void SetError(string errorCode, string msg, string id)
        {
            ErrorCode = errorCode;
            Msg = msg;
            Id = id;
        }

    }
}
