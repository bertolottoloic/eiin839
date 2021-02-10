using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicServerHTTPlistener
{
    class Header
    {
        System.Net.WebHeaderCollection headers;
        Header() { }

        public Header(NameValueCollection headers)
        {
            this.headers = (System.Net.WebHeaderCollection) headers;
        }

        public String Display_Accept()
        {
            if(headers[System.Net.HttpRequestHeader.Accept] != null)
            {
                return "Accept : " + headers[System.Net.HttpRequestHeader.Accept].ToString();
            }

            return "Accept : ";
        }

        public String Display_AcceptCharset()
        {
            if (headers[System.Net.HttpRequestHeader.AcceptCharset] != null)
            {
                return "Accept-Charset : " + headers[System.Net.HttpRequestHeader.AcceptCharset].ToString();
            }

            return "Accept-Charset : ";
        }

        public String Display_AcceptEncoding()
        {
            if (headers[System.Net.HttpRequestHeader.AcceptEncoding] != null)
            {
                return "Accept-Encoding : " + headers[System.Net.HttpRequestHeader.AcceptEncoding].ToString();
            }
            return "Accept-Encoding : ";
        }

        public String Display_AcceptLanguage()
        {
            if (headers[System.Net.HttpRequestHeader.AcceptLanguage] != null)
            {
                return "Accept-Language : " + headers[System.Net.HttpRequestHeader.AcceptLanguage].ToString();
            }
            return "Accept-Language : ";
        }

        public String Display_Allow()
        {
            if (headers[System.Net.HttpRequestHeader.Allow] != null)
            {
                return "Allow : " + headers[System.Net.HttpRequestHeader.Allow].ToString();
            }
            return "Allow : ";
        }

        public String Display_Authorization()
        {
            if (headers[System.Net.HttpRequestHeader.Authorization] != null)
            {
                return "Authorization : " + headers[System.Net.HttpRequestHeader.Authorization].ToString();
            }
            return "Authorization : ";
        }

        public String Display_CacheControl()
        {
            if (headers[System.Net.HttpRequestHeader.CacheControl] != null)
            {
                return "Cache-Control : " + headers[System.Net.HttpRequestHeader.CacheControl].ToString();
            }
            return "Cache-Control : ";
        }

        public String Display_Connection()
        {
            if (headers[System.Net.HttpRequestHeader.Connection] != null)
            {
                return "Connection : " + headers[System.Net.HttpRequestHeader.Connection].ToString();
            }
            return "Connection : ";
        }

        public String Display_ContentEncoding()
        {
            if (headers[System.Net.HttpRequestHeader.ContentEncoding] != null)
            {
                return "Content-Encoding : " + headers[System.Net.HttpRequestHeader.ContentEncoding].ToString();
            }
            return "Content-Encoding : ";
        }

        public String Display_ContentLanguage()
        {
            if (headers[System.Net.HttpRequestHeader.ContentLanguage] != null)
            {
                return "Content-Language : " + headers[System.Net.HttpRequestHeader.ContentLanguage].ToString();
            }
            return "Content-Language : ";
        }

        public String Display_Cookie()
        {
            if (headers[System.Net.HttpRequestHeader.Cookie] != null)
            {
                return "Cookie : " + headers[System.Net.HttpRequestHeader.Cookie].ToString();
            }
            return "Cookie : ";
        }

        public String Display_From()
        {
            if (headers[System.Net.HttpRequestHeader.From] != null)
            {
                return "From : " + headers[System.Net.HttpRequestHeader.From].ToString();
            }
            return "From : ";
        }

        public String Display_UserAgent()
        {
            if (headers[System.Net.HttpRequestHeader.UserAgent] != null)
            {
                return "User-Agent : " + headers[System.Net.HttpRequestHeader.UserAgent].ToString();
            }
            return "User-Agent : ";
        }

        public override String ToString()
        {
            return headers.ToString();
        }
    }
}
