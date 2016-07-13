using System.Net;

namespace VkApi._001_FirstApp.CommonWeb
{
    public class VkAuth
    {
        public static void OAuth(string login, string password)
        {
            var request = (HttpWebRequest)WebRequest.Create("");
            request.Timeout = 10000;
            request.CookieContainer = new CookieContainer();
            request.Method = "POST";
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
            
        }


    }
}
