using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BasicServerHTTPlistener
{
    class MyMethods
    {
        System.Net.HttpListenerRequest request;

        public MyMethods(System.Net.HttpListenerRequest request)
        {
            this.request = request;
        }
        public string MyMethod()
        {
            return "<HTML><BODY> Hello " + HttpUtility.ParseQueryString(request.Url.Query).Get("param1") + " " + HttpUtility.ParseQueryString(request.Url.Query).Get("param2") + "</BODY><HTML>";
        }
    }
}
