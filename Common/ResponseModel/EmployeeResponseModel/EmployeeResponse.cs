using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ResponseModel.EmployeeResponseModel
{
    public class EmployeeResponse
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public string Occupation { get; set; }
        public string IdType { get; set; }
        public string WalletNumber { get; set; }
        public string MobileNumber { get; set; }
    }
}
