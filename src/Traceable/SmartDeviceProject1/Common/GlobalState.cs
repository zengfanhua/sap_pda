using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1.Common
{
    public class GlobalState
    {
        public static string UserID { get; set; }

        public static string Werks { get; set; }

        private static Webservice1.zdev02_webservice webService { get; set; }

        public static string GetServiceAddress()
        {
            //todo: get service address from app config file
            return "http://114.251.177.94:8000/sap/bc/srt/rfc/sap/zuser_chack/500/zuser_chack/binding";
        }

        public static System.Net.NetworkCredential GetNetworkCredential()
        {
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential();
            credential.UserName = "sd02";
            credential.Password = "123456";

            return credential;
        }

        public static Webservice1.zdev02_webservice GetWebService()
        {
            //todo: get service address from app config file
            string address = GetServiceAddress();

            if (webService == null)
            {
                Webservice1.zdev02_webservice service = new SmartDeviceProject1.Webservice1.zdev02_webservice(address);
                service.Credentials = GetNetworkCredential();
                webService = service;
            }

            return webService;
        }

        public static string[] ExtractBarcode(string barcode)
        {
            barcode = barcode.Replace("||", "^");
            return barcode.Split('^');
        }
    }
}
