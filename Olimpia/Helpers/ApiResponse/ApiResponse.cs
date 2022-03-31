using System.Collections.Generic;
using System.Net;

namespace Olimpia.Helpers.ApiResponse
{
    public class ApiResponse
    {
        public HttpStatusCode? status { get; set; }
        public IEnumerable<string> data { get; set; }
        public string Message { get; set; }        
    }
}
