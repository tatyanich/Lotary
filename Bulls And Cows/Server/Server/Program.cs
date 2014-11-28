using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Bulls_And_Cows;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost myServiceHost = new ServiceHost(typeof(Combination), new Uri[] { });
            myServiceHost.AddServiceEndpoint(typeof(IBulls_And_Cows), new WSHttpBinding(),
                                              "http://localhost:8088/Bulls_And_Cows/Combination/");                         
            myServiceHost.Open();
            Console.WriteLine("wcf-служба доступена");
            Console.ReadLine();
            myServiceHost.Close();
        }
    }
}
