using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.VIewModels
{
    public class ReturnResult
    {
        public bool Success {  get; set; }
        public ErrorDetails Error { get; set; } = new ErrorDetails();
    }

    public class ErrorDetails
    {
        public int Code { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
