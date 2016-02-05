using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MyHttpRequest;
using System.Web.Http.Properties;


namespace BikashPayment
{
    public class PaymentVerify
    {
      
    public static string GetOneAddressAsJSON(IAsyncResult result)
        {
            string results = "";


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("bkash api url");


            request.Method = "GET";
            request.Accept = "application/json";


            HttpWebRequest Request = (HttpWebRequest)result.AsyncState;
            WebResponse response = Request.EndGetResponse(result);

          //  HttpWebResponse response = (HttpWebResponse)request.EndGetResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder output = new StringBuilder();
            output.Append(reader.ReadToEnd());


            
            results = output.ToString();
            return results;
            System.Diagnostics.Debug.WriteLine(results);
        }
    
    }
}
